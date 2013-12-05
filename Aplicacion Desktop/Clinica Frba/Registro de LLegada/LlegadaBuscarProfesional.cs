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
            especialidades.DisplayMember = "ES_DESCRIPCION";
            especialidades.ValueMember = "ES_ID";
            especialidades.Enabled = true;

            //para que arranque sin seleccionar nada
            especialidades.SelectedItem = null;


        }

        public static DataTable AgregarEspecialidadesAlComboBox()
        {
            ConnectorClass Conexion = ConnectorClass.Instance;
            DataTable Dt;
            Dt = Conexion.executeQuery("SELECT ES_ID, ES_DESCRIPCION FROM BUGDEVELOPING.ESPECIALIDAD");
            return Dt;

        }

        private void buscar_Click(object sender, EventArgs e)
        {

            String query = "select  PE_APELLIDO, PE_NOMBRE, ES_DESCRIPCION, ME_PERSONA from BUGDEVELOPING.ESPECIALIDAD_MEDICO inner join BUGDEVELOPING.ESPECIALIDAD on (ES_ID = EM_ESPECIALIDAD) inner join BUGDEVELOPING.MEDICO on (ME_PERSONA = EM_MEDICO) inner join BUGDEVELOPING.PERSONA on (ME_PERSONA = PE_ID) WHERE ME_ACTIVO = 1 ";

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
                    query = query + " AND PE_NOMBRE LIKE '%" + nombreProfesional.Text + "%'";

                }
            }


            if (especialidades.SelectedValue != null)
            {
                query = query + "AND ES_ID = " + especialidades.SelectedValue;

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
                    query = query + " AND PE_APELLIDO LIKE '%" + apellidoProfesional.Text + "%'";

                }
            }

            ConnectorClass con = ConnectorClass.Instance;
            grillaProfesional.DataSource = con.executeQuery(query);
            grillaProfesional.Columns["ME_PERSONA"].Visible = false;
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
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
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
