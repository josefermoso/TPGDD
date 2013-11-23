using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Profesional
{
    class FuncionesProfesional
    {
        public static DataTable obtenerEspecialidadesMedicas()
        {
            DataTable Dt;
            String query = "SELECT ES_ID, ES_DESCRIPCION FROM BUGDEVELOPING.ESPECIALIDAD";
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt;
        }

        public static void registrarPersona(string nombre, string apellido, string direccion, string telefono, string mail, string sexo, string fechaNacimiento, string tipoDoc, string nroDoc) 
        {
            if (direccion == "")
                direccion = "''";
            if (telefono == "")
                telefono = "''";
            if (mail == "")
                mail = "''";

            String query = "EXECUTE BUGDEVELOPING.INSERTAR_PERSONA " + nombre + ", " + apellido + ", " + direccion + ", " + telefono + ", " + mail + ", " + sexo + ", '" + fechaNacimiento + "', " + tipoDoc + ", " + nroDoc;
            ConnectorClass conexion = ConnectorClass.Instance;
            conexion.executeQuery(query);
        }

        public static DataTable obtenerProfesional(String pk_medico)
        {
            DataTable profesional;
            string seleccion = "SELECT pe_nombre, pe_apellido, pe_sexo, pe_fecha_nac, me_matricula, pe_tipo_doc, pe_num_doc, pe_direccion, pe_telefono, pe_mail";
            string origen = " FROM BUGDEVELOPING.MEDICO JOIN BUGDEVELOPING.PERSONA ON (PE_ID = ME_PERSONA)";
            string condicion = " WHERE ME_PERSONA ='" + pk_medico + "'";
            ConnectorClass conexion = ConnectorClass.Instance;
            profesional = conexion.executeQuery(seleccion + origen + condicion);
            return profesional;
        }

        public static void updatePersonaYProfesional(string nombre, string apellido, string direccion, string telefono, string mail, string sexo, string fechaNacimiento, string tipoDoc, string nroDoc, string matricula, string pk_medico)
        {
            string query = "UPDATE BUGDEVELOPING.PERSONA SET PE_NOMBRE = '" + nombre + "', PE_APELLIDO = '" + apellido + "', PE_DIRECCION = '" + direccion + "', PE_TELEFONO = '" + telefono + "', PE_MAIL = '" + mail + "', PE_SEXO = '" + sexo + "', PE_FECHA_NAC = CAST('" + fechaNacimiento + "' AS DATE), PE_TIPO_DOC = '" + tipoDoc + "', PE_NUM_DOC = '" + nroDoc + "' WHERE PE_ID = '" + pk_medico + "'";
            ConnectorClass cc = ConnectorClass.Instance;
            cc.executeQuery(query);

            query = "UPDATE BUGDEVELOPING.MEDICO SET ME_MATRICULA = '" + matricula + "' WHERE ME_PERSONA = '" + pk_medico + "'";
            cc.executeQuery(query);
        }

        public static DataTable obtenerEspecialidadesDe(string pk_medico)
        {
            DataTable Dt;
            String query = "SELECT ES_DESCRIPCION FROM BUGDEVELOPING.ESPECIALIDAD_MEDICO JOIN BUGDEVELOPING.ESPECIALIDAD ON (EM_ESPECIALIDAD = ES_ID) WHERE EM_MEDICO = '" + pk_medico + "'";
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt;
        }
    }
}
