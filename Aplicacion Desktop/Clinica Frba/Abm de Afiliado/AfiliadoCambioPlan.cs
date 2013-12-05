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
    public partial class AfiliadoCambioPlan : Form
    {

        private AfiliadoPersona afiliado;
        public AfiliadoCambioPlan()
        {
            InitializeComponent();
        }
        public AfiliadoCambioPlan(AfiliadoPersona afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            this.afiliado.motioCambioPlan = textBox_cambioPlan.Text;
            this.Close();
        }
    }
}
