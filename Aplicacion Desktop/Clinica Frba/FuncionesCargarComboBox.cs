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
            String queryTiposDocumentos = "SELECT ID_TIPO_DOCUMENTO, DESCRIPCION FROM HARDWELL.TIPO_DOCUMENTO UNION SELECT '0', 'Seleccione' FROM HARDWELL.TIPO_DOCUMENTO;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "ID_TIPO_DOCUMENTO";
            combo.DisplayMember = "DESCRIPCION";
            combo.DataSource = con.executeQuery(queryTiposDocumentos);
        }

        public static void cargarSexos(ComboBox combo)
        {
            String queryTiposDocumentos = "SELECT ID_SEXO, DESCRIPCION FROM HARDWELL.SEXO UNION SELECT '0', 'Seleccione' FROM HARDWELL.SEXO;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "ID_SEXO";
            combo.DisplayMember = "DESCRIPCION";
            combo.DataSource = con.executeQuery(queryTiposDocumentos);
        }
        public static void cargarEstadosCiviles(ComboBox combo)
        {
            String queryTiposDocumentos = "select ID_ESTADO_CIVIL, DESCRIPCION from HARDWELL.ESTADO_CIVIL UNION SELECT '0', 'Seleccione' FROM HARDWELL.ESTADO_CIVIL;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "ID_ESTADO_CIVIL";
            combo.DisplayMember = "DESCRIPCION";
            combo.DataSource = con.executeQuery(queryTiposDocumentos);
        }

        public static void cargarPlanesMedicos(ComboBox combo)
        {
            String queryTiposDocumentos = "SELECT ID_PLAN_MEDICO, DESCRIPCION FROM HARDWELL.PLAN_MEDICO UNION SELECT '0', 'Seleccione' FROM HARDWELL.PLAN_MEDICO;";
            ConnectorClass con = ConnectorClass.Instance;
            combo.ValueMember = "ID_PLAN_MEDICO";
            combo.DisplayMember = "DESCRIPCION";
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
