using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using System.Configuration;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class FormAfiliado : Form
    {
        DataGridViewRow selected;
        int tipoAfiliado;
        FormAfiliado conyugue;
        List<FormAfiliado> otrosFamiliares;


        public FormAfiliado(int tipoAfiliadoADarDeAlta, FormAfiliado titular)
        {
            InitializeComponent();
            //maskedNombre.AsciiOnly = true;
            tipoAfiliado = tipoAfiliadoADarDeAlta;
            FuncionesCargarComboBox.cargarSexos(sexo);
            FuncionesCargarComboBox.cargarTipoDocumentos(tipoDocumento);
            FuncionesCargarComboBox.cargarPlanesMedicos(planMedico);
            FuncionesCargarComboBox.cargarEstadosCiviles(estadoCivil);

            if (tipoAfiliado != 1)
            {
                if (tipoAfiliado == 2)
                {
                    Text = "Formulario de carga de Conyugue";
                    estadoCivil.Enabled = false;
                    estadoCivil.SelectedValue = titular.estadoCivil.SelectedValue;
                    agregarConyugue.Visible = false;
                }
                else
                {
                    Text = "Formulario de carga de Familiar a cargo";
                }
                agregarConyugue.Visible = false;
                agregarFamiliares.Visible = false;
                planMedico.Enabled = false;
            }
            else
            {
                Text = "Formulario de carga de Afiliado";
                otrosFamiliares = new List<FormAfiliado>();
            }
        }

        public FormAfiliado(DataGridViewRow tomodify)
        {
            InitializeComponent();
            selected = tomodify;

            FuncionesCargarComboBox.cargarSexos(sexo);
            FuncionesCargarComboBox.cargarTipoDocumentos(tipoDocumento);
            FuncionesCargarComboBox.cargarPlanesMedicos(planMedico);
            FuncionesCargarComboBox.cargarEstadosCiviles(estadoCivil);

            Text = "Formulario de modificación de Afiliado";

            maskedNombre.Text = selected.Cells["NOMBRE"].Value.ToString();
            maskedApellido.Text = selected.Cells["APELLIDO"].Value.ToString();
            documento.Text = selected.Cells["DOCUMENTO"].Value.ToString();
            maskedDireccion.Text = selected.Cells["DIRECCION"].Value.ToString();
            maskedTelefono.Text = selected.Cells["TELEFONO"].Value.ToString();
            mail.Text = selected.Cells["MAIL"].Value.ToString();
            sexo.SelectedValue = (selected.Cells["ID_SEXO"].Value) is DBNull ? 0 : selected.Cells["ID_SEXO"].Value;
            tipoDocumento.SelectedValue = (selected.Cells["ID_TIPO_DOCUMENTO"].Value is DBNull) ? 0 : selected.Cells["ID_TIPO_DOCUMENTO"].Value;
            fechaNacimiento.Value = (DateTime)selected.Cells["FECHA_NACIMIENTO"].Value;
            estadoCivil.SelectedValue = (selected.Cells["ID_ESTADO_CIVIL"].Value) is DBNull ? 0 : selected.Cells["ID_ESTADO_CIVIL"].Value;
            planMedico.SelectedValue = (selected.Cells["ID_PLAN_MEDICO"].Value is DBNull) ? 0 : selected.Cells["ID_PLAN_MEDICO"].Value;


            maskedNombre.Enabled = false;
            maskedApellido.Enabled = false;
            tipoDocumento.Enabled = false;
            documento.Enabled = false;
            fechaNacimiento.Enabled = false;
            agregarConyugue.Enabled = false;
            agregarFamiliares.Enabled = false;
        }

        public Boolean validaciones()
        {

            long number;
            // if (nombre.Text.Length.Equals(0))
            if (maskedNombre.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el nombre del afiliado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (maskedApellido.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el apellido del afiliado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (documento.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el documento del afiliado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!long.TryParse(documento.Text, out number))
            {
                MessageBox.Show("El documento no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (tipoDocumento.SelectedValue.Equals(0))
            {
                MessageBox.Show("Debe seleccionar el tipo de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (sexo.SelectedValue.Equals(0))
            {
                MessageBox.Show("Debe seleccionar el sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (estadoCivil.SelectedValue.Equals(0))
            {
                MessageBox.Show("Debe seleccionar el Estado civil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (planMedico.SelectedValue.Equals(0L) && tipoAfiliado == 1)
            {
                MessageBox.Show("Debe seleccionar el Plan Médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void modificarAfiliado()
        {
            String pattern;
            String query;
            ConnectorClass con = ConnectorClass.Instance;

            System.Diagnostics.Debug.WriteLine("Se modificará el afiliado..");

            pattern = "UPDATE BUGDEVELOPING.PERSONA SET PE_NOMBRE = '{0}', PE_APELLIDO = '{1}', PE_NUM_DOC = {2}, PE_DIRECCION = '{3}', PE_TELEFONO = '{4}', PE_MAIL = '{5}', PE_TIPO_DOC = {6}, PE_SEXO = {7}, PE_FECHA_NAC = '{8}' WHERE PE_ID = {9}";
            query = String.Format(pattern, maskedNombre.Text.Trim(), maskedApellido.Text.Trim(), documento.Text, maskedDireccion.Text.Trim(), maskedTelefono.Text.Trim(), mail.Text, tipoDocumento.SelectedValue, sexo.SelectedValue, fechaNacimiento.Value.Date.ToString("yyyy-dd-MM"), selected.Cells["PE_ID"].Value.ToString());
            System.Diagnostics.Debug.WriteLine(query);
            con.executeQuery(query);

            pattern = "UPDATE BUGDEVELOPING.PACIENTE SET PA_ESTADO_CIVIL = {0} WHERE PA_NAFILIADO = {1}";
            query = String.Format(pattern, estadoCivil.SelectedValue, selected.Cells["NRO_AFILIADO"].Value.ToString());
            System.Diagnostics.Debug.WriteLine(query);
            con.executeQuery(query);

            if (!selected.Cells["ID_PLAN_MEDICO"].Value.Equals(planMedico.SelectedValue))
            {
                ConfirmarCambioPlan window = new ConfirmarCambioPlan();
                DialogResult resultSeleccion = window.ShowDialog();
                if (resultSeleccion == DialogResult.OK)
                {
                    pattern = "EXECUTE BUGDEVELOPING.CAMBIO_PLAN_MEDICO_PACIENTE {0},{1},{2},'{3}'";
                    query = String.Format(pattern, planMedico.SelectedValue, selected.Cells["NRO_AFILIADO"].Value.ToString(), ConfigurationManager.AppSettings["fechaSistema"], window.motivo);
                    System.Diagnostics.Debug.WriteLine(query);
                    con.executeQuery(query);
                }
            }
        }

        private void persistirAfiliado(FormAfiliado afiliado, long nroAfiliado)
        {
            System.Diagnostics.Debug.WriteLine("Se creará el afiliado: " + nroAfiliado);
            String pattern = "INSERT INTO BUGDEVELOPING.PACIENTE (NRO_AFILIADO,NOMBRE, APELLIDO, DOCUMENTO, DIRECCION, TELEFONO, MAIL, ID_TIPO_DOCUMENTO, ID_SEXO, ID_PLAN_MEDICO, FECHA_NACIMIENTO, ID_ESTADO_CIVIL) VALUES ('{0}','{1}','{2}',{3},'{4}','{5}','{6}',{7},{8},{9},'{10}',{11})";
            String query = String.Format(pattern, nroAfiliado, afiliado.maskedNombre.Text.Trim(), afiliado.maskedApellido.Text.Trim(), afiliado.documento.Text, afiliado.maskedDireccion.Text.Trim(), afiliado.maskedTelefono.Text.Trim(), afiliado.mail.Text, afiliado.tipoDocumento.SelectedValue, afiliado.sexo.SelectedValue, afiliado.planMedico.SelectedValue, afiliado.fechaNacimiento.Value.ToString("yyyy-dd-MM"), afiliado.estadoCivil.SelectedValue);
            System.Diagnostics.Debug.WriteLine(query);
            ConnectorClass.Instance.executeQuery(query);
            /**************************************************************/
            String idMessage = "SELECT MAX(NRO_AFILIADO) FROM HARDWELL.AFILIADO";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery(idMessage);
            MessageBox.Show("El Afiliado que se generará tendrá el número: " + dt.Rows[0].ItemArray[0].ToString());
            /**************************************************************/
        }

        private void persistirAfiliados()
        {
            long nroAfiliado = (long)ConnectorClass.Instance.executeQueryEscalar("SELECT HARDWELL.PROXIMO_NRO_AFILIADO();");
            persistirAfiliado(this, nroAfiliado);
            nroAfiliado++;
            if (conyugue != null)
            {
                conyugue.planMedico.SelectedValue = planMedico.SelectedValue;
                persistirAfiliado(conyugue, nroAfiliado);
            }
            foreach (FormAfiliado afiliado in otrosFamiliares)
            {
                nroAfiliado++;
                afiliado.planMedico.SelectedValue = planMedico.SelectedValue;
                persistirAfiliado(afiliado, nroAfiliado);
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                if (selected != null)
                {
                    modificarAfiliado();
                }
                else if (tipoAfiliado == 1)
                {
                    persistirAfiliados();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void estadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selected != null)
            {
                agregarConyugue.Visible = false;
            }
            else
            {
                if (estadoCivil.SelectedValue.ToString() == "4" || estadoCivil.SelectedValue.ToString() == "2")
                {
                    agregarConyugue.Enabled = true;
                }
                else
                {
                    agregarConyugue.Enabled = false;
                }
            }
        }

        private void agregarConyugue_Click(object sender, EventArgs e)
        {
            FormAfiliado form = new FormAfiliado(2, this);
            DialogResult resultModificacion = form.ShowDialog();


            if (resultModificacion == DialogResult.OK)
            {
                System.Diagnostics.Debug.WriteLine("Se cargó un canyugue..");
                conyugue = form;
                agregarConyugue.Enabled = false;
                estadoCivil.Enabled = false;
            }
        }

        private void agregarFamiliares_Click(object sender, EventArgs e)
        {
            FormAfiliado form = new FormAfiliado(3, this);
            DialogResult resultModificacion = form.ShowDialog();
            if (resultModificacion == DialogResult.OK)
            {
                otrosFamiliares.Add(form);
                System.Diagnostics.Debug.WriteLine("Se cargó un familiar. Familiares: " + otrosFamiliares.Count);
            }
        }

        private void FormAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
