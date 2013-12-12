using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class RegistrarDia : Form
    {
        public int diaSeleccionado;
        public String diaSeleccionadoNombre;
        public String horaDesdeSeleccionada;
        public String horaHastaSeleccionada;

        public RegistrarDia()
        {
            InitializeComponent();

            //Cargo los todos los días
            String query = "SELECT DIA_ID, DIA_NOMBRE from BUGDEVELOPING.DIA WHERE DIA_ID <> 1 UNION SELECT '0', 'Seleccione' FROM BUGDEVELOPING.DIA;";
            ConnectorClass con = ConnectorClass.Instance;
            dia.ValueMember = "DIA_ID";
            dia.DisplayMember = "DIA_NOMBRE";
            dia.DataSource = con.executeQuery(query);
        }

        private void RegistrarDia_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            horaDesdeSeleccionada = (String)horaDesde.SelectedItem;
            horaHastaSeleccionada = (String)horaHasta.SelectedItem;
            if (diaSeleccionado.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un día.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (horaDesdeSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar la hora de inicio de atención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (horaHastaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar la hora de fin de atención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToDateTime(horaDesdeSeleccionada).CompareTo(Convert.ToDateTime(horaHastaSeleccionada)) >= 0)
            {
                MessageBox.Show("El horario ingresado es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dia_SelectedIndexChanged(object sender, EventArgs e)
        {
            diaSeleccionado = int.Parse(dia.SelectedValue.ToString());
            diaSeleccionadoNombre = (String)dia.Text;
            horaDesde.Items.Clear();
            horaHasta.Items.Clear();
            if (diaSeleccionado != 7)
            {
                horaDesde.Items.AddRange(new string[] { "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30" });
                horaHasta.Items.AddRange(new string[] { "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00" });
            }
            else
            {
                horaDesde.Items.AddRange(new string[] { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30" });
                horaHasta.Items.AddRange(new string[] { "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00" });
            }
        }
    }
}
