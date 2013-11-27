using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.pedido_turno
{
    public partial class buscarProfesional : Form
    {
        public String idPaciente;
        public String quienEs;

        public buscarProfesional()
        {
            InitializeComponent();
        }

        public void buscarProfesional_Load(object sender, EventArgs e)
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

        private void especialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void buscar_Click(object sender, EventArgs e)
        {
            String query = "select P.PE_APELLIDO, P.PE_NOMBRE, E.ES_DESCRIPCION, M.ME_PERSONA from BUGDEVELOPING.ESPECIALIDAD_MEDICO as EM inner join BUGDEVELOPING.ESPECIALIDAD  as E on (E.ES_ID = EM.EM_ESPECIALIDAD) inner join BUGDEVELOPING.MEDICO as M on (M.ME_PERSONA = EM.EM_MEDICO) inner join BUGDEVELOPING.PERSONA as P on (M.ME_PERSONA = PE_ID) WHERE M.ME_ACTIVO = 1 ";

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
                    query = query + " AND P.PE_NOMBRE LIKE '%" + nombreProfesional.Text + "%'";

                }
            }


            if (especialidades.SelectedValue != null)
            {
                query = query + "AND E.ES_ID = " + especialidades.SelectedValue;

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
                    query = query + " AND P.PE_APELLIDO LIKE '%" + apellidoProfesional.Text + "%'";

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
        public Boolean tieneAgenda()
        {
            ConnectorClass con = ConnectorClass.Instance;
            Boolean rta;

            string id = grillaProfesional.CurrentRow.Cells[4].Value.ToString();
            DataTable nroIdAgenda = con.executeQuery("select * from BUGDEVELOPING.AGENDA_PERSONAL as A where A.AG_MEDICO = " + id);

            if (nroIdAgenda.Rows.Count == 0) { rta = false; } else { rta = true; }

            return rta;
        }

        //cuando hago click en seleccionar pasa esto:
        private void grillaProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((grillaProfesional.Rows.Count > 0) && (grillaProfesional.Columns[e.ColumnIndex].HeaderText == "Seleccionar"))
            {
                if (tieneAgenda())
                {
                    Clinica_Frba.Pedir_Turno.ProfesionalSeleccionado menuProfesional = new Clinica_Frba.Pedir_Turno.ProfesionalSeleccionado();
                    menuProfesional.idProfesional = grillaProfesional.CurrentRow.Cells[4].Value.ToString();
                    menuProfesional.idPaciente2 = idPaciente;
                    menuProfesional.quienEs2 = quienEs;
                    menuProfesional.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El profesional seleccionado no tiene agenda");
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

    }
}
