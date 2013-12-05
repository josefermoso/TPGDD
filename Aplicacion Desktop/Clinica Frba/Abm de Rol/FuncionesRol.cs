using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.ConnectorSQL;
using System.Data;

namespace Clinica_Frba.Abm_de_Rol
{
    class FuncionesRol
    {
        
        public static bool existeFunEnRol(String rolId, String codFun)
        {
            String query = "select * from BUGDEVELOPING.FUNROL where ROL_ID = " + rolId + " AND FUNCIONALIDAD_ID = " + codFun + "";
            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery(query);
            if (dt.Rows.Count != 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        public static bool existeNombreRol(String nombreRol)
        {
            String query = "select * from BUGDEVELOPING.ROL where ( ROL_NOMBRE = '" + nombreRol + "' )";
            ConnectorClass conexion = ConnectorClass.Instance;
            DataTable dt = conexion.executeQuery(query);
            if (dt.Rows.Count != 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        public static void borrarRolXUsuario(String codRol)
        {
            String query = "DELETE FROM BUGDEVELOPING.USUARIO_ROL WHERE ( ROL_ID = " + codRol + ")";
            ConnectorClass conexion = ConnectorClass.Instance;
            conexion.executeQuery(query);

        }

        public static void modificarNombreYHabilitacion(String codRol, String rolNombre, String rolHabilitacion)
        {
            String query = "UPDATE BUGDEVELOPING.ROL SET ROL_NOMBRE = '" + rolNombre + "', ROL_HABILITACION = '" + rolHabilitacion + "' WHERE (ROL_ID = " + codRol + " )";
            ConnectorClass conexion = ConnectorClass.Instance;
            conexion.executeQuery(query);

        }

        public static void borrarFuncionalidades(String codRol)
        {
            String query = "DELETE FROM BUGDEVELOPING.FUNROL WHERE ( ROL_ID = " + codRol + " )";
            ConnectorClass conexion = ConnectorClass.Instance;
            conexion.executeQuery(query);

        }

        public static void InsertarFuncionalidades(String CodRol, String funId)
        {
            ConnectorClass con = ConnectorClass.Instance;
            con.executeQuery("INSERT INTO BUGDEVELOPING.FUNROL (FUNCIONALIDAD_ID, ROL_ID) VALUES (" + funId + "," + CodRol + ")");
        }
    }
}
