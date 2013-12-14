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
    public partial class ProfesionalEspecialidades : Form
    {
        DataGridViewRow selected;
        public ListBox especialidadesSeleccionadas;

        public ProfesionalEspecialidades()
        {
            InitializeComponent();
            agregar.Enabled = false;
            quitar.Enabled = false;
            tiposEspecialidades.SelectedItem = null;

        }

        public ProfesionalEspecialidades(DataGridViewRow row)
        {
            selected = row;
            InitializeComponent();
            String idProfesional = selected.Cells["ID_PROFESIONAL"].Value.ToString();
            String query = "SELECT ES_ID, ES_DESCRIPCION AS ESPECIALIDAD FROM BUGDEVELOPING.ESPECIALIDAD_MEDICO JOIN BUGDEVELOPING.MEDICO ON ME_PERSONA = EM_MEDICO JOIN BUGDEVELOPING.ESPECIALIDAD ON ES_ID = EM_ESPECIALIDAD WHERE ME_PERSONA = " + idProfesional + " ORDER BY ESPECIALIDAD ASC";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable especialidades = con.executeQuery(query);
            foreach (DataRow dr in especialidades.Rows)
            {
                KeyValuePair<Decimal, String> tupla = new KeyValuePair<Decimal, String>(dr.Field<Decimal>("ES_ID"), dr.Field<string>("ESPECIALIDAD"));
                asignadas.Items.Add(tupla);
            }
            agregar.Enabled = false;
            quitar.Enabled = false;
            tiposEspecialidades.SelectedItem = null;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Object selecteditem = disponibles.SelectedItem;
            disponibles.Items.Remove(selecteditem);
            asignadas.Items.Add(selecteditem);
            agregar.Enabled = false;
        }

        private void quitar_Click(object sender, EventArgs e)
        {
            Object selecteditem = asignadas.SelectedItem;
            asignadas.Items.Remove(selecteditem);
            disponibles.Items.Add(selecteditem);
            quitar.Enabled = false;
        }

        private void ABMProfesionalEspecialidades_Load(object sender, EventArgs e)
        {
            String query = "SELECT TIPO_ES_ID, TIPO_ES_DESCRIPCION FROM BUGDEVELOPING.TIPO_ESPECIALIDAD";
            ConnectorClass con = ConnectorClass.Instance;
            tiposEspecialidades.DisplayMember = "TIPO_ES_DESCRIPCION";
            tiposEspecialidades.ValueMember = "TIPO_ES_ID";
            tiposEspecialidades.DataSource = con.executeQuery(query);

            tiposEspecialidades.SelectedItem = null;
        }

        private void filtrarEspecialidades_Click(object sender, EventArgs e)
        {
            String queryEspecialidades = "SELECT ES_ID, ES_DESCRIPCION AS ESPECIALIDAD FROM BUGDEVELOPING.ESPECIALIDAD";

            if (tiposEspecialidades.SelectedValue != null)
            {
                queryEspecialidades = queryEspecialidades + " WHERE ES_TIPO = " + tiposEspecialidades.SelectedValue.ToString() + " ORDER BY ESPECIALIDAD ASC";
            }
            ConnectorClass con = ConnectorClass.Instance;
            DataTable especialidades = con.executeQuery(queryEspecialidades);
            disponibles.Items.Clear();
            foreach (DataRow dr in especialidades.Rows)
            {
                KeyValuePair<Decimal, String> tupla = new KeyValuePair<Decimal, String>(dr.Field<Decimal>("ES_ID"), dr.Field<string>("ESPECIALIDAD"));
                disponibles.Items.Add(tupla);
            }
        }

        private void asignadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            quitar.Enabled = true;
        }

        private void disponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregar.Enabled = true;

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            especialidadesSeleccionadas = asignadas;
            System.Diagnostics.Debug.WriteLine("asignadas {0} ", asignadas.Items.Count.ToString());
            System.Diagnostics.Debug.WriteLine("seleccionadas {0} ", especialidadesSeleccionadas.Items.Count.ToString());
            DialogResult = DialogResult.OK;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asignadas.Items.Clear();
            disponibles.Items.Clear();
            tiposEspecialidades.SelectedItem = null;

        }

        private void tiposEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
