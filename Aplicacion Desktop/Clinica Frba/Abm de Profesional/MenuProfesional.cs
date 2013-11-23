using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class MenuProfesional : Form
    {
        public MenuProfesional()
               :base()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new AltaProfesional()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new BajaProfesional()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new ListadoProfesionalEdicion()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
