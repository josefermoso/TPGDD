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
    public partial class ConfigurarListado : Form
    {
        private String numList;
        private String semestre;

        public ConfigurarListado(String numeroListado)
        {
            InitializeComponent();

            numList = numeroListado;


        }

        private void maskedTextBoxAÑO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonVOLVER_Click(object sender, EventArgs e)
        {
            Listados_Estadisticos.ListadosEstadisticos.listadosActivos.Show();
            this.Close();
        }

        private void comboBoxMESsegundo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSEMESTRE_SelectedIndexChanged(object sender, EventArgs e)
        {
            String semestre = comboBoxSEMESTRE.Text;

            if (semestre.Equals("PRIMER SEMESTRE"))
            {

                semestre = "1";
            }
            else if (semestre.Equals("SEGUNDO SEMESTRE"))
            {

                semestre = "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String year = maskedTextBoxAÑO.Text;

            if (year.Equals(""))
            {
                MessageBox.Show("Ingrese el año");
            }
            else if (!(year.Length == 4) || (Convert.ToInt16(year) < 1990))
            {
                MessageBox.Show("Ingrese un año correcto");
            }

            else if (comboBoxSEMESTRE.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un semestre");
            }

            else if (comboBoxSEMESTRE.Text.Equals("PRIMER SEMESTRE"))
            {
                semestre = "1";
                Listados_Estadisticos.ResultadoListado conf = new Listados_Estadisticos.ResultadoListado(numList, maskedTextBoxAÑO.Text, semestre);
                try
                {
                    conf.Show();
                }
                catch { }

            }
            else if (comboBoxSEMESTRE.Text.Equals("SEGUNDO SEMESTRE"))
            {
                semestre = "2";
                Listados_Estadisticos.ResultadoListado conf = new Listados_Estadisticos.ResultadoListado(numList, maskedTextBoxAÑO.Text, semestre);
                try
                {
                    conf.Show();
                }
                catch { }

            }
        }
    }
}
