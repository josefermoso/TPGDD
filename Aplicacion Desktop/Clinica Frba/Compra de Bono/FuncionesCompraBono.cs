using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.CompraBono
{
    class FuncionesCompraBono
    {
        public static DataTable planDeAfiliado(string numeroAfiliado)
        {
            DataTable Dt;
            String query = "Select pl_codigo,pl_descripcion,pl_precio_consulta,pl_precio_farmacia from BUGDEVELOPING.PLAN_MEDICO join BUGDEVELOPING.PACIENTE on (pa_plan = pl_codigo) where pa_nAfiliado = "+numeroAfiliado;
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt;
        }
    }
}

