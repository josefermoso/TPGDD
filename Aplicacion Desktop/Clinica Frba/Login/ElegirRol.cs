using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Login
{
    public partial class ElegirRol : Form
    {
        public static String userID;
        public static bool activado = true;
        public static ElegirRol electorRolActivo;

        public ElegirRol(String idUser)
        {
            electorRolActivo = this;
            userID = idUser;
            InitializeComponent();
        }

        private void cargarRoles(object sender, EventArgs e)
        {
            String query = "SELECT ROL_ID 'NUMERO DE ROL' , ROL_NOMBRE FROM BUGDEVELOPING.ROL WHERE ROL_ID IN (SELECT ROL_ID FROM BUGDEVELOPING.USUARIO_ROL WHERE USUARIO_ID = " + userID + " )";
            ConnectorClass con = ConnectorClass.Instance;
            dgvRoles.DataSource = con.executeQuery(query);
            dgvRoles.Enabled = true;
            DataTable dt = con.executeQuery(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay roles cargados para este usuario");
                activado = false;
                this.Close();
            }
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvRoles.Rows.Count > 0) && (dgvRoles.Columns[e.ColumnIndex].HeaderText == "Seleccionar"))
            {
                Clinica_Frba.MenuPrincipal.userId = userID;
                Clinica_Frba.MenuPrincipal.rolQueMostrara = dgvRoles.CurrentRow.Cells[1].Value.ToString();
                Clinica_Frba.MenuPrincipal menu = new Clinica_Frba.MenuPrincipal();
                menu.Show(this);
                this.Hide();
            }
        }

        private void RolLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonOTROUSER_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Login.LoginForm.loginActivo.Show();
            this.Close();

        }
    }
}
