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
    public partial class ConfirmarCambioPlan : Form
    {

        public ConfirmarCambioPlan()
        {
            InitializeComponent();
        }

        public String motivo;

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (motivoInput.Text.Length != 0)
            {
                motivo = motivoInput.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe ingresar el motivo del cambio de plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
