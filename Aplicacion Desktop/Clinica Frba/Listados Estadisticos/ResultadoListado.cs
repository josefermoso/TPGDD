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

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class ResultadoListado : Form
    {
        public ResultadoListado(String numeroListado, String year, String semestre)
        {
            InitializeComponent();
            if (numeroListado.Equals("1") && semestre.Equals("1"))
            {
                String query = "execute BUGDEVELOPING.LIST1_PRI " + "'" + year + "'";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }

            } if (numeroListado.Equals("1") && semestre.Equals("2"))
            {
                String query = "execute BUGDEVELOPING.LIST1_SEG " + "'" + year + "'";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }

            }

            else if (numeroListado.Equals("2") && semestre.Equals("1"))
            {
                String query = "execute BUGDEVELOPING.LIST2_PRI " + "'" + year + "' , " + ConfigurationManager.AppSettings["fechaSistema"] + " ";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }


            }
            else if (numeroListado.Equals("2") && semestre.Equals("2"))
            {
                String query = "execute BUGDEVELOPING.LIST2_SEG " + "'" + year + "' , " + ConfigurationManager.AppSettings["fechaSistema"] + "  ";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }


            }
            else if (numeroListado.Equals("3") && semestre.Equals("1"))
            {
                String query = "execute BUGDEVELOPING.LIST3_PRI " + "'" + year + "'";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }


            }
            else if (numeroListado.Equals("3") && semestre.Equals("2"))
            {
                String query = "execute BUGDEVELOPING.LIST3_SEG " + "'" + year + "'";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }


            }


            else if (numeroListado.Equals("4") && semestre.Equals("1"))
            {
                String query = "execute BUGDEVELOPING.LIST4_PRI " + "'" + year + "'";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }


            }
            else if (numeroListado.Equals("4") && semestre.Equals("2"))
            {
                String query = "execute BUGDEVELOPING.LIST4_SEG " + "'" + year + "'";
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
                    MessageBox.Show("No se registraron datos para la consulta realizada con la configuración de año/semestre elegida");
                    this.Close();
                }


            }

        }

        private void buttonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
