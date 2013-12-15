using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.ConnectorSQL;
using System.Windows.Forms;

namespace Clinica_Frba
{
    public class FuncionesCargarComboBox
    {
        public static void cargarTipoDocumentos(ComboBox combo)
        {
            String queryTiposDocumentos = "SELECT TIPODOC_ID, TIPODOC_DESCRIPCION FROM BUGDEVELOPING.TIPO_DOCUMENTO UNION SELECT '0', 'Seleccione' FROM BUGDEVELOPING.TIPO_DOCUMENTO;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "TIPODOC_ID";
            combo.DisplayMember = "TIPODOC_DESCRIPCION";
            combo.DataSource = con.executeQuery(queryTiposDocumentos);
        }

        public static void cargarSexos(ComboBox combo)
        {
            String queryTiposDocumentos = "SELECT SEXO_ID, SEXO_DESCRIPCION FROM BUGDEVELOPING.SEXO UNION SELECT '0', 'Seleccione' FROM BUGDEVELOPING.SEXO;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "SEXO_ID";
            combo.DisplayMember = "SEXO_DESCRIPCION";
            combo.DataSource = con.executeQuery(queryTiposDocumentos);
        }
        public static void cargarEstadosCiviles(ComboBox combo)
        {
            String queryTiposDocumentos = "select ESTADO_CIVIL_ID, ESTADO_CIVIL_DESCRIPCION from BUGDEVELOPING.ESTADO_CIVIL UNION SELECT '0', 'Seleccione' FROM BUGDEVELOPING.ESTADO_CIVIL;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "ESTADO_CIVIL_ID";
            combo.DisplayMember = "ESTADO_CIVIL_DESCRIPCION";
            combo.DataSource = con.executeQuery(queryTiposDocumentos);
        }

        public static void cargarPlanesMedicos(ComboBox combo)
        {
            String queryTiposDocumentos = "SELECT PL_CODIGO, PL_DESCRIPCION FROM BUGDEVELOPING.PLAN_MEDICO UNION SELECT '0', 'Seleccione' FROM BUGDEVELOPING.PLAN_MEDICO;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "PL_CODIGO";
            combo.DisplayMember = "PL_DESCRIPCION";
            combo.DataSource = con.executeQuery(queryTiposDocumentos);
        }

        public static void cargarEspecialidades(ComboBox combo)
        {
            String queryEspecialidades = "SELECT ES_ID, ES_DESCRIPCION FROM BUGDEVELOPING.ESPECIALIDAD UNION SELECT '0', 'Seleccione' FROM BUGDEVELOPING.ESPECIALIDAD;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "ES_ID";
            combo.DisplayMember = "ES_DESCRIPCION";
            combo.DataSource = con.executeQuery(queryEspecialidades);
        }
    }
}
