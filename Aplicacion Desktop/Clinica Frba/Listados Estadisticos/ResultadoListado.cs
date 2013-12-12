using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class ResultadoListado : Form
    {
        public ResultadoListado(String numeroListado, String year, String month1, String month2)
        {
            InitializeComponent();
            if (numeroListado.Equals("1"))
            {
                String query = "execute BUGDEVELOPING.LIST1 " + "'" + year + "' , '" + month1 + "' , '" + month2 + " ' ";
                ConnectorClass con = ConnectorClass.Instance;
                DataTable dt = con.executeQuery(query);
                if (dt.Rows.Count != 0)
                {
                    dataGridViewLISTADO.DataSource = con.executeQuery(query);
                    dataGridViewLISTADO.Enabled = true;
                    con.CerrarConexion();


                }
                else
                {
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/meses elegida");
                }

            }
            else if (numeroListado.Equals("2"))
            {
                String query = "execute BUGDEVELOPING.LIST2 " + "'" + year + "' , '" + month1 + "' , '" + month2 + "'";
                ConnectorClass con = ConnectorClass.Instance;


                DataTable dt = con.executeQuery(query);

                if (dt.Rows.Count != 0)
                {
                    dataGridViewLISTADO.DataSource = con.executeQuery(query);
                    dataGridViewLISTADO.Enabled = true;
                    con.CerrarConexion();

                }
                else
                {
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/meses elegida");
                }


            }
            else if (numeroListado.Equals("3"))
            {
                String query = "execute BUGDEVELOPING.LIST3 " + "'" + year + "' , '" + month1 + "' , '" + month2 + " ' ";
                ConnectorClass con = ConnectorClass.Instance; 
                DataTable dt = con.executeQuery(query);
                if (dt.Rows.Count != 0)
                {
                    dataGridViewLISTADO.DataSource = con.executeQuery(query);
                    dataGridViewLISTADO.Enabled = true;
                    con.CerrarConexion();

                }
                else
                {
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/meses elegida");
                }


            }
            else if (numeroListado.Equals("4"))
            {
                String query = "execute BUGDEVELOPING.LIST4 " + "'" + year + "' , '" + month1 + "' , '" + month2 + " ' ";
                ConnectorClass con = ConnectorClass.Instance;
                DataTable dt = con.executeQuery(query);
                if (dt.Rows.Count != 0)
                {
                    dataGridViewLISTADO.DataSource = con.executeQuery(query);
                    dataGridViewLISTADO.Enabled = true;
                    con.CerrarConexion();

                }
                else
                {
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/meses elegida");
                }


            }

        }

        private void buttonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
