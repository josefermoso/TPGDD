using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class RegistroResultadoAtencion : Form
    {
        public String consultaId;

        public RegistroResultadoAtencion(String nroConsulta)
        {
            InitializeComponent();
            consultaId = nroConsulta;
            dateTimePickerFECHA.Enabled = false;
            dateTimePickerHORA.Enabled = false;
            checkBoxRECETA.Enabled = false;
            textBoxDIAGNOSTICO.Enabled = false;
            textBoxSINTOMAS.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxATENDIDO.Checked == true)
            {

                if (textBoxSINTOMAS.Text == "")
                {
                    MessageBox.Show("Debe Ingresar los síntomas detectados");
                }
                else if (textBoxDIAGNOSTICO.Text == "")
                {
                    MessageBox.Show("Debe ingresar un diagnóstico para esta atención");
                }
                else
                {
                    String resultadOp = FuncionesRegistroResultado.actualizarConsulta("'" + dateTimePickerFECHA.Text + "'", "'" + dateTimePickerHORA.Text + "'", textBoxDIAGNOSTICO.Text, textBoxSINTOMAS.Text, consultaId);
                    if (resultadOp == "0")
                    {
                        MessageBox.Show("Ha registrado el resultado de la consulta exitosamente");
                        if (checkBoxRECETA.Checked == true)
                        {
                            Generar_Receta.GenerarReceta rec = new Generar_Receta.GenerarReceta(consultaId);
                            rec.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha que ha ingresado difiere de la fecha de arribo a la Clínica");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxATENDIDO.Checked == true)
            {

                dateTimePickerFECHA.Enabled = true;
                dateTimePickerHORA.Enabled = true;
                checkBoxRECETA.Enabled = true;
                textBoxDIAGNOSTICO.Enabled = true;
                textBoxSINTOMAS.Enabled = true;
            }
            else
            {

                dateTimePickerFECHA.Enabled = false;
                dateTimePickerHORA.Enabled = false;
                checkBoxRECETA.Enabled = false;
                textBoxDIAGNOSTICO.Enabled = false;
                textBoxSINTOMAS.Enabled = false;

            }

        }
    }
}
