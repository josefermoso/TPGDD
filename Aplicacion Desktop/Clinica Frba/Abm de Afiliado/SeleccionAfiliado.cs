using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class SeleccionAfiliado : Form
    {
         public SeleccionAfiliado()
        {
            InitializeComponent();
            //Cargo el combo de tipo de documentos
            FuncionesCargarComboBox.cargarTipoDocumentos(tipoDocumento);
        }

        public DataGridViewRow selected;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SeleccionAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            String query = "SELECT PA_NAFILIADO, PE_NOMBRE, PE_APELLIDO, PE_SEXO as SEXO, PE_TIPO_DOC, TIPODOC_DESCRIPCION as TIPO_DOCUMENTO, PE_NUM_DOC, PL_CODIGO, PL_DESCRIPCION as PLAN_MEDICO, PA_ESTADO_CIVIL, PE_FECHA_NAC, PE_DIRECCION, PE_MAIL, PE_TELEFONO FROM BUGDEVELOPING.PERSONA LEFT JOIN BUGDEVELOPING.PACIENTE ON (PE_ID = PA_PERSONA) LEFT JOIN BUGDEVELOPING.PLAN_MEDICO ON (PA_PLAN = PL_CODIGO) JOIN BUGDEVELOPING.ESTADO_CIVIL ON (PA_ESTADO_CIVIL = ESTADO_CIVIL_ID) JOIN BUGDEVELOPING.TIPO_DOCUMENTO ON (PE_TIPO_DOC = TIPODOC_ID OR PE_TIPO_DOC IS NULL) WHERE PA_ACTIVO = 1";
            
            if (!tipoDocumento.Text.Equals("Seleccione"))
            {
                query = query + " AND PE_TIPO_DOC = " + tipoDocumento.SelectedValue;
            }
            if (documento.Text.Length > 0)
            {
                if (similares.Checked)
                {
                    query = query + " AND PE_NUM_DOC LIKE '%" + documento.Text + "%'";
                }
                else
                {
                    query = query + " AND PE_NUM_DOC = '" + documento.Text + "'";
                }
            }
            if (apellido.Text.Length > 0)
            {
                if (similares.Checked)
                {
                    query = query + " AND PE_APELLIDO LIKE '%" + apellido.Text + "%' COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI";// 
                }
                else
                {
                    query = query + " AND PE_APELLIDO = '" + apellido.Text + "'COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI";
                }
            }
            long number;
            if (id.Text.Length > 0 && long.TryParse(id.Text, out number))
            {
                query = query + " AND PA_NAFILIADO LIKE '%" + id.Text + "%'";
            }
            query = query + ";";

            System.Diagnostics.Debug.Write(query);

            ConnectorClass con = ConnectorClass.Instance;
            grillaProfesional.DataSource = con.executeQuery(query);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            apellido.Clear();
            id.Clear();
            tipoDocumento.SelectedValue = 0;
            documento.Clear();
            grillaProfesional.DataSource = null;
            grillaProfesional.Rows.Clear();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (grillaProfesional.SelectedRows != null && grillaProfesional.SelectedRows.Count > 0)
            {
                selected = grillaProfesional.SelectedRows[0];
                DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Seleccione un afiliado");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            selected = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
