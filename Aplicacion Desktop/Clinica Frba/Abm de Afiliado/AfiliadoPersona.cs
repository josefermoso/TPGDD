using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public class AfiliadoPersona
    {
        public string tipoDoc;
        public string nroDoc;
        public string nombre;
        public string apellido;
        public string direccion;
        public string telefono;
        public string mail;
        public string sexo;
        public string fechaNacimiento;
        public string estadoCivil;
        public string planMedico;
        public List<AfiliadoPersona> relativos = new List<AfiliadoPersona>();
        public bool esConyugue = false;
        public string iDDB;
        public string motioCambioPlan;
        public string nuevoPlan;

        public AfiliadoPersona()
        {

        }

        public AfiliadoPersona(string nom, string app, string numDoc, string tDoc, string dir, string tel, string email, string sex, string fechaNac, bool conyugue)
        {
            nombre = nom;
            apellido = app;
            tipoDoc = tDoc;
            nroDoc = numDoc;
            direccion = dir;
            telefono = tel;
            mail = email;
            sexo = sex;
            fechaNacimiento = fechaNac;
            esConyugue = conyugue;
        }

        public void agregarRelativo(AfiliadoPersona relativo)
        {
            this.relativos.Add(relativo);
        }
    }
}