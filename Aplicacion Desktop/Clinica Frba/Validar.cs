using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba
{
    class Validar
    {
        
        /* en esta clase creamos los métodos que son útiles para validar los tipos de datos
         * ingresados en los diferentes textbox de toda la aplicacion */ 
        
        /* validar que sean solo numeros (en caso de que no se cumpla no te deja tipear) */
        public static void soloNumeros(KeyPressEventArgs pE)
        { 
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        /* validar que sean solo letras (en caso de que no se cumpla no te deja tipear) */ 
        public static void soloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
    }
}
