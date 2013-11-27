using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Registro_de_LLegada
{
    public partial class LlegadaBuscarProfesional : Form
    {
        public LlegadaBuscarProfesional()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable DtEspecialidades;
            DtEspecialidades = AgregarEspecialidadesAlComboBox();
            especialidades.DataSource = DtEspecialidades;
            especialidades.DisplayMember = "DESCRIPCION";
            especialidades.ValueMember = "ID_ESPECIALIDAD";
            especialidades.Enabled = true;

            //para que arranque sin seleccionar nada
            especialidades.SelectedItem = null;


        }

        public static DataTable AgregarEspecialidadesAlComboBox()
        {
            ConnectorClass Conexion = ConnectorClass.Instance;
            DataTable Dt;
            Dt = Conexion.executeQuery("SELECT ID_ESPECIALIDAD,DESCRIPCION FROM HARDWELL.ESPECIALIDAD");
            return Dt;

        }

        private void buscar_Click(object sender, EventArgs e)
        {

            String query = "select p.APELLIDO , p.NOMBRE , e.DESCRIPCION,p.ID_PROFESIONAL from HARDWELL.PROFESIONAL_ESPECIALIDAD as pe inner join HARDWELL.ESPECIALIDAD  as e on (e.ID_ESPECIALIDAD=pe.ID_ESPECIALIDAD) inner join HARDWELL.PROFESIONAL as p on (p.ID_PROFESIONAL=pe.ID_PROFESIONAL) WHERE p.HABILITADO = 1 ";

            int result = 0;
            if (int.TryParse(nombreProfesional.Text, out result))
            {
                //nombreProfesional.Text = "";
                MessageBox.Show("Solo se permiten letras");
            }
            else
            {
                if (nombreProfesional.Text != "")
                {
                    query = query + " AND p.NOMBRE LIKE '%" + nombreProfesional.Text + "%'";

                }
            }


            if (especialidades.SelectedValue != null)
            {
                query = query + "AND e.ID_ESPECIALIDAD= " + especialidades.SelectedValue;

            }


            result = 0;
            if (int.TryParse(apellidoProfesional.Text, out result))
            {
                //nombreProfesional.Text = "";
                MessageBox.Show("Solo se permiten letras");
            }
            else
            {
                if (apellidoProfesional.Text != "")
                {
                    query = query + " AND p.APELLIDO LIKE '%" + apellidoProfesional.Text + "%'";

                }
            }

            ConnectorClass con = ConnectorClass.Instance;
            grillaProfesional.DataSource = con.executeQuery(query);
            grillaProfesional.Columns["ID_PROFESIONAL"].Visible = false;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            grillaProfesional.DataSource = "";
            nombreProfesional.Clear();
            apellidoProfesional.Clear();
            especialidades.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grillaProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((grillaProfesional.Rows.Count > 0) && (grillaProfesional.Columns[e.ColumnIndex].HeaderText == "Seleccionar"))
            {
                Clinica_Frba.Registro_de_LLegada.TurnosDadosProfesional menuProfesional = new Clinica_Frba.Registro_de_LLegada.TurnosDadosProfesional();
                menuProfesional.idProfesional = grillaProfesional.CurrentRow.Cells[4].Value.ToString();
                menuProfesional.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("El profesional seleccionado no tiene agenda");
            }
        }

    }
}
