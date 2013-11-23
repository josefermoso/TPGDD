using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Amb_Planes
{
    public partial class listadoPlanes : Form
    {
        public listadoPlanes()
        {
            InitializeComponent();
        }

        private void listadoPlanes_Load(object sender, EventArgs e)
        {
            String query = "SELECT PL_DESCRIPCION as Planes, PL_PRECIO_CONSULTA as 'Precio Bono Consulta', PL_PRECIO_FARMACIA as 'Precio Bono Farmacia'  FROM BUGDEVELOPING.PLAN_MEDICO";
            ConnectorClass con = ConnectorClass.Instance;
            dataGridView1.DataSource = con.executeQuery(query);
            dataGridView1.Enabled = true;
            dataGridView1.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
