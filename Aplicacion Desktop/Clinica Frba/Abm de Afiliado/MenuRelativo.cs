using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using System.Configuration;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class MenuRelativo : Form
    {
        public AfiliadoPersona titular;
        public MenuRelativo()
        {
            InitializeComponent();
        }

        public MenuRelativo(AfiliadoPersona titu)
        {
            InitializeComponent();
            this.titular = titu;

        }

        private bool titularYaTieneConyugue()
        {
            foreach (AfiliadoPersona afiliado in this.titular.relativos)
            {
                if (afiliado.esConyugue) return true;
            }

            string nAfiliado = obtenerNAfiliadoDe(this.titular.iDDB);
            int nConyugue = Convert.ToInt32(nAfiliado) + 1;
            string query = "SELECT * FROM BUGDEVELOPING.PACIENTE where pa_nAfiliado = " + nConyugue;
            ConnectorClass conexion = ConnectorClass.Instance;
            DataTable Dt = conexion.executeQuery(query);
            if (Dt.Rows.Count > 0) return true;

            return false;
        }
        private void button_Conyugue_Click(object sender, EventArgs e)
        {
            if (titularYaTieneConyugue())
            {
                MessageBox.Show("No se puede crear mas de un conyugue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Afiliado conyugueForm = new Afiliado(true);
            conyugueForm.titular = this.titular;
            conyugueForm.Show();
            this.Close();
        }

        private void button_Relativo_Click(object sender, EventArgs e)
        {
            Afiliado relativoForm = new Afiliado(false);
            relativoForm.titular = this.titular;
            relativoForm.Show();
            this.Close();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuRelativo_Load(object sender, EventArgs e)
        {

        }
        private string obtenerIdDePersona(AfiliadoPersona persona)
        {
            DataTable Dt;

            String query = "SELECT pe_id FROM BUGDEVELOPING.PERSONA WHERE '" + persona.nombre + "' = pe_nombre AND '" +
                                                                       persona.apellido + "' = pe_apellido AND '" +
                                                                       persona.tipoDoc + "' = pe_tipo_doc AND " +
                                                                       persona.nroDoc + " = pe_num_doc";

            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            if (Dt.Rows.Count == 0) return "";
            return Dt.Rows[0].ItemArray[0].ToString();
        }
        private string obtenerNAfiliadoDe(string idTitular)
        {

            DataTable Dt;
            string query = "SELECT pa_nAfiliado from BUGDEVELOPING.PACIENTE WHERE pa_persona = " + idTitular;
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt.Rows[0].ItemArray[0].ToString();
        }

    }
}
