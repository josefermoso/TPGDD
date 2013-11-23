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
    public partial class ModificacionProfesional : Form
    {
        public ModificacionProfesional()
        {
            InitializeComponent();
        }

        public String pk_medico;

        private void ModificarProfesional_Load(object sender, EventArgs e)
        {
            DataTable profesional = Clinica_Frba.Abm_de_Profesional.FuncionesProfesional.obtenerProfesional(pk_medico);
            textBox1.Text = profesional.Rows[0].ItemArray[0].ToString();
            textBox2.Text = profesional.Rows[0].ItemArray[1].ToString();
            textBox3.Text = profesional.Rows[0].ItemArray[6].ToString();
            textBox4.Text = profesional.Rows[0].ItemArray[7].ToString();
            textBox5.Text = profesional.Rows[0].ItemArray[8].ToString();
            textBox6.Text = profesional.Rows[0].ItemArray[9].ToString();
            textBox7.Text = profesional.Rows[0].ItemArray[4].ToString();
            comboBox1.Text = profesional.Rows[0].ItemArray[5].ToString();
            if (profesional.Rows[0].ItemArray[2].ToString() == "M")
                comboBox2.Text = "Masculino";
            if (profesional.Rows[0].ItemArray[2].ToString() == "F")
                comboBox1.Text = "Femenino";

            

            DataTable DtEspecialidadesMedicas = Clinica_Frba.Abm_de_Profesional.FuncionesProfesional.obtenerEspecialidadesMedicas();
            checkedListBox1.DataSource = DtEspecialidadesMedicas;
            checkedListBox1.DisplayMember = "ES_DESCRIPCION";
            checkedListBox1.ValueMember = "ES_ID";

            DataTable especialidadesDelProfesional = Clinica_Frba.Abm_de_Profesional.FuncionesProfesional.obtenerEspecialidadesDe(pk_medico);
            for (int i = 0; i < especialidadesDelProfesional.Rows.Count; i++)
            {
                for (int p = 0; p < checkedListBox1.Items.Count; p++)
                {
                    if (especialidadesDelProfesional.Rows[i].ToString().Equals(checkedListBox1.GetItemText(p).ToString()))
                    {
                        checkedListBox1.SetItemChecked(p, true);
                    }
                }
            }


            comboBox2.Items.Add("Masculino");
            comboBox2.Items.Add("Femenino");


            comboBox1.Items.Add("DNI");
            comboBox1.Items.Add("LE");
            comboBox1.Items.Add("CI");



            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = ConnectorClass.getFechaSistema();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.ToString();
            string apellido = textBox2.Text.ToString();


            string direccion = textBox4.Text.ToString();
            string telefono = textBox5.Text.ToString();
            string mail = textBox6.Text.ToString();

            string sexo = comboBox2.Text.ToString();
            if (comboBox2.Text.ToString() == "Masculino")
                sexo = "M";
            if (comboBox2.Text.ToString() == "Femenino")
                sexo = "F";

            string fechaNacimiento = dateTimePicker1.Value.ToString();
            string tipoDoc = comboBox1.Text.ToString();
            string nroDoc = textBox3.Text.ToString();
            string matricula = textBox7.Text.ToString();


            if (textBox1.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el nombre del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textBox2.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el apellido del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textBox3.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar el documento del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBox1.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe seleccionar el tipo de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBox1.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe seleccionar el sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textBox7.Text.Length.Equals(0))
            {
                MessageBox.Show("Debe ingresar la matricula del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            /*if (checkedListBox1.CheckedItems.Count == 0)
            //VALIDA LA CANTIDAD DE ESPECIALIDADES ESCOGIDAS
            {
                MessageBox.Show("Debe seleccionar al menos una especialidad");
            }*/
            else
            {
                //ACTUALIZA EN LA BASE LOS DATOS DE LA PERSONA Y DEL PROFESIONAL
                FuncionesProfesional.updatePersonaYProfesional(nombre, apellido, direccion, telefono, mail, sexo, fechaNacimiento, tipoDoc, nroDoc, matricula, pk_medico);

                /*//RECORRE LA LISTA DE ESPECIALIDADES SELECCIONADAS PARA EL MEDICO
                foreach (DataRowView FilaSeleccionados in checkedListBox1.CheckedItems)
                {   //ACTUALIZA EN LA BASE PARA LA TABLA ESPECIALIDAD_MEDICO
                    String strEspCod = FilaSeleccionados["ES_ID"].ToString();
                }
                */
                MessageBox.Show("Profesional Modificado Exitosamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            /* limpia el chequeo del checklistbox de especialidades */
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            dateTimePicker1.Value = ConnectorClass.getFechaSistema();
        }
    }
}
