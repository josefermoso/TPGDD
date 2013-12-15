using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class ListadosEstadisticos : Form
    {
        public static ListadosEstadisticos listadosActivos;

        public ListadosEstadisticos()
        {
            listadosActivos = this;
            InitializeComponent();

        }

        private void groupBoxLISTADO_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelLISTADOELECCION_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCANCELAR_Click(object sender, EventArgs e)
        {
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
            this.Close();
        }

        private void buttonLISTADO1_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Listados_Estadisticos.ConfigurarListado conf = new Clinica_Frba.Listados_Estadisticos.ConfigurarListado("1");
            conf.Show();
            this.Hide();
        }

        private void buttonLISTADO2_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Listados_Estadisticos.ConfigurarListado conf = new Clinica_Frba.Listados_Estadisticos.ConfigurarListado("2");
            conf.Show();
            this.Hide();

        }

        private void buttonLISTADO3_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Listados_Estadisticos.ConfigurarListado conf = new Clinica_Frba.Listados_Estadisticos.ConfigurarListado("3");
            conf.Show();
            this.Hide();
        }

        private void buttonLISTADO4_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Listados_Estadisticos.ConfigurarListado conf = new Clinica_Frba.Listados_Estadisticos.ConfigurarListado("4");
            conf.Show();
            this.Hide();
        }
    }
}
