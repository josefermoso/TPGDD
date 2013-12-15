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
    public partial class FormProfesional : Form
    {
        DataGridViewRow selected;
        ListBox especialidades;

        public FormProfesional()
        {
            InitializeComponent();

            FuncionesCargarComboBox.cargarSexos(sexo);
            FuncionesCargarComboBox.cargarTipoDocumentos(tipoDocumento);

        }

        public FormProfesional(DataGridViewRow tomodify)
        {
            InitializeComponent();
            selected = tomodify;

            FuncionesCargarComboBox.cargarSexos(sexo);
            FuncionesCargarComboBox.cargarTipoDocumentos(tipoDocumento);

            maskedNombre.Text = selected.Cells["NOMBRE"].Value.ToString();
            maskedApellido.Text = selected.Cells["APELLIDO"].Value.ToString();
            documento.Text = selected.Cells["DOCUMENTO"].Value.ToString();
            maskedDireccion.Text = selected.Cells["DIRECCION"].Value.ToString();
            maskedTelefono.Text = selected.Cells["TELEFONO"].Value.ToString();
            mail.Text = selected.Cells["MAIL"].Value.ToString();
            matricula.Text = selected.Cells["MATRICULA"].Value.ToString();
            sexo.SelectedValue = (selected.Cells["SEXO"].Value) is DBNull ? 0 : selected.Cells["SEXO"].Value;
            tipoDocumento.SelectedValue = (selected.Cells["TIPODOC_ID"].Value is DBNull) ? 0 : selected.Cells["TIPODOC_ID"].Value;
            fechaNacimiento.Value = (DateTime)selected.Cells["FECHA_NACIMIENTO"].Value;
        }

        private void ABMProfesionalEdit_Load(object sender, EventArgs e)
        {

        }

        public bool yaExiste()
        {
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery("select * from BUGDEVELOPING.PERSONA JOIN BUGDEVELOPING.MEDICO ON (ME_PERSONA  = PE_ID) where PE_NUM_DOC=" + documento.Text);

            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

            String pattern;
            String query;
            ConnectorClass con = ConnectorClass.Instance;

            long number;
            if (maskedNombre.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el nombre del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (maskedApellido.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el apellido del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (documento.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el documento del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!long.TryParse(documento.Text, out number))
            {
                MessageBox.Show("El documento no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!long.TryParse(matricula.Text, out number))
            {
                MessageBox.Show("La matrícula no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tipoDocumento.Text.Equals("Seleccione"))
            {
                MessageBox.Show("Debe seleccionar el tipo de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (sexo.Text.Equals("Seleccione"))
            {
                MessageBox.Show("Debe seleccionar el sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selected != null)
            {
                /*********************** UPDATE TABLA PERSONA ******************************/
                pattern = "UPDATE BUGDEVELOPING.PERSONA SET PE_NOMBRE = '{0}', PE_APELLIDO = '{1}', PE_NUM_DOC = {2}, PE_DIRECCION = '{3}', PE_TELEFONO = '{4}', PE_MAIL = '{5}', PE_TIPO_DOC = {6}, PE_SEXO = '{7}', PE_FECHA_NAC = CONVERT(datetime, '{8}', 112) WHERE PE_ID = {9}";
                query = String.Format(pattern, maskedNombre.Text.Trim(), maskedApellido.Text.Trim(), documento.Text, maskedDireccion.Text.Trim(), maskedTelefono.Text.Trim(), mail.Text, tipoDocumento.SelectedValue, sexo.SelectedValue, fechaNacimiento.Value.Date.ToString("yyyyMMdd"), selected.Cells["ID_PROFESIONAL"].Value.ToString());
                System.Diagnostics.Debug.WriteLine(query);
                con.executeQuery(query);
                /*********************** UPDATE TABLA MEDICO ******************************/
                pattern = "UPDATE BUGDEVELOPING.MEDICO SET ME_MATRICULA = '{0}' WHERE ME_PERSONA = {1}";
                query = String.Format(pattern, matricula.Text, selected.Cells["ID_PROFESIONAL"].Value.ToString());
                System.Diagnostics.Debug.WriteLine(query);
                con.executeQuery(query);
            }
            else
            {
                /*********************** INSERTAMOS EN LA TABLA PERSONA *****************/
                pattern = "INSERT INTO BUGDEVELOPING.PERSONA (PE_NOMBRE, PE_APELLIDO, PE_NUM_DOC, PE_DIRECCION, PE_TELEFONO, PE_MAIL, PE_TIPO_DOC, PE_SEXO, PE_FECHA_NAC) VALUES ('{0}','{1}',{2},'{3}','{4}','{5}',{6},'{7}', CONVERT(datetime, '{8}', 112))";
                query = String.Format(pattern, maskedNombre.Text.Trim(), maskedApellido.Text.Trim(), documento.Text, maskedDireccion.Text.Trim(), maskedTelefono.Text.Trim(), mail.Text, tipoDocumento.SelectedValue, sexo.SelectedValue, fechaNacimiento.Value.ToString("yyyyMMdd"));
                System.Diagnostics.Debug.WriteLine(query);
                con.executeQuery(query);
                /*********************** INSERTAMOS EN LA TABLA MEDICO ******************/
                pattern = "INSERT INTO BUGDEVELOPING.MEDICO (ME_PERSONA, ME_MATRICULA, ME_ACTIVO) VALUES ((SELECT TOP 1 PE_ID FROM BUGDEVELOPING.PERSONA ORDER BY PE_ID DESC),{0}, 1)";
                query = String.Format(pattern, matricula.Text.Trim());
                System.Diagnostics.Debug.WriteLine(query);
                con.executeQuery(query);
                
                /**************************************************************/
                String idMessage = "SELECT MAX(ME_PERSONA) FROM BUGDEVELOPING.MEDICO";
                DataTable dt = con.executeQuery(idMessage);
                MessageBox.Show("El Profesional que se generará tendrá el número: " + dt.Rows[0].ItemArray[0].ToString());
                /**************************************************************/
            }

            if (especialidades != null)
            {
                if (selected != null)
                {
                    System.Diagnostics.Debug.WriteLine("ACA DEBERIA ENTRAR!!");
                    pattern = "DELETE FROM BUGDEVELOPING.ESPECIALIDAD_MEDICO WHERE EM_MEDICO = {0}";
                    query = String.Format(pattern, selected.Cells["ID_PROFESIONAL"].Value.ToString());
                    System.Diagnostics.Debug.WriteLine(query);
                    con.executeQuery(query);
                }

                pattern = "SELECT ME_PERSONA FROM BUGDEVELOPING.MEDICO JOIN BUGDEVELOPING.PERSONA ON (PE_ID = ME_PERSONA) WHERE PE_TIPO_DOC = {0} AND PE_NUM_DOC = {1}";
                query = String.Format(pattern, tipoDocumento.SelectedValue, documento.Text);
                System.Diagnostics.Debug.WriteLine(query);
                Decimal id = (Decimal)con.executeQueryEscalar(query);

                pattern = "INSERT INTO BUGDEVELOPING.ESPECIALIDAD_MEDICO (EM_MEDICO, EM_ESPECIALIDAD) VALUES ({0},{1});";
                System.Console.WriteLine("la cantidad de elementos es{0}", especialidades.Items.Count.ToString());
                //  System.Diagnostics.Debug.WriteLine("la cantidad de elementos es{0}",especialidades.Items.Count.ToString());
                foreach (KeyValuePair<Decimal, String> especialidad in especialidades.Items)
                {
                    query = String.Format(pattern, id, especialidad.Key);
                    System.Diagnostics.Debug.WriteLine(query);
                    con.executeQuery(query);
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void editarEspecialidades_Click(object sender, EventArgs e)
        {
            ProfesionalEspecialidades window;
            if (selected != null)
            {
                window = new ProfesionalEspecialidades(selected);
            }
            else
            {
                window = new ProfesionalEspecialidades();
            }

            DialogResult resultModificacion = window.ShowDialog();
            if (resultModificacion == DialogResult.OK)
            {
                especialidades = window.especialidadesSeleccionadas;
            }
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
