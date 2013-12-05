using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class MenuRelativo : Form
    {
        public AfiliadoPersona titular;
        public MenuRelativo()
        {
            InitializeComponent();
        }

        public MenuRelativo(AfiliadoPersona titu)
        {
            this.titular = titu;
            InitializeComponent();
        }

        private void button_Conyugue_Click(object sender, EventArgs e)
        {
            Afiliado conyugueForm = new Afiliado(true);
            conyugueForm.titular = this.titular;
            conyugueForm.Show();
        }

        private void button_Relativo_Click(object sender, EventArgs e)
        {
            Afiliado relativoForm = new Afiliado(false);
            relativoForm.titular = this.titular;
            relativoForm.Show();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
