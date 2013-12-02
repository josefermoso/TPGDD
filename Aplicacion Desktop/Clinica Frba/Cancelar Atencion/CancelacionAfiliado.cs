using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using System.Configuration;
using Clinica_Frba.Cancelar_Atencion;

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class CancelacionAfiliado : Form
    {
        public CancelacionAfiliado()
        {
            InitializeComponent();
        }


        private void CancelacionAfiliado_Load(object sender, EventArgs e)
        {
            ConnectorClass con = ConnectorClass.Instance;

            if (CancelacionAdmSist.nroAfilOProf != 0)
            {
                textBoxNroAfil.Text = CancelacionAdmSist.nroAfilOProf.ToString();
            }

            else
            {
                String idUsuario = "select USUARIO_ID from BUGDEVELOPING.USUARIO where USUARIO_USERNAME = '" + Clinica_Frba.Login.LoginForm.nombreUsuario + "' ";
                DataTable id_Usuario = con.executeQuery(idUsuario);

                String numeroAfiliado = "select PA_NAFILIADO from BUGDEVELOPING.PACIENTE where PA_USUARIO_ID = '" + id_Usuario.Rows[0][0] + "'";
                DataTable nroAfiliado = con.executeQuery(numeroAfiliado);

                textBoxNroAfil.Text = nroAfiliado.Rows[0][0].ToString();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ConnectorClass con = ConnectorClass.Instance;

            String turnos = "select T_ID Nro_de_Turno, PA.PE_APELLIDO +' '+ PA.PE_NOMBRE as Afiliado, PM.PE_APELLIDO +' '+ PM.PE_NOMBRE as Profesional, T_FECHA Fecha from BUGDEVELOPING.TURNO inner join BUGDEVELOPING.PACIENTE on (T_AFILIADO = PA_NAFILIADO) inner join BUGDEVELOPING.MEDICO on (T_MEDICO = ME_PERSONA) inner join BUGDEVELOPING.PERSONA PA on (PE_ID = PA_PERSONA) inner join BUGDEVELOPING.PERSONA PM on (PE_ID = ME_PERSONA) where PA_NAFILIADO = '" + textBoxNroAfil.Text + "'";
            dataGridViewTurnos.DataSource = con.executeQuery(turnos);
        }


        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurnos.RowCount == 0)
            {
                MessageBox.Show("Busque los turnos y seleccione el que desee cancelar ");
            }
            else
            {
                if (dataGridViewTurnos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccion invalida, no hay turno seleccionado");
                }
                else
                {
                    textBoxNumTurn.Text = dataGridViewTurnos.CurrentRow.Cells["Nro_De_Turno"].Value.ToString();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (textBoxNumTurn.Text == "")
            {
                MessageBox.Show("No hay turno seleccionado");
            }
            else
            {
                if (textBoxMotivo.Text == "")
                {
                    MessageBox.Show("Debe ingresar el motivo de la cancelacion");
                }
                else
                {
                    ConnectorClass con = ConnectorClass.Instance;
                    String fecha = "select DATEPART(YEAR, T_FECHA) Año, DATEPART(month, T_FECHA) Mes, DATEPART(day, T_FECHA) Dia from BUGDEVELOPING.TURNO where T_ID = '" + textBoxNumTurn.Text + "'";
                    DataTable validarFecha = con.executeQuery(fecha);
                    String fechaSistema = ConfigurationManager.AppSettings["fechaSistema"];

                    String year = fechaSistema.Substring(1, 4);
                    String month = fechaSistema.Substring(5, 2);
                    String day = fechaSistema.Substring(7, 2);

                    if (validarFecha.Rows[0][0].ToString() == year && validarFecha.Rows[0][1].ToString() == month && validarFecha.Rows[0][2].ToString() == day)
                    {
                        MessageBox.Show("La cancelacion debe realizarce con un dia de antelacion");
                    }
                    else
                    {
                        if (MessageBox.Show("Esta a punto de cancelar el turno numero: " + textBoxNumTurn.Text + " desea continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            String validacion = "select * from BUGDEVELOPING.CANCELACION_TURNO where CT_TURNO = '" + textBoxNumTurn.Text + "'";
                            DataTable turnoCancelado = con.executeQuery(validacion);

                            if (turnoCancelado.Rows.Count == 1)
                            {
                                if (Convert.ToInt32(turnoCancelado.Rows[0][2]) == 2 || Convert.ToInt32(turnoCancelado.Rows[0][2]) == 4)
                                {
                                    MessageBox.Show("Este turno ya fue cancelado");
                                }
                                else
                                {
                                    MessageBox.Show("Este turno fue cancelado por el profesional asignado");
                                }
                            }
                            else
                            {
                                String cancelacion = "insert into BUGDEVELOPING.CANCELACION_TURNO (CT_TURNO, CT_MOTIVO, CT_TIPO_CANCELACION) values (" + Convert.ToInt32(textBoxNumTurn.Text) + ",'" + textBoxMotivo.Text.ToString() + "' ,2)";

                                con.executeQuery(cancelacion);
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewTurnos.DataSource = "";
            textBoxMotivo.Text = "";
            textBoxNumTurn.Text = "";
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }  
    }
}
