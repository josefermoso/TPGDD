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

        public ConfigurarListado(String numeroListado)
        {
            InitializeComponent();

            numList = numeroListado;

            comboBoxOCULTAR.Enabled = false;
            comboBoxOCULTAR2.Enabled = false;

            comboBoxMESsegundo1.Visible = false;
            comboBoxMESsegundo2.Visible = false;
            comboBoxMESprimero1.Visible = false;
            comboBoxMESprimero2.Visible = false;
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

                comboBoxMESprimero2.Visible = false;
                comboBoxMESsegundo2.Visible = false;

                comboBoxOCULTAR.Visible = false;
                comboBoxOCULTAR2.Visible = false;

                comboBoxMESprimero1.Visible = true;
                comboBoxMESsegundo1.Visible = true;
            }
            else if (semestre.Equals("SEGUNDO SEMESTRE"))
            {

                comboBoxMESprimero1.Visible = false;
                comboBoxMESsegundo1.Visible = false;

                comboBoxOCULTAR.Visible = false;
                comboBoxOCULTAR2.Visible = false;

                comboBoxMESprimero2.Visible = true;
                comboBoxMESsegundo2.Visible = true;
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
                Int16 ok1 = 1;
                if (comboBoxMESprimero1.Text.Equals(""))
                {
                    MessageBox.Show("Seleccione el mes");
                    ok1 = 0;
                }
                else if (comboBoxMESsegundo1.Text.Equals(""))
                {
                    MessageBox.Show("Seleccione el mes");
                    ok1 = 0;
                }
                else if (Convert.ToInt16(comboBoxMESprimero1.Text) > Convert.ToInt16(comboBoxMESsegundo1.Text))
                {
                    MessageBox.Show("La selección de meses es incorrecta");
                    ok1 = 0;
                }

                if (ok1 == 1)
                {
                    Listados_Estadisticos.ResultadoListado conf = new Listados_Estadisticos.ResultadoListado(numList, maskedTextBoxAÑO.Text, comboBoxMESprimero1.Text, comboBoxMESsegundo1.Text);
                    conf.Show();
                }

            }
            else if (comboBoxSEMESTRE.Text.Equals("SEGUNDO SEMESTRE"))
            {
                Int16 ok2 = 1;
                if (comboBoxMESprimero2.Text.Equals(""))
                {
                    MessageBox.Show("Seleccione el mes");
                    ok2 = 0;
                }
                else if (comboBoxMESsegundo2.Text.Equals(""))
                {
                    MessageBox.Show("Seleccione el mes");
                    ok2 = 0;
                }
                else if (Convert.ToInt16(comboBoxMESprimero2.Text) > Convert.ToInt16(comboBoxMESsegundo2.Text))
                {
                    MessageBox.Show("La selección de meses es incorrecta");
                    ok2 = 0;
                }

                if (ok2 == 1)
                {
                    Listados_Estadisticos.ResultadoListado conf = new Listados_Estadisticos.ResultadoListado(numList, maskedTextBoxAÑO.Text, comboBoxMESprimero2.Text, comboBoxMESsegundo2.Text);
                    conf.Show();
                }
            }
        }
    }
}
