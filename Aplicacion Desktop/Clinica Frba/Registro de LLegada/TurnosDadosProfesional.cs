﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using System.Configuration;

namespace Clinica_Frba.Registro_de_LLegada
{
    public partial class TurnosDadosProfesional : Form
    {
        public string idProfesional;

        //DEBERIA SER LA HORA DEL SISTEMA
        //String fyh = convertDate();
        TimeSpan horaLlegada = ConnectorClass.getFechaSistema().TimeOfDay;

        public TurnosDadosProfesional()
        {
            InitializeComponent();
        }

        private void TurnosDadosProfesional_Load(object sender, EventArgs e)
        {

        }

        public void LlenarTurnos()
        {

            ConnectorClass Conexion = ConnectorClass.Instance;
            DataTable Dt;

            // DateTime fecha = new DateTime(2013, 11, 18);

            //System.Console.WriteLine(fecha.Date.ToString());

            //string val = String.Format("{0:yyyy-MM-dd}", fecha);

            String val = convertDate();
            //+ "' AND t.FECHA = '" + val +"'

            String query = "select distinct t.ID_TURNO,t.FECHA,t.HORA,t.NRO_AFILIADO from HARDWELL.CONSULTA_MEDICA cm, HARDWELL.TURNO as t where not exists (select * from HARDWELL.CONSULTA_MEDICA as cm where cm.ID_TURNO=t.ID_TURNO ) and t.ID_PROFESIONAL = '" + idProfesional + "' AND t.FECHA >= '" + val + "'";

            grillaProfesional.Columns["SELECCIONAR"].Visible = false;


            int result = 0;
            if (!int.TryParse(nombreAfiliado.Text, out result) && nombreAfiliado.Text != "")
            {
                MessageBox.Show("Solo se permiten numeros");
            }
            else
            {
                if (nombreAfiliado.Text != "")
                {
                    query = query + "and t.NRO_AFILIADO LIKE '%" + nombreAfiliado.Text + "%'";
                    grillaProfesional.Columns["SELECCIONAR"].Visible = true;
                }
            }
            Dt = Conexion.executeQuery(query);

            grillaProfesional.DataSource = Dt;

        }

        private void buscarHorario_Click(object sender, EventArgs e)
        {
            LlenarTurnos();
        }

        private void limpiarGrilla_Click(object sender, EventArgs e)
        {
            grillaProfesional.DataSource = "";
            nombreAfiliado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean llegoEnHorario(DateTime horaTurno)
        {
            Boolean rta = false;
            if (horaTurno.Hour >= horaLlegada.Hours)
            {
                if (horaLlegada.CompareTo(horaTurno.TimeOfDay) < 0) { rta = true; }

                System.Console.WriteLine("entro aca");

            }

            return rta;
        }

        public bool existeAfiliado()
        {
            ConnectorClass con = ConnectorClass.Instance;

            String query3 = "select * from HARDWELL.AFILIADO a where a.NRO_AFILIADO=" + nombreAfiliado.Text;

            DataTable dt2 = con.executeQuery(query3);

            if (dt2.Rows.Count > 0) { return true; } else { return false; }
        }

        private void grillaProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime horaDelTurno = DateTime.Parse(grillaProfesional.CurrentRow.Cells[3].Value.ToString());
            if ((grillaProfesional.Rows.Count > 0) && (grillaProfesional.Columns[e.ColumnIndex].HeaderText == "Seleccionar") && llegoEnHorario(horaDelTurno))
            {
                if (existeAfiliado())
                {
                    ConnectorClass con = ConnectorClass.Instance;

                    String query3 = "SELECT TOP 1 bc.ID_BONO_CONSULTA FROM HARDWELL.BONO_CONSULTA as bc inner join HARDWELL.COMPRA_BONO_CONSULTA as cbc on (bc.ID_BONO_CONSULTA=cbc.ID_BONO_CONSULTA) WHERE CBC.NRO_AFILIADO=" + nombreAfiliado.Text + "AND BC.NUMERO_CONSULTA is NULL";

                    DataTable dt2 = con.executeQuery(query3);

                    if (dt2.Rows.Count > 0) //si tiene bonos 
                    {
                        String idTurno = grillaProfesional.CurrentRow.Cells[1].Value.ToString();
                        String fechaConsulta = grillaProfesional.CurrentRow.Cells[2].Value.ToString();

                        String query = "insert into  HARDWELL.CONSULTA_MEDICA (ID_TURNO,FECHA_CONSULTA,HORA_LLEGADA,HORA_INICIO) values ('" + idTurno + "','" + fechaConsulta + "', '" + horaLlegada + "' ,'" + horaDelTurno + "')";

                        con.executeQuery(query);

                        String query2 = "select cm.NUMERO_CONSULTA from HARDWELL.CONSULTA_MEDICA as cm where cm.ID_TURNO=" + idTurno;

                        DataTable dt = con.executeQuery(query2);

                        String nroConsulta = dt.Rows[0].ItemArray[0].ToString();

                        String idBono = dt2.Rows[0].ItemArray[0].ToString();
                        String query4 = "update HARDWELL.BONO_CONSULTA set NUMERO_CONSULTA=" + nroConsulta + "where ID_BONO_CONSULTA=" + idBono;
                        con.executeQuery(query4);

                        MessageBox.Show("Consulta creda exitosamente");

                        LlenarTurnos();
                    }
                    else
                    {

                        MessageBox.Show("compre bono");
                    }
                }
                else
                {
                    MessageBox.Show("Numero de Afiliado Invalido");
                }

            }
            else
            {
                MessageBox.Show("El turno esta perdido, llego tarde");
            }
        }

        public static String convertDate()
        {
            String fechaAconvertir = ConfigurationManager.AppSettings["fechaSistema"];

            String year = fechaAconvertir.Substring(1, 4);
            String month = fechaAconvertir.Substring(5, 2);
            String day = fechaAconvertir.Substring(7, 2);
            String time = fechaAconvertir.Substring(10, 8);

            String convertedDate = year + '/' + month + '/' + day + ' ' + time;
            return convertedDate;

        }
    }
}