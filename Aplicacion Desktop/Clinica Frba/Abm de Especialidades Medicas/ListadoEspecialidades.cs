using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Amb_Especialidades
{
    public partial class listadoEspecialidades : Form
    {
        public listadoEspecialidades()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String query = "SELECT ES_DESCRIPCION as Especialidad, TIPO_ES_DESCRIPCION as 'Tipo de Especialidad'  FROM BUGDEVELOPING.ESPECIALIDAD JOIN BUGDEVELOPING.TIPO_ESPECIALIDAD ON (ES_TIPO = TIPO_ES_ID)";
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
