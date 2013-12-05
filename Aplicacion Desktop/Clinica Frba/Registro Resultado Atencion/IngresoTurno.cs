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
    public partial class IngresoTurno : Form
    {
        public IngresoTurno()
        {
            InitializeComponent();
        }

        private void buttonINGRESAR_Click(object sender, EventArgs e)
        {
            if (textBoxNUMEROTURNO.Text == "") {
                MessageBox.Show("Debe ingresar el número de turno para continuar");

            }else{

                try
                {
                    Convert.ToInt32(textBoxNUMEROTURNO.Text);
                    if (FuncionesRegistroResultado.turnoValido(textBoxNUMEROTURNO.Text) == "0")
                    {
                        MessageBox.Show("Turno no encontrado");
                    }
                    else
                    {

                        if (textBoxPROF.Text == "")
                        {
                            MessageBox.Show("Debe ingresar un número de Profesional");
                        }
                        else
                        {

                            if (FuncionesRegistroResultado.medicoValido(textBoxNUMEROTURNO.Text, textBoxPROF.Text) == "0")
                            {
                                MessageBox.Show("Profesional no encontrado para este turno");
                            }
                            else
                            {
                                String nroCon = FuncionesRegistroResultado.getConsulta(textBoxNUMEROTURNO.Text);
                                RegistroResultadoAtencion form = new RegistroResultadoAtencion(nroCon);
                                this.Hide();
                                form.Show();
                            }
                        }
                    }
                }
                catch {
                    MessageBox.Show("El número de turno ingresado no es válido");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }
    }
}
