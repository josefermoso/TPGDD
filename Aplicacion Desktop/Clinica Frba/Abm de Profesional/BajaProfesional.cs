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
    public partial class BajaProfesional : Form
    {
        public BajaProfesional()
        {
            InitializeComponent();
        }

        ConnectorClass cc;
        DataTable dt;

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe seleccionar el profesional a dar de baja.");
            }
            else
            {
                cc = ConnectorClass.Instance;
                String query = "SELECT PE_NOMBRE, PE_APELLIDO FROM BUGDEVELOPING.MEDICO JOIN BUGDEVELOPING.PERSONA ON (PE_ID = ME_PERSONA) WHERE PE_ID = '" + textBox1.Text + "'";
                dt = cc.executeQuery(query);
                DialogResult resultConfirm = MessageBox.Show("Esta a punto de eliminar al profesional: " + dt.Rows[0].ItemArray[0].ToString() + " " + dt.Rows[0].ItemArray[0].ToString() + ". Se cancelarán automaticamente todos sus turnos. ¿Desea continuar?", "Eliminar Profesional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultConfirm == DialogResult.Yes)
                {
                    query = "UPDATE BUGDEVELOPING.MEDICO SET ME_ACTIVO = 0 WHERE ME_PERSONA = '" + textBox1.Text + "'";
                    cc.executeQuery(query);
                    query = "UPDATE BUGDEVELOPING.TURNO SET T_ACTIVO = 0 WHERE T_MEDICO = '" + textBox1.Text + "'";
                    MessageBox.Show("El profesional ha sido dado de baja.");
                    BajaProfesional_Load(sender, e);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ListadoProfesionalBaja listadoProfesionalBajaForm = new ListadoProfesionalBaja();
            DialogResult result = listadoProfesionalBajaForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.BackColor = System.Drawing.Color.White;
                textBox1.Text = listadoProfesionalBajaForm.idProfesional;
            }
        }

        private void BajaProfesional_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
        }
    }
}
