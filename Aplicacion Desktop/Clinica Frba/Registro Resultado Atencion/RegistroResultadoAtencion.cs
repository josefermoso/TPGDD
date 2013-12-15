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
            dateTimePickerHoraFin.Enabled = false;
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
                    String resultadOp = FuncionesRegistroResultado.actualizarConsulta("'" + dateTimePickerFECHA.Value.Date.ToString("yyyyMMdd") + "'", "'" + dateTimePickerHoraFin.Text + "'", textBoxDIAGNOSTICO.Text.Trim(), textBoxSINTOMAS.Text.Trim(), consultaId);
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
                    else if (resultadOp == "1")
                    {
                        MessageBox.Show("La fecha que ha ingresado difiere de la fecha de arribo a la Clínica");
                    }
                    else if (resultadOp == "2")
                    {
                        MessageBox.Show("El horario de finalizacion ingresado es menor al horario de comienzo del turno");
                    }
 
                    else if (resultadOp == "3")
                    {
                        MessageBox.Show("Los horarios de inicio del turno y fin de la consulta no pueden ser iguales");
                    }
 
                    else if (resultadOp == "5")
                    {
                        MessageBox.Show("El horario de finalizacion del turno excede los 30 minutos del turno");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxATENDIDO.Checked == true)
            {

                dateTimePickerFECHA.Enabled = true;
                dateTimePickerHoraFin.Enabled = true;
                checkBoxRECETA.Enabled = true;
                textBoxDIAGNOSTICO.Enabled = true;
                textBoxSINTOMAS.Enabled = true;
            }
            else
            {

                dateTimePickerFECHA.Enabled = false;
                dateTimePickerHoraFin.Enabled = false;
                checkBoxRECETA.Enabled = false;
                textBoxDIAGNOSTICO.Enabled = false;
                textBoxSINTOMAS.Enabled = false;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDIAGNOSTICO_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroResultadoAtencion_Load(object sender, EventArgs e)
        {

        }

        private void maskedSINTOMAS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


    }
}
