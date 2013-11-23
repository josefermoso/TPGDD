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
    public partial class AltaProfesional : Form
    {
        public AltaProfesional()
        {
            InitializeComponent();
        }

        DataTable dt;
        ConnectorClass cc;

        private void AltaProfesional_Load(object sender, EventArgs e)
        {
            DataTable DtEspecialidadesMedicas = Clinica_Frba.Abm_de_Profesional.FuncionesProfesional.obtenerEspecialidadesMedicas();
            checkedListBox1.DataSource = DtEspecialidadesMedicas;
            checkedListBox1.DisplayMember = "ES_DESCRIPCION";
            checkedListBox1.ValueMember = "ES_ID";
            
            
            comboBox2.Items.Add("Masculino");
            comboBox2.Items.Add("Femenino");
           

            comboBox1.Items.Add("DNI");
            comboBox1.Items.Add("LE");
            comboBox1.Items.Add("CI");


            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = ConnectorClass.getFechaSistema();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
            
            if (checkedListBox1.CheckedItems.Count == 0)
                //VALIDA LA CANTIDAD DE ESPECIALIDADES ESCOGIDAS
                {
                    MessageBox.Show("Debe seleccionar al menos una especialidad");
                }
                else
                {
                    //INSERTA EN LA BASE LOS DATOS DE LA PERSONA
                    FuncionesProfesional.registrarPersona(nombre, apellido, direccion, telefono, mail, sexo, fechaNacimiento, tipoDoc, nroDoc);
                    
                    //INSERTA EN LA BASE LOS DATOS DEL PROFESIONAL
                    cc = ConnectorClass.Instance;
                    dt = cc.executeQuery("select PE_ID FROM BUGDEVELOPING.PERSONA WHERE (PE_NUM_DOC = '" + nroDoc + "' AND PE_NOMBRE = '" + nombre + "' AND PE_APELLIDO = '" + apellido + "')");
                    String idProfesional = dt.Rows[0].ItemArray[0].ToString();
                    String query = "INSERT INTO BUGDEVELOPING.MEDICO (ME_PERSONA, ME_MATRICULA, ME_ACTIVO)";
                    String datosAIngresar = " VALUES ('" + idProfesional + "', '" + matricula + "', 1)";
                    cc.executeQuery(query + datosAIngresar);
                    
                    //RECORRE LA LISTA DE ESPECIALIDADES SELECCIONADAS PARA EL MEDICO
                    foreach (DataRowView FilaSeleccionados in checkedListBox1.CheckedItems)
                    {   //INGRESA EN LA BASE PARA LA TABLA ESPECIALIDAD_MEDICO
                        String strEspCod = FilaSeleccionados["ES_ID"].ToString();
                        query = "INSERT INTO BUGDEVELOPING.ESPECIALIDAD_MEDICO (EM_MEDICO, EM_ESPECIALIDAD) VALUES ('" + idProfesional + "', '" + strEspCod + "')";
                        cc.executeQuery(query);                    
                    }
                    MessageBox.Show("Profesional Creado Exitosamente");
                    button2_Click(sender, e);
                }

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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }    
    }

    
}