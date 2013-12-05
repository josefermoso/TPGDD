using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class FiltrarRol : Form
    {
        public FiltrarRol abmFiltro;
        public FiltrarRol()
        {
            abmFiltro = this;
            InitializeComponent();
        }
        

        public void reRenderAfterMod()
        {

            String query = "SELECT ROL_ID, ROL_NOMBRE, ROL_HABILITACION  FROM BUGDEVELOPING.ROL WHERE ROL_NOMBRE LIKE " + "'%" + textboxBUSQUEDA.Text + "%'";
            if (textboxBUSQUEDA.Text == "")
            {
                query = "SELECT ROL_ID, ROL_NOMBRE, ROL_HABILITACION  FROM BUGDEVELOPING.ROL";
            }

            ConnectorClass con = ConnectorClass.Instance;
            dgvRoles.DataSource = con.executeQuery(query);
            dgvRoles.Enabled = true;
        }

        private void buttonBUSCAR_Click(object sender, EventArgs e)
        {

            String query = "SELECT ROL_ID, ROL_NOMBRE, ROL_HABILITACION  FROM BUGDEVELOPING.ROL WHERE ROL_NOMBRE LIKE " + "'%" + textboxBUSQUEDA.Text + "%'";
            if (textboxBUSQUEDA.Text == "")
            {
                query = "SELECT ROL_ID, ROL_NOMBRE, ROL_HABILITACION  FROM BUGDEVELOPING.ROL";
            }

            ConnectorClass con = ConnectorClass.Instance;
            dgvRoles.DataSource = con.executeQuery(query);
            dgvRoles.Enabled = true;
        }

        private void buttonLIMPIAR_Click(object sender, EventArgs e)
        {
            //LIMPIA LA SELECCION DE ROLES
            textboxBUSQUEDA.Text = "";
            dgvRoles.DataSource = "";
            dgvRoles.Enabled = false;
            textboxBUSQUEDA.Focus();
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvRoles.Rows.Count > 0) && (dgvRoles.Columns[e.ColumnIndex].HeaderText == "Modificar Rol"))
            {
                FormModifRol form = new FormModifRol(abmFiltro);
                FormModifRol.RolCodigo = dgvRoles.CurrentRow.Cells[1].Value.ToString();
                FormModifRol.RolNombre = dgvRoles.CurrentRow.Cells["ROL_NOMBRE"].Value.ToString();
                FormModifRol.RolActivo = dgvRoles.CurrentRow.Cells["ROL_HABILITACION"].Value.ToString();
                form.ShowDialog(this);
            }
        }

        private void buttonCREAR_Click(object sender, EventArgs e)
        {
            AltaRol alta = new AltaRol();
            alta.ShowDialog(this);
        }

        private void REGRESAR_PRINCIPAL_Click(object sender, EventArgs e)
        {
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
            this.Close();
        }

    }
}