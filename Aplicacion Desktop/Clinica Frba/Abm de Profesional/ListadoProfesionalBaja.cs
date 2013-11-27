using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class ListadoProfesional : Form
    {
        public ListadoProfesional()
        {
            InitializeComponent();
        }

        ConnectorClass cc;
        DataTable dt;

        public String idProfesional;

        private void ListadoProfesional_Load(object sender, EventArgs e)
        {
            //carga del dataGridView lista de profesionales
            cc = ConnectorClass.Instance;
            dt = cc.executeQuery("SELECT me_persona ID, pe_nombre NOMBRE, pe_apellido APELLIDO, pe_sexo SEXO, pe_fecha_nac AS 'FECHA DE NACIMIENTO', me_matricula MATRICULA, pe_tipo_doc AS 'TIPO DOC', pe_num_doc AS 'NUMERO DOC' FROM BUGDEVELOPING.MEDICO JOIN BUGDEVELOPING.PERSONA ON (PE_ID = ME_PERSONA) WHERE ME_ACTIVO = 1");
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //setea el formato del datetimepicker y la hora del sistema
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = ConnectorClass.getFechaSistema();


            //carga del comboBox sexo y tipo de documento
            comboBox2.Items.Add("Masculino");
            comboBox2.Items.Add("Femenino");

            comboBox1.Items.Add("DNI");
            comboBox1.Items.Add("LE");
            comboBox1.Items.Add("CI");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = comboBox2.Text.ToString();
            if (sexo == "Masculino")
                sexo = "M";
            if (sexo == "Femenino")
                sexo = "F";
            
            cc = ConnectorClass.Instance;
            string seleccion = "SELECT me_persona ID, pe_nombre NOMBRE, pe_apellido APELLIDO, pe_sexo SEXO, pe_fecha_nac AS 'FECHA DE NACIMIENTO', me_matricula MATRICULA, pe_tipo_doc AS 'TIPO DOC', pe_num_doc AS 'NUMERO DOC', 'CLICK PARA EDITAR' AS 'SELECCIONAR'";
            string origen = " FROM BUGDEVELOPING.MEDICO JOIN BUGDEVELOPING.PERSONA ON (PE_ID = ME_PERSONA)";
            string condicion = " WHERE ME_ACTIVO = 1";

            if (textBox1.Text != "")
            { condicion += " and PE_NOMBRE like " + "'%" + textBox1.Text + "%'"; }

            if (textBox2.Text != "")
            { condicion += "and  PE_APELLIDO like " + "'%" + textBox2.Text + "%'"; }

            if (textBox3.Text != "")
            { condicion += " and PE_NUM_DOC like " + "'%" + textBox3.Text + "%'"; }

            if (dateTimePicker1.Value != ConnectorClass.getFechaSistema())
            { condicion += " and PE_FECHA_NAC = '" + dateTimePicker1.Text + "'"; }

            if (comboBox2.Text != "")
            { condicion += " and PE_SEXO = '" + sexo + "'"; }
            
            if (textBox7.Text != "")
            { condicion += " and ME_MATRICULA like " + "'%" + textBox7.Text + "%'"; }

            dataGridView1.DataSource = cc.executeQuery(seleccion + origen + condicion);
            dataGridView1.Enabled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProfesional =  dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
    
}
