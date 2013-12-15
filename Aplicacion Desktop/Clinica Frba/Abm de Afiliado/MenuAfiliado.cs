using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class MenuAfiliado : Form
    {
        public MenuAfiliado()
        {
            InitializeComponent();
        }

        ConnectorClass cc;
        DataTable dt;

        private void MenuAfiliado_Load(object sender, EventArgs e)
        {
            cc = ConnectorClass.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afiliado afiliadoForm = new Afiliado();
            afiliadoForm.Show();
            this.Hide();
        }

        private void MenuAfiliado_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListadoAfiliado listadoFrom = new ListadoAfiliado(Operacion.ALTA_EXISTENTE);
            listadoFrom.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoAfiliado listadoFrom = new ListadoAfiliado(Operacion.MODIFICACION);
            listadoFrom.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoAfiliado listadoFrom = new ListadoAfiliado(Operacion.BAJA);
            listadoFrom.Show();
            this.Hide();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }
    }
}
