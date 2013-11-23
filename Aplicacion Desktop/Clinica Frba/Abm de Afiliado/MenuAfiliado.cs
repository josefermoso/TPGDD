using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.abmAfiliado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConnectorClass cc;
        DataTable dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            cc = ConnectorClass.Instance;
            dt = cc.executeQuery("SELECT PL_CODIGO, PL_DESCRIPCION FROM BUGDEVELOPING.PLAN_MEDICO");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PL_DESCRIPCION";
            comboBox1.ValueMember = "PL_CODIGO";
            comboBox1.Text = "";
        }
    }
}
