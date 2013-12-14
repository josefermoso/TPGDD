using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.ConnectorSQL;
using System.Data;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    class FuncionesRegistroResultado
    {
        public static String resultadoYaCargado(String nroCon)
        {
            String query = "select count(*) from BUGDEVELOPING.CONSULTA where CON_NUMERO = '" + nroCon + "' AND CON_ENF IS NOT NULL ";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery(query);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0].ItemArray[0].ToString();

            }
            else
            {
                return null;
            }
        }
        
        public static String turnoValido(String idTurno)
        {
            String query = "select count(*) from BUGDEVELOPING.CONSULTA where (CON_TURNO = '" + idTurno + "')";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery(query);
            if (dt.Rows[0].ItemArray[0].ToString() == "0")
            {
                return dt.Rows[0].ItemArray[0].ToString();

            }
            else
            {
                return null;
            }
        }

        public static String getConsulta(String idTurno)
        {
            String query = "select CON_NUMERO from BUGDEVELOPING.CONSULTA where CON_TURNO = '" + idTurno + "'";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery(query);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0].ItemArray[0].ToString();

            }
            else
            {
                return null;
            }
        }


        public static String actualizarConsulta(String fechaAt, String horaAt, String diagnostico, String sintomas, String nroCon)
        {
            String query = "execute BUGDEVELOPING.ACTUALIZAR_CONSULTA " + fechaAt + ", " + horaAt + ", " + diagnostico + ", " + sintomas + ", " + nroCon + " ";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery(query);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0].ItemArray[0].ToString();

            }
            else
            {
                return null;
            }
        }


        public static String medicoValido(String idTurno, String idProf)
        {
            String query = "select count(*) from BUGDEVELOPING.TURNO  where T_ID = " + idTurno + " AND " + "T_MEDICO = " + idProf + "";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery(query);
            if (dt.Rows[0].ItemArray[0].ToString() == "0")
            {
                return dt.Rows[0].ItemArray[0].ToString();

            }
            else
            {
                return null;
            }
        }
    }
}
