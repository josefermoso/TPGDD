using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Afiliado
{
    class FuncionesAfiliado
    {
        public static DataTable obtenerPlanMedico()
        {
            DataTable Dt;
            String query = "SELECT pl_codigo 'CODIGO',pl_descripcion 'DESCRIPCION' FROM BUGDEVELOPING.PLAN_MEDICO";
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt;
        }
    }
}

