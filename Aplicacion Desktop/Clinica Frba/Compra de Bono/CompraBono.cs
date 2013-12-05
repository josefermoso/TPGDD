using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.CompraBono
{
    public partial class CompraBono : Form
    {

        public string numeroAfiliado;
        public string planID;
        public CompraBono(string numeroAfiliado)
        {
            InitializeComponent();
            this.numeroAfiliado = numeroAfiliado;
            this.label_numeroAfiliado.Text = numeroAfiliado;
            this.textBox_CantidadConsulta.Text = "0";
            this.textBox_CantidadFarmacia.Text = "0";
            buscarAfiliado();
        }

        private void button_BuscarAfiliado_Click(object sender, EventArgs e)
        {
            buscarAfiliado();
        }

        private void buscarAfiliado()
        {
            DataTable plan = Clinica_Frba.CompraBono.FuncionesCompraBono.planDeAfiliado(numeroAfiliado);
            planID = plan.Rows[0].ItemArray[0].ToString();
            label_Plan.Text = plan.Rows[0].ItemArray[1].ToString();
            label_PlanCostoConsulta.Text = plan.Rows[0].ItemArray[2].ToString();
            label_PlanCostoFarmacia.Text = plan.Rows[0].ItemArray[3].ToString();
        }

        private void textBox_CantidadFarmacia_TextChanged(object sender, EventArgs e)
        {
            if (textBox_CantidadFarmacia.Text.Length == 0) textBox_CantidadFarmacia.Text = "0";
            else label_totalFarmacia.Text = Convert.ToString(Convert.ToInt32(label_PlanCostoFarmacia.Text) * Convert.ToInt32(textBox_CantidadFarmacia.Text));
            cambiarTotalAAbonar();
        }

        private void textBox_CantidadBono_TextChanged(object sender, EventArgs e)
        {
            if (textBox_CantidadConsulta.Text.Length == 0) textBox_CantidadConsulta.Text = "0";
            else label_TotalConsulta.Text = Convert.ToString(Convert.ToInt32(label_PlanCostoConsulta.Text) * Convert.ToInt32(textBox_CantidadConsulta.Text));
            cambiarTotalAAbonar();
        }

        private void cambiarTotalAAbonar()
        {
            label_TotalAbonar.Text = Convert.ToString(Convert.ToInt32(label_TotalConsulta.Text) + Convert.ToInt32(label_totalFarmacia.Text));
        }

        private void textBox_CantidadBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textBox_CantidadFarmacia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectorClass conexion = ConnectorClass.Instance;
            String query = "EXECUTE BUGDEVELOPING.REGISTRAR_COMPRA " + label_TotalAbonar.Text + ", " + textBox_CantidadFarmacia.Text + ", " + textBox_CantidadConsulta.Text + ", " + label_numeroAfiliado.Text + ", " + planID + ", '" + ConnectorClass.getFechaSistema().ToString() + "'";
            conexion.executeQuery(query);
            MessageBox.Show("Se ha realizado la compra");
        }

    }
}
