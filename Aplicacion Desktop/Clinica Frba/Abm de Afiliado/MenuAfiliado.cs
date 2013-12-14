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
    public partial class MenuAfiliado : Form
    {
        public MenuAfiliado()
        {
            InitializeComponent();
        }

        ConnectorClass cc;
        DataTable dt;

        private void MenuAfiliado_Load(object sender, EventArgs e)
        {
            cc = ConnectorClass.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAfiliado form = new FormAfiliado(1, null);
            DialogResult resultModificacion = form.ShowDialog();
            if (resultModificacion == DialogResult.OK)
            {
                MessageBox.Show("Afiliado dado de alta correctamente.", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MenuAfiliado_Load_1(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionAfiliado window = new SeleccionAfiliado();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                FormAfiliado form = new FormAfiliado(window.selected);
                DialogResult resultModificacion = form.ShowDialog();
                if (resultModificacion == DialogResult.OK)
                {
                    MessageBox.Show("Afiliado modificado correctamente.", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionAfiliado window = new SeleccionAfiliado();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                DialogResult resultConfirm = MessageBox.Show("Esta a punto de eliminar al Afiliado: " + window.selected.Cells["NOMBRE"].Value.ToString() + " " + window.selected.Cells["APELLIDO"].Value.ToString() + ". Se cancelarán automaticamente todos sus turnos. ¿Desea continuar?", "Eliminar Afiliado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultConfirm == DialogResult.Yes)
                {
                    String pattern = "EXECUTE BUGDEVELOPING.BAJA_AFILIADO {0},{1}";
                    String query = String.Format(pattern, window.selected.Cells["NRO_AFILIADO"].Value.ToString(), ConfigurationManager.AppSettings["fechaSistema"]);
                    ConnectorClass con = ConnectorClass.Instance;
                    System.Diagnostics.Debug.WriteLine(query);
                    con.executeQuery(query);
                    MessageBox.Show("Afiliado eliminado correctamente.", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }
    }
}
