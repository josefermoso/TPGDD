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
    public partial class ListadoAfiliadoCompraBono : Form
    {
        private ConnectorClass con = ConnectorClass.Instance;

        public ListadoAfiliadoCompraBono()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListadoAfiliado_Load(object sender, EventArgs e)
        {
            string query = "select pe_nombre 'Nombre',pe_apellido 'Apellido',pe_tipo_doc 'Tipo Documento',pe_num_doc 'Numero',pa_nAfiliado 'Numero Afiliado' from BUGDEVELOPING.PACIENTE pa join BUGDEVELOPING.PERSONA pe on (pa_persona = pe_id)";
            dataGridView1.DataSource = con.executeQuery(query);
            dataGridView1.Enabled = true;
            dataGridView1.AutoResizeColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Rol Creado Exitosamente");
        }


        private void search()
        {
            string query = "select pe_nombre 'Nombre',pe_apellido 'Apellido',pe_tipo_doc 'Tipo Documento',pe_num_doc 'Numero',pa_nAfiliado 'Numero Afiliado' from BUGDEVELOPING.PACIENTE pa join BUGDEVELOPING.PERSONA pe on (pa_persona = pe_id) WHERE pa_activo = 1";

            if (textBox_NumeroSocio.Text != "") query = query + "AND pa_nAfiliado = " + textBox_NumeroSocio.Text;
            if (textBox_TipoDoc.Text != "") query = query + " AND pe_tipo_doc LIKE '%" + textBox_TipoDoc.Text + "%'";
            if (textBox_NumeroDoc.Text != "") query = query + " AND pe_num_doc = '" + textBox_NumeroDoc.Text + "'";
            if (textBox_Apellido.Text != "") query = query + " AND pe_apellido LIKE '%" + textBox_Apellido.Text + "%'";
            if (textBox_Nombre.Text != "") query = query + " AND pe_nombre LIKE '%" + textBox_Nombre.Text + "%'";

            dataGridView1.DataSource = con.executeQuery(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_NumeroSocio.Text = "";
            textBox_TipoDoc.Text = "";
            textBox_NumeroDoc.Text = "";
            textBox_Apellido.Text = "";
            textBox_Nombre.Text = "";
            this.search();
        }
    }
}
