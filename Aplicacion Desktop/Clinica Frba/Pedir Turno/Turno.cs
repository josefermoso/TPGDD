using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Pedir_Turno
{
    public class Turno
    {
        public int nroTurno;
        public TimeSpan inicio;
        public TimeSpan fin;
        public String nombreDia;
        public String nroIdAgenda;
        public string alpedo;

        public Turno() { }

        public Turno(int a, TimeSpan b, TimeSpan c, String d, String e)
        {
            nroTurno = a;
            inicio = b;
            fin = c;
            nroIdAgenda = d;
            alpedo = e;
        }

        public Turno(int a, TimeSpan b, TimeSpan c, String nombre)
        {
            nroTurno = a;
            inicio = b;
            fin = c;
            nombreDia = nombre;
        }
    }
}
