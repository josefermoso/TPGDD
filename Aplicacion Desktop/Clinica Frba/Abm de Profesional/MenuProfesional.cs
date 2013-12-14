using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class MenuProfesional : Form
    {
        public MenuProfesional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProfesional form = new FormProfesional();
            DialogResult resultModificacion = form.ShowDialog();
            if (resultModificacion == DialogResult.OK)
            {
                MessageBox.Show("Profesional dado de alta correctamente.", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionProfesional window = new SeleccionProfesional();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                DialogResult resultConfirm = MessageBox.Show("Esta a punto de eliminar al profesional: " + window.selected.Cells["NOMBRE"].Value.ToString() + " " + window.selected.Cells["APELLIDO"].Value.ToString() + ". Se cancelarán automaticamente todos sus turnos. ¿Desea continuar?", "Eliminar Profesional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultConfirm == DialogResult.Yes)
                {
                    String pattern = "EXECUTE BUGDEVELOPING.BAJA_PROFESIONAL {0},{1}";
                    String query = String.Format(pattern, window.selected.Cells["ID_PROFESIONAL"].Value.ToString(), ConfigurationManager.AppSettings["fechaSistema"]);
                    ConnectorClass con = ConnectorClass.Instance;
                    System.Diagnostics.Debug.WriteLine(query);
                    con.executeQuery(query);
                    MessageBox.Show("Profesional eliminado correctamente.", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionProfesional window = new SeleccionProfesional();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                FormProfesional form = new FormProfesional(window.selected);
                DialogResult resultModificacion = form.ShowDialog();
                if (resultModificacion == DialogResult.OK)
                {
                    MessageBox.Show("Profesional modificado correctamente.", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }
    }
}
