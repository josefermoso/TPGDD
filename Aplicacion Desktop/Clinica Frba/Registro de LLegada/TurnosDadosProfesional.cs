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

namespace Clinica_Frba.Registro_de_LLegada
{
    public partial class TurnosDadosProfesional : Form
    {
        public string idProfesional;

        //DEBERIA SER LA HORA DEL SISTEMA
        //String fyh = convertDate();
        TimeSpan horaLlegada = (DateTime.Parse(Clinica_Frba.Registro_de_LLegada.TurnosDadosProfesional.convertDate())).TimeOfDay;

        public TurnosDadosProfesional()
        {
            InitializeComponent();
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

            String query = "select distinct T_ID,T_FECHA,T_HORA,T_AFILIADO from BUGDEVELOPING.CONSULTA, BUGDEVELOPING.TURNO where not exists (select * from BUGDEVELOPING.CONSULTA where CON_TURNO=T_ID ) and T_MEDICO = '" + idProfesional + "' AND T_FECHA >= '" + val + "'";

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
                    query = query + "and T_AFILIADO LIKE '%" + nombreAfiliado.Text + "%'";
                    if (idBonoAUsar.Text != "")
                    {
                        grillaProfesional.Columns["SELECCIONAR"].Visible = true;
                    }
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
            idBonoAUsar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean llegoEnHorario(TimeSpan horaTurno)
        {
            Boolean rta = false;

            if(horaTurno.Hours>=horaLlegada.Hours){
            
                if (horaLlegada.CompareTo(horaTurno) < 0) { rta = true; }

                System.Console.WriteLine("entro aca");

            }

            return rta;
        }

        public bool existeAfiliado()
        {
            //VALIDA EXISTENCIA Y HABILITACION 
            ConnectorClass con = ConnectorClass.Instance;

            String query3 = "select * from BUGDEVELOPING.PACIENTE where PA_NAFILIADO=" + nombreAfiliado.Text + "and PA_ACTIVO=1";

            DataTable dt2 = con.executeQuery(query3);

            if (dt2.Rows.Count > 0) { return true; } else { return false; }
        }
        public String raizDelNroDeUsuario()
        {
            //SUPONE INGRESO PERFECTO
            String nroAfiliadoCompleto = nombreAfiliado.Text;
            int cantCaracteresTotal = nroAfiliadoCompleto.Length;
            String raiz = nroAfiliadoCompleto.Substring(0, cantCaracteresTotal - 2);
            System.Console.WriteLine("La raiz del nro de usuario es: {0}", raiz);
            return raiz;
        }

        public bool existeBonoAUsar()
        {
            ConnectorClass con = ConnectorClass.Instance;

            String raizUsuario = raizDelNroDeUsuario();

            //Valida que exista 
            //Valida que no este usado
            //Valida que pertenezca al usuario o grupo familiar
            //Valida que pertenezca al plan que tiene ahora, por que si cambio los bonos de ese plan quedan obsoletos
            DataTable dt = con.executeQuery("select * from BUGDEVELOPING.BONO_CONSULTA bc join BUGDEVELOPING.BONO on (b_id = BC.BC_BONO_NUMERO) JOIN BUGDEVELOPING.COMPRA_BONO as cbc on (cbc.CB_BONO=bc.BC_BONO_NUMERO) join BUGDEVELOPING.COMPRA on (co_numero = cbc.CB_NUMERO) join BUGDEVELOPING.PACIENTE as a on a.PA_NAFILIADO= CO_AFILIADO  where bc.BC_NUMERO_CONSULTA is NULL and bc.BC_BONO_NUMERO=" + idBonoAUsar.Text + "and CO_AFILIADO LIKE'%" + raizUsuario + "%' and PA_PLAN=B_PLAN"); //cbc.NRO_AFILIADO LIKE '%7429%'

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private void grillaProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TimeSpan horaDelTurno = (TimeSpan) grillaProfesional.CurrentRow.Cells[3].Value;
            if ((grillaProfesional.Rows.Count > 0) && (grillaProfesional.Columns[e.ColumnIndex].HeaderText == "Seleccionar") && llegoEnHorario(horaDelTurno))
            {

                if (existeAfiliado())
                {
                    ConnectorClass con = ConnectorClass.Instance;

                    // String query3 = "SELECT TOP 1 bc.ID_BONO_CONSULTA FROM HARDWELL.BONO_CONSULTA as bc inner join HARDWELL.COMPRA_BONO_CONSULTA as cbc on (bc.ID_BONO_CONSULTA=cbc.ID_BONO_CONSULTA) WHERE CBC.NRO_AFILIADO=" + nombreAfiliado.Text + "AND BC.NUMERO_CONSULTA is NULL";

                    //   DataTable dt2 = con.executeQuery(query3);

                    if (idBonoAUsar.Text != "" && existeBonoAUsar()) //si tiene bonos 
                    {
                        String idTurno = grillaProfesional.CurrentRow.Cells[1].Value.ToString();
                        DateTime fechaConsulta = (DateTime)grillaProfesional.CurrentRow.Cells[2].Value;
 
                        //String patternInsertarTurno = "INSERT INTO HARDWELL.TURNO (NRO_AFILIADO, ID_PROFESIONAL, ID_AGENDA, FECHA, HORA) VALUES ({0},{1},{2},CONVERT(DATE,'{3}',112),CONVERT(TIME,'{4}',112))";
                        //String queryInsertarTurno = String.Format(patternInsertarTurno, idAfiliado, idProfesional, idAgenda, fecha.ToString("yyyyMMdd"), hora);
                        //con.executeQuery(queryInsertarTurno);
                              
                        //TOQUE ACA Y ARREGLE !! 
                        String patternInsertarConsulta = "insert into  BUGDEVELOPING.CONSULTA (ID_TURNO,FECHA_CONSULTA,HORA_LLEGADA,HORA_INICIO) values ({0},CONVERT(DATE,'{1}',112),CONVERT(TIME,'{2}',112),CONVERT(TIME,'{3}',112))";
                        String query = String.Format(patternInsertarConsulta, idTurno, fechaConsulta.ToString("yyyyMMdd"), horaLlegada, horaDelTurno);
                        //" values ('" + idTurno + "','" + fechaConsulta + "', '" + horaLlegada + "' ,'" + horaDelTurno + "')";
                        con.executeQuery(query);

                        String query2 = "select CON_NUMERO from BUGDEVELOPING.CONSULTA where CON_TURNO=" + idTurno;

                        DataTable dt = con.executeQuery(query2);

                        String nroConsulta = dt.Rows[0].ItemArray[0].ToString();

                        //String idBono = dt2.Rows[0].ItemArray[0].ToString();
                        String query4 = "update BUGDEVELPING.BONO_CONSULTA set BC_NUMERO_CONSULTA=" + nroConsulta + "where BC_BONO_NUMERO=" + idBonoAUsar.Text;
                        con.executeQuery(query4);

                        MessageBox.Show("Consulta creda exitosamente");

                        LlenarTurnos();
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Coloque el nro de bono a usar correcto");
                        LlenarTurnos();
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
