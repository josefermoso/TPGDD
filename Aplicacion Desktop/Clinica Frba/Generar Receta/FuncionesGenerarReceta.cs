using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.ConnectorSQL;
using System.Data;

namespace Clinica_Frba.Generar_Receta
{
    class FuncionesGenerarReceta
    {


        public static void insertarReceta_Droga(String idReceta, String idMedicamento, String cantidad, String aclaracion)
        {

            ConnectorClass con = ConnectorClass.Instance;
            String query = "INSERT INTO BUGDEVELOPING.MEDICAMENTOS_X_RECETA (MXR_RECETA, MXR_MEDICAMENTO, MXR_CANTIDAD, MXR_CANTIDAD_ACLARACION) VALUES (" + idReceta + "," + idMedicamento + ", " + cantidad + ", '" + aclaracion + "' )";
            con.executeQuery(query);
        }

        public static void borrarRecetaRecienGenerada(String idBonoFar)
        {

            ConnectorClass con = ConnectorClass.Instance;
            String query = "delete from BUGDEVELOPING.RECETA_MEDICA where (RM_BONO = '" + idBonoFar + "')";
            con.executeQuery(query);
        }

        public static String getRecetaGenerada(String idBonoFar)
        {
            String query = "select RM_ID from BUGDEVELOPING.RECETA_MEDICA where (RM_BONO = '" + idBonoFar + "')";
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

        public static String crearRecetaYValidar(String idBonoFar, String nroCon, String fechaSis)
        {
            String query = "execute BUGDEVELOPING.CONFECCIONAR_RECETA_MEDICA " + nroCon + ", " + idBonoFar + ", " + fechaSis + " ";
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


    }
}
