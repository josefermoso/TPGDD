using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using Clinica_Frba;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class SeleccionProfesionalPorEspecialidad : Form
    {
        public DataGridViewRow selected;
        public long idEspecialidad;

        public SeleccionProfesionalPorEspecialidad()
        {
            InitializeComponent();
            FuncionesCargarComboBox.cargarEspecialidades(especialidad);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (especialidad.SelectedValue.Equals(0L) && id.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe seleccionar una especialidad o ingresar el ID del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            long number;
            if (!especialidad.SelectedValue.Equals(0L))
            {
                ConnectorClass con = ConnectorClass.Instance;
                String patternProfesionales = "SELECT ME_PERSONA AS 'ID_PROFESIONAL', PE_NOMBRE NOMBRE, PE_APELLIDO APELLIDO, (SELECT TOP 1 AG_CODIGO FROM BUGDEVELOPING.AGENDA_PERSONAL WHERE AG_MEDICO = EM_MEDICO ORDER BY AG_DESDE_DIA DESC) AS AGENDA FROM BUGDEVELOPING.PERSONA JOIN BUGDEVELOPING.MEDICO ON (PE_ID = ME_PERSONA) JOIN BUGDEVELOPING.ESPECIALIDAD_MEDICO ON (EM_MEDICO = ME_PERSONA AND EM_ESPECIALIDAD = {0}) WHERE ME_ACTIVO = 1 AND EXISTS (SELECT TOP 1 AG_CODIGO FROM BUGDEVELOPING.AGENDA_PERSONAL WHERE AG_MEDICO = EM_MEDICO ORDER BY AG_DESDE_DIA DESC)";
                String queryProfesionales = String.Format(patternProfesionales, especialidad.SelectedValue);
                System.Diagnostics.Debug.WriteLine(queryProfesionales);
                profesionales.DataSource = con.executeQuery(queryProfesionales);
            }
            else if (!id.Text.Length.Equals(0) && long.TryParse(id.Text, out number))
            {
                ConnectorClass con = ConnectorClass.Instance;
                String patternProfesionales = "SELECT ME_PERSONA AS 'ID_PROFESIONAL, PE_NOMBRE NOMBRE, PE_APELLIDO APELLIDO, (SELECT TOP 1 AG_CODIGO FROM BUGDEVELOPING.AGENDA_PERSONAL WHERE AG_MEDICO = {0} ORDER BY AG_DESDE_DIA DESC) AS AGENDA FROM BUGDEVELOPING.PERSONA JOIN FROM BUGDEVELOPING.MEDICO ON (PE_ID = ME_PERSONA) WHERE ME_ACTIVO = 1 AND ME_PERSONA = {0} AND EXISTS (SELECT TOP 1 AG_CODIGO FROM BUGDEVELOPING.AGENDA_PERSONAL WHERE ME_PERSONA = {0} ORDER BY AG_DESDE_DIA DESC)";
                String queryProfesionales = String.Format(patternProfesionales, number);
                System.Diagnostics.Debug.WriteLine(queryProfesionales);
                profesionales.DataSource = con.executeQuery(queryProfesionales);
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (!profesionales.SelectedRows.Count.Equals(1))
            {
                MessageBox.Show("No seleccionó ningún profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            selected = profesionales.SelectedRows[0];
            idEspecialidad = long.Parse(especialidad.SelectedValue.ToString());
            DialogResult = DialogResult.OK;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
