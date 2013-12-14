using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class SeleccionProfesional : Form
    {
        public SeleccionProfesional()
        {
            InitializeComponent();
            //Cargo el combo de tipo de documentos
            FuncionesCargarComboBox.cargarTipoDocumentos(tipoDocumento);
        }

        public DataGridViewRow selected;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SeleccionProfesional_Load(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            String query = "SELECT ME_PERSONA AS 'ID_PROFESIONAL', ME_MATRICULA AS 'MATRICULA', PE_NOMBRE NOMBRE, PE_APELLIDO APELLIDO, TIPODOC_ID, TIPODOC_DESCRIPCION AS TIPO_DOCUMENTO, PE_NUM_DOC DOCUMENTO, PE_DIRECCION DIRECCION, PE_TELEFONO TELEFONO, PE_MAIL MAIL, PE_FECHA_NAC FECHA_NACIMIENTO, PE_SEXO AS SEXO FROM BUGDEVELOPING.PERSONA JOIN BUGDEVELOPING.MEDICO ON (PE_ID = ME_PERSONA) JOIN BUGDEVELOPING.TIPO_DOCUMENTO ON (TIPODOC_ID = PE_TIPO_DOC OR PE_TIPO_DOC IS NULL) WHERE ME_ACTIVO = 1";

            if (!tipoDocumento.Text.Equals("Seleccione"))
            {
                query = query + " AND TIPODOC_ID = " + tipoDocumento.SelectedValue;
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
                    query = query + " AND PE_APELLIDO LIKE '%" + apellido.Text + "%' COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI";
                }
                else
                {
                    query = query + " AND PE_APELLIDO = '" + apellido.Text + "' COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI";
                }
            }
            long number;
            if (id.Text.Length > 0 && long.TryParse(id.Text, out number))
            {
                query = query + " AND ME_PERSONA LIKE '%" + id.Text + "%'";
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
                MessageBox.Show("Seleccione un profesional");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            selected = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
