using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Login
{
    public partial class LoginForm : Form
    {
        public static String nombreUsuario;
        public static String userID;
        public static LoginForm loginActivo;

        public LoginForm()
        {
            InitializeComponent();
            loginActivo = this;
        }
        

        private void buttonINGRESAR_Click(object sender, EventArgs e)
        {
            nombreUsuario = textBoxUSERNAME.Text;
            String result = LogUser(textBoxUSERNAME.Text, textBoxPASSWORD.Text);
            MessageBox.Show(result);
            if (result.Equals("Ingreso Exitoso"))
            {
                ElegirRol eleccion = new ElegirRol(userID);
                this.Hide();
                eleccion.Show();
                if (ElegirRol.activado == false)
                {
                    this.Show();
                }
            }
        }

        public static String LogUser(String userName, String password)
        {
            String userId = Clinica_Frba.Login.FuncionesLogin.getUsuario(userName);

            if (userId == null)
            {
                return "Usuario invalido";
            }
            else
            {
                Boolean passwordCorrecto = Clinica_Frba.Login.FuncionesLogin.checkPassword(userId, password);
                if (!passwordCorrecto)
                {
                    String cantidad = Clinica_Frba.Login.FuncionesLogin.getCantidadDeIntentos(userId);


                    if (cantidad.Equals("1"))
                    {
                        return "El usuario ha alcanzado el maximo de entradas incorrectas. Usuario Inhabilitado";

                    }
                    else
                    {
                        Clinica_Frba.Login.FuncionesLogin.decrementarIntentos(userId);
                        cantidad = Clinica_Frba.Login.FuncionesLogin.getCantidadDeIntentos(userId);
                        return "Contraseña Erronea. Tiene " + int.Parse(cantidad) + " intentos restantes";
                    }
                }
                else
                {
                    
                    Clinica_Frba.Login.FuncionesLogin.resetearContador(userId);
                    userID = userId;
                    return "Ingreso Exitoso";

                    
                }
            }


        }
    }
}
