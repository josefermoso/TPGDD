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
    public partial class CancelacionProf : Form
    {
        public CancelacionProf()
        {
            InitializeComponent();
        }
        private String yearX, yearXDesde, yearXHasta;
        private String mes, mesDesde, mesHasta;
        private String dia, diaDesde, diaHasta;
        private int acumTurnCancelado;
        private int acumTurnNoCancelado;
        private DataTable turnosNoCancelados = new DataTable();
        private String year;
        private String month;
        private String day;
        private String time;

        private void CancelacionProf_Load(object sender, EventArgs e)
        {
            ConnectorClass con = ConnectorClass.Instance;
            acumTurnCancelado = 0;
            acumTurnNoCancelado = 0;
            turnosNoCancelados.Columns.Add("id_turno");

            String fechaSistema = ConfigurationManager.AppSettings["fechaSistema"];

            year = fechaSistema.Substring(1, 4);
            month = fechaSistema.Substring(5, 2);
            day = fechaSistema.Substring(7, 2);
            time = fechaSistema.Substring(10, 8);

            if (Convert.ToInt16(day) < 10)
            {
                day = "0" + day;
            }

            if (CancelacionAdmSist.nroAfilOProf != 0)
            {
                String prof = "select  PE_APELLIDO, PE_NOMBRE, PE_NUM_DOC from BUGDEVELOPNG.MEDICO inner join BUGDEVELOPING.PERSONA on (PE_ID = ME_PERSONA) where ME_PERSONA = '" + CancelacionAdmSist.nroAfilOProf.ToString() + "'";
                DataTable profesional = con.executeQuery(prof);

                textBoxId.Text = CancelacionAdmSist.nroAfilOProf.ToString();
                textBoxApe.Text = profesional.Rows[0][0].ToString();
                textBoxNom.Text = profesional.Rows[0][1].ToString();
                textBoxNDoc.Text = profesional.Rows[0][2].ToString();
            }

            else
            {

                String idUsuario = "select USUARIO_ID from BUGDEVELOPING.USUARIO where  USUARIO_USERNAME = '" + Clinica_Frba.Login.LoginForm.nombreUsuario + "' ";
                DataTable id_Usuario = con.executeQuery(idUsuario);

                String prof = "select ME_PERSONA, PE_APELLIDO, PE_NOMBRE, PE_NUM_DOC from BUGDEVELOPING.MEDICO inner join BUGDEVELOPING.PERSONA on (PE_ID = ME_PERSONA) where PE_USUARIO_ID = '" + id_Usuario.Rows[0][0].ToString() + "'";
                DataTable profesional = con.executeQuery(prof);

                textBoxId.Text = profesional.Rows[0][0].ToString();
                textBoxApe.Text = profesional.Rows[0][1].ToString();
                textBoxNom.Text = profesional.Rows[0][2].ToString();
                textBoxNDoc.Text = profesional.Rows[0][3].ToString();

            }

        }

        private void buttonSelecDia_Click(object sender, EventArgs e)
        {
            textBoxDiaElegido.Text = monthCalendarDia.SelectionEnd.ToShortDateString();
            yearX = monthCalendarDia.SelectionEnd.Year.ToString();
            mes = monthCalendarDia.SelectionEnd.Month.ToString();
            dia = monthCalendarDia.SelectionEnd.Day.ToString();
            if (Convert.ToInt16(dia) < 10)
            {
                dia = "0" + dia;
            }
        }

        private void buttonAcepDia_Click(object sender, EventArgs e)
        {
            if (textBoxDiaElegido.Text == "")
            {
                MessageBox.Show("Eliga el dia a ser cancelado");
            }
            else
            {
                if (yearX == year && mes == month && dia == day)
                {
                    MessageBox.Show("La cancelacion debe realizarce con un dia de antelacion");
                }
                else
                {
                    if ((Convert.ToInt16(yearX) < Convert.ToInt16(year)) || (Convert.ToInt16(yearX) == Convert.ToInt16(year) && Convert.ToInt16(mes) < Convert.ToInt16(month)) || (Convert.ToInt16(yearX) == Convert.ToInt16(year) && Convert.ToInt16(mes) == Convert.ToInt16(month) && Convert.ToInt16(dia) < Convert.ToInt16(day)))
                    {
                        MessageBox.Show("Fecha invalida, no se pueden cancelar turnos con fecha anterior a la actual");
                    }
                    else
                    {
                        if (textBoxMotivo.Text == "")
                        {
                            MessageBox.Show("Debe ingresar el motivo de la cancelacion");
                        }
                        else
                        {
                            if (MessageBox.Show("Esta a punto de cancelar los turnos para el dia: " + textBoxDiaElegido.Text + " desea continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ConnectorClass con = ConnectorClass.Instance;
                                String idTurnos = "select T_ID from BUGDEVELOPING.TURNO where T_MEDICO = " + textBoxId.Text + " and T_FECHA = convert(date, '" + yearX + mes + dia + "' , 112) " + "and not exists(select * from BUGDEVELOPING.CONSULTA where T_ID=CON_TURNO)";
                                DataTable turnos = con.executeQuery(idTurnos);
                                
                                if (turnos.Rows.Count > 0)
                                {
                                    for (int j = 0; j < turnos.Rows.Count; j++)
                                    {
                                        String idTurnCancel = "select CT_TURNO from BUGDEVELOPING.CANCELACION_TURNO where CT_TURNO = " + turnos.Rows[j][0].ToString() + "and not exists(select * from BUGDEVELOPING.CONSULTA where T_ID=CON_TURNO)";
                                        DataTable turnoCancelado = con.executeQuery(idTurnCancel);
                                        if (turnoCancelado.Rows.Count > 0)
                                        {
                                            acumTurnCancelado++;
                                        }
                                        else
                                        {
                                            DataRow nuevaRow = turnosNoCancelados.NewRow();
                                            acumTurnNoCancelado++;
                                            nuevaRow["id_turno"] = turnos.Rows[j][0];
                                            turnosNoCancelados.Rows.Add(nuevaRow);
                                        }
                                    }
                                    if (acumTurnCancelado == turnos.Rows.Count)
                                    {
                                        MessageBox.Show("Todos los turnos de este dia ya fueron cancelados");
                                    }
                                    else
                                    {
                                        if (acumTurnNoCancelado > 0)
                                        {
                                            if (MessageBox.Show("Usted tiene " + acumTurnNoCancelado.ToString() + " turnos sin cancelar en este dia, desea cancelarlos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                for (int i = 0; i < turnosNoCancelados.Rows.Count; i++)
                                                {
                                                    String cancelarTurno = "insert into BUGDEVELOPING.CANCELACION_TURNO(CT_TIPO_CANCELACION, CT_TURNO, CT_MOTIVO) values(1," + turnosNoCancelados.Rows[i][0] + ",'" + textBoxMotivo.Text + "')";
                                                    con.executeQuery(cancelarTurno);
                                                }
                                                MessageBox.Show("Turnos cancelados");
                                            }

                                        }

                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Usted no tiene turnos en este dia");
                                }
                                acumTurnCancelado = 0;
                                acumTurnNoCancelado = 0;
                                turnosNoCancelados.Clear();
                            }
                        }
                    }
                }
            }

        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxMotivo.Text = "";
            textBoxDiaElegido.Text = "";
            textBoxDesde.Text = "";
            textBoxHasta.Text = "";
        }

        private void buttonSelDesd_Click(object sender, EventArgs e)
        {
            textBoxDesde.Text = monthCalendarPeriodo.SelectionEnd.ToShortDateString();
            yearXDesde = monthCalendarPeriodo.SelectionEnd.Year.ToString();
            mesDesde = monthCalendarPeriodo.SelectionEnd.Month.ToString();
            diaDesde = monthCalendarPeriodo.SelectionEnd.Day.ToString();
            if (Convert.ToInt16(diaDesde) < 10)
            {
                diaDesde = "0" + diaDesde;
            }
        }

        private void buttonSelHasta_Click(object sender, EventArgs e)
        {
            textBoxHasta.Text = monthCalendarPeriodo.SelectionEnd.ToShortDateString();
            yearXHasta = monthCalendarPeriodo.SelectionEnd.Year.ToString();
            mesHasta = monthCalendarPeriodo.SelectionEnd.Month.ToString();
            diaHasta = monthCalendarPeriodo.SelectionEnd.Day.ToString();
            if (Convert.ToInt16(diaHasta) < 10)
            {
                diaHasta = "0" + diaHasta;
            }
        }

        private void buttonAceptarPeriodo_Click(object sender, EventArgs e)
        {
            if (textBoxDesde.Text.Length == 0 || textBoxHasta.Text.Length == 0)
            {
                MessageBox.Show("Campos incompletos, seleccione el periodo deseado");
            }
            else
            {
                if ((Convert.ToDateTime(textBoxDesde.Text) > Convert.ToDateTime(textBoxHasta.Text)) || (Convert.ToInt16(yearXDesde) < Convert.ToInt16(year)) || (Convert.ToInt16(yearXDesde) == Convert.ToInt16(year) && Convert.ToInt16(mesDesde) < Convert.ToInt16(month)) || (Convert.ToInt16(yearXDesde) == Convert.ToInt16(year) && Convert.ToInt16(mesDesde) == Convert.ToInt16(month) && Convert.ToInt16(diaDesde) < Convert.ToInt16(day)))
                {
                    MessageBox.Show("Periodo invalido");
                    textBoxHasta.Text = "";
                    textBoxDesde.Text = "";
                }
                else
                {
                    if (yearXDesde == year && mesDesde == month && diaDesde == day)
                    {
                        MessageBox.Show("La cancelacion debe realizarce con un dia de antelacion");
                    }
                    else
                    {
                        if (textBoxMotivo.Text == "")
                        {

                            MessageBox.Show("Debe ingresar el motivo de la cancelacion");
                        }
                        else
                        {
                            if (MessageBox.Show("Esta a punto de cancelar los turnos para el periodo que va desde: " + textBoxDesde.Text + " hasta: " + textBoxHasta.Text + " desea continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ConnectorClass con = ConnectorClass.Instance;
                                String idTurnos = "select T_ID from BUGDEVELOPING.TURNO where T_MEDICO = " + textBoxId.Text + " and T_FECHA between CONVERT(DATE, '" + yearXDesde + mesDesde + diaDesde + "', 112) and CONVERT(DATE, '" + yearXHasta + mesHasta + diaHasta + "', 112) and not exists(select * from BUGDEVELOPING.CONSULTA where T_ID=CON_TURNO)";
                                DataTable turnos = con.executeQuery(idTurnos);

                                if (turnos.Rows.Count > 0)
                                {
                                    for (int j = 0; j < turnos.Rows.Count; j++)
                                    {
                                        String idTurnCancel = "select CT_TURNO from BUGDEVELOPING.CANCELACION_TURNO where CT_TURNO = " + turnos.Rows[j][0].ToString();
                                        DataTable turnoCancelado = con.executeQuery(idTurnCancel);
                                        if (turnoCancelado.Rows.Count > 0)
                                        {
                                            acumTurnCancelado++;
                                        }
                                        else
                                        {
                                            DataRow nuevaRow = turnosNoCancelados.NewRow();
                                            acumTurnNoCancelado++;
                                            nuevaRow["id_turno"] = turnos.Rows[j][0];
                                            turnosNoCancelados.Rows.Add(nuevaRow);
                                        }
                                    }
                                    if (acumTurnCancelado == turnos.Rows.Count)
                                    {
                                        MessageBox.Show("Todos los turnos de este periodo ya fueron cancelados");
                                    }
                                    else
                                    {
                                        if (acumTurnNoCancelado > 0)
                                        {
                                            if (MessageBox.Show("Usted tiene " + acumTurnNoCancelado.ToString() + " sin cancelar en este periodo, desea cancelarlos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                for (int i = 0; i < turnosNoCancelados.Rows.Count; i++)
                                                {
                                                    String cancelarTurno = "insert into BUGDEVELOPING.CANCELACION_TURNO(CT_TIPO_CANCELACION, CT_TURNO, CT_MOTIVO) values(1," + turnosNoCancelados.Rows[i][0] + ",'" + textBoxMotivo.Text + "')";
                                                    con.executeQuery(cancelarTurno);
                                                }
                                                MessageBox.Show("Turnos cancelados");
                                            }

                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Usted no tiene turnos en este periodo");
                                }
                                acumTurnCancelado = 0;
                                acumTurnNoCancelado = 0;
                                turnosNoCancelados.Clear();
                            }
                        }
                    }
                }
            }
        }
    }
}
