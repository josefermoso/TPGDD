using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using Clinica_Frba.Cancelar_Atencion;

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class CancelacionAdmSist : Form
    {
        public static int nroAfilOProf = 0;

        public CancelacionAdmSist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNroAoP.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el numero de Afiliado o Profesional segun desee");
            }
            else
            {
                int result = 0;
                if (!int.TryParse(textBoxNroAoP.Text, out result))
                {
                    textBoxNroAoP.Text = "";
                    MessageBox.Show("Solo se permiten numeros");
                }
                else
                {
                    String validacion = "select me_activo from bugdeveloping.medico  where me_persona = " + textBoxNroAoP.Text;
                    ConnectorClass con = ConnectorClass.Instance;
                    DataTable validar = new DataTable();
                    validar = con.executeQuery(validacion);

                    if (validar.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe  el profesional nro: " + textBoxNroAoP.Text);
                    }
                    else
                    {
                        if (Convert.ToInt32(validar.Rows[0][0]) == 1)
                        {
                            nroAfilOProf = Convert.ToInt32(textBoxNroAoP.Text);
                            Cancelar_Atencion.CancelacionProf frmProf = new CancelacionProf();
                            this.Close();
                            frmProf.Show();
                        }
                        else
                        {
                            MessageBox.Show("El profesional " + textBoxNroAoP.Text + " no esta habilitado");
                        }
                    }
                }
            }

        }

        private void buttonAfiliado_Click(object sender, EventArgs e)
        {
            if (textBoxNroAoP.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el numero de Afiliado o Profesional segun desee");
            }
            else
            {
                int result = 0;
                if (!int.TryParse(textBoxNroAoP.Text, out result))
                {
                    textBoxNroAoP.Text = "";
                    MessageBox.Show("Solo se permiten numeros");
                }
                else
                {
                    String validacion = "select pa_activo from bugdeveloping.paciente where pa_nafiliado = " + textBoxNroAoP.Text;
                    ConnectorClass con = ConnectorClass.Instance;
                    DataTable validar = new DataTable();
                    validar = con.executeQuery(validacion);

                    if (validar.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe el afiliado nro: " + textBoxNroAoP.Text);
                    }
                    else
                    {
                        if (Convert.ToInt32(validar.Rows[0][0]) == 1)
                        {
                            nroAfilOProf = Convert.ToInt32(textBoxNroAoP.Text);
                            Cancelar_Atencion.CancelacionAfiliado frmAfil = new CancelacionAfiliado();
                            this.Close();
                            frmAfil.Show();
                        }
                        else
                        {
                            MessageBox.Show("El afiliado " + textBoxNroAoP.Text + " no esta habilitado");
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }
    }
}
