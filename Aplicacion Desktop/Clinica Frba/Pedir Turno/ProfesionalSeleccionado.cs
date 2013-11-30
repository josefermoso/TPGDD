using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class ProfesionalSeleccionado : Form
    {
        List<DateTime> listaDeFechas = new List<DateTime>();
        List<Turno> listaDeTurnos = new List<Turno>();
        String diaElegido;
        public String quienEs2;
        public String idAgenda;

        String fechaSistema = Clinica_Frba.Registro_de_LLegada.TurnosDadosProfesional.convertDate();
        DateTime fechaSistemaPosta = DateTime.Parse(Clinica_Frba.Registro_de_LLegada.TurnosDadosProfesional.convertDate());
        ConnectorClass Conexion = ConnectorClass.Instance;

        public string idProfesional;
        public string idPaciente2;

        DateTime fechaElegida;

        int a;

        public int idPaciente;
        public ProfesionalSeleccionado()
        {
            InitializeComponent();
        }

        public void generarComboboxFechas()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Fecha_String");
            dt2.Columns.Add("Fecha_Valor");

            listaDeFechas = listaDeFechas.Distinct().ToList();
            DateTime[] fechas = listaDeFechas.ToArray();

            for (int m = 0; m < listaDeFechas.Count; m++)
            {
                DataRow dr2 = dt2.NewRow();
                dr2[0] = fechas[m].ToString();
                dr2[1] = fechas[m].Date;


                dt2.Rows.Add(dr2);
            }

            fechasDisponibles.DataSource = dt2;
            fechasDisponibles.DisplayMember = "Fecha_String";
            fechasDisponibles.ValueMember = "Fecha_Valor";

            listaDeFechas = null;
            listaDeFechas = new List<DateTime>();

        }


        private void InfoProfesionalSeleccionado_Load(object sender, EventArgs e)
        {
            if (quienEs2 != "Administrador del Sistema")
            {
                agregarAfiliado.Enabled = false;
                numeroDeAfiliado.Enabled = false;
            }
            else
            {
                agregarAfiliado.Enabled = true;
                numeroDeAfiliado.Enabled = true;
                diasDeLaSemana.Enabled = false;
                buscarHorario.Enabled = false;
                limpiarGrilla.Enabled = false;
                fechasDisponibles.Enabled = false;
            }

            AgregarFechasALaLista();
            generarComboboxFechas();

            ConnectorClass Conexion = ConnectorClass.Instance;
            DataTable Dt;
            Dt = Conexion.executeQuery("select distinct DIA_NOMBRE, DIA_ID from BUGDEVELOPING.AGENDA_PERSONAL inner join BUGDEVELOPING.AGENDA_DIA on (AG_CODIGO = AGD_AG_CODIGO) inner join BUGDEVELOPING.DIA on (AGD_DIA_ID = DIA_ID) where AG_MEDICO = " + idProfesional + "and DIA_ID != 7");

            diasDeLaSemana.DataSource = Dt;
            diasDeLaSemana.DisplayMember = "DIA_NOMBRE";
            diasDeLaSemana.ValueMember = "DIA_ID";

            diasDeLaSemana.SelectedItem = null;
            fechasDisponibles.SelectedItem = null;
        }

        public Boolean estaEnLaAgenda(DateTime fecha)
        {
            int nroDia = buscarIdDia(fecha.DayOfWeek.ToString());

            DataTable Dt;
            Dt = Conexion.executeQuery("select * from BUGDEVELOPING.AGENDA_DIA inner join BUGDEVELOPING.AGENDA_PERSONAL  on (AGD_AG_CODIGO = AG_CODIGO) where AGD_DIA_ID=" + nroDia + "and AG_MEDICO = " + idProfesional);
            
            if (Dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AgregarFechasALaLista()
        {
            DataTable Dt;
            Dt = Conexion.executeQuery("select distinct AG_DESDE_DIA, AG_HASTA_DIA from BUGDEVELOPING.AGENDA_DIA inner join BUGDEVELOPING.AGENDA_PESONAL on (AG_CODIGO = AGD_AG_CODIGO) where  AG_MEDICO =" + idProfesional);
            
            for (int j = 0; j < Dt.Rows.Count; j++)
            {
                DateTime fechaDesde = (DateTime)Dt.Rows[j].ItemArray[0];
                DateTime fechaHasta = (DateTime)Dt.Rows[j].ItemArray[1];
                DateTime aux = fechaDesde;

                //El primero lo agrego directo
                //TIENE que estar en la agenda y 
                if (estaEnLaAgenda(fechaDesde) && fechaSistemaPosta.CompareTo(fechaDesde) < 0)
                {

                    if (buscarIdDia(fechaDesde.DayOfWeek.ToString()).ToString() == diaElegido)
                    {
                        System.Console.WriteLine("agrego {0}", fechaDesde);
                        listaDeFechas.Add(fechaDesde);

                    }

                }

                while (fechaDesde.CompareTo(fechaHasta) != 0)
                {
                    fechaDesde = fechaDesde.AddDays(1);

                    if (estaEnLaAgenda(fechaDesde) && fechaSistemaPosta.CompareTo(fechaDesde) < 0)
                    {
                        if (buscarIdDia(fechaDesde.DayOfWeek.ToString()).ToString() == diaElegido)
                        {
                            System.Console.WriteLine("agrego {0}", fechaDesde);
                            listaDeFechas.Add(fechaDesde);
                        }
                    }

                }
                Dt = Conexion.executeQuery("select distinct AG_DESDE_DIA, AG_HASTA_DIA from BUGDEVELOPING.AGENDA_DIA inner join BUGDEVELOPING.AGENDA_PESONAL on (AG_CODIGO = AGD_AG_CODIGO) where  AG_MEDICO =" + idProfesional);
            }
        }

        public int buscarIdDia(String dia)
        {

            if (dia == "Monday" || dia == "LUNES") { a = 1; }
            if (dia == "Tuesday" || dia == "MARTES") { a = 2; }
            if (dia == "Wednesday" || dia == "MIERCOLES") { a = 3; }
            if (dia == "Thursday" || dia == "JUEVES") { a = 4; }
            if (dia == "Friday" || dia == "VIERNES") { a = 5; }
            if (dia == "Saturday" || dia == "SABADO") { a = 6; }

            return a;
        }

        public Boolean estaDisponible(TimeSpan horaComienzo)
        {
            ConnectorClass con = ConnectorClass.Instance;

            fechaElegida = DateTime.Parse(fechasDisponibles.SelectedValue.ToString());
            //PROBLEMA CON FECHA Y HORA PARA CONSULTAR  

            string val = String.Format("{0:yyyy-MM-dd}", fechaElegida); //t.nro_afiliado=" + idPaciente2 + "
            DataTable horasDeInicio = con.executeQuery("select T_HORA, T_FECHA from BUGDEVELOPING.TURNO as t where T_MEDICO = " + idProfesional + "AND T_FECHA = '" + val + "' order by T_HORA ASC");

            for (int i = 0; i < horasDeInicio.Rows.Count; i++)
            {
                TimeSpan s = DateTime.Parse(horasDeInicio.Rows[i].ItemArray[0].ToString()).TimeOfDay;
                DateTime d = DateTime.Parse(horasDeInicio.Rows[i].ItemArray[1].ToString());
                System.Console.WriteLine(s.ToString());
                if (s == horaComienzo && d == fechaElegida) { return false; }
            }
            return true;
        }

        public void mostrarTodosLosHorariosDisponiblesSegunFecha()
        {
            //COMO ES MAS DE UNO TENGO QUE SABER PARA QUE AGENDA ES!
            listaDeTurnos = null;
            listaDeTurnos = new List<Turno>();

            grillaProfesional.Columns["Seleccionar"].Visible = true;

            fechaElegida = DateTime.Parse(fechasDisponibles.SelectedValue.ToString());
            string val = String.Format("{0:yyyy-MM-dd}", fechaElegida);

            ConnectorClass con = ConnectorClass.Instance;
            String nombredia = fechaElegida.DayOfWeek.ToString();
            int idDia = buscarIdDia(nombredia);

            //El problema que ahora puede haber dos horarios para un lunes dependiendo de la agenda
            //Esta es la forma que puede saber que agenda es
            DataTable horario = con.executeQuery("select DISTINCT AGD_HORA_INICIO, AGD_HORA_FIN, AG_CODIGO  from BUGDEVELOPING.AGENDA_DIA inner join BUGDEVELOPING.AGENDA_PERSONAL on (AGD_AG_CODIGO = AG_CODIGO) where AGD_DIA_ID = " + idDia + "and AG_MEDICO =" + idProfesional + "and '" + fechaElegida + "' between AG_DESDE_DIA and AG_HASTA_DIA ");

            //DataTable horario = con.executeQuery("select  h.HORA_INICIO, h.HORA_FIN from hardwell.AGENDA_DIA as h inner join HARDWELL.AGENDA as d on (h.ID_PROFESIONAL=d.ID_PROFESIONAL) where h.ID_DIA=" + idDia + "and d.ID_PROFESIONAL=" + idProfesional);

            TimeSpan f = (TimeSpan)horario.Rows[0].ItemArray[1];
            TimeSpan i = (TimeSpan)horario.Rows[0].ItemArray[0];
            idAgenda = horario.Rows[0].ItemArray[2].ToString();

            TimeSpan diferencia = i - f;
            TimeSpan mediaHora = new TimeSpan(0, 0, 30, 0);

            int n = 1;

            while (i.CompareTo(f) != 0)
            {
                //defino las horas de inicio y fin de atencion
                TimeSpan horaInicio = i;
                i = i.Add(mediaHora);
                TimeSpan horaFin = i;

                //armo el turno
                Turno turno = new Turno(n, horaInicio, horaFin, idAgenda, "al pedo");

                System.Console.WriteLine(n);

                System.Console.WriteLine(horaInicio.ToString());

                System.Console.WriteLine(horaFin.ToString());

                //lo agrego a los turnos
                if (estaDisponible(horaInicio))
                {
                    listaDeTurnos.Add(turno);
                }

                n++;
            }


            Turno rr = new Turno();

            Turno[] turnos = listaDeTurnos.ToArray();

            DataTable dt = new DataTable();
            dt.Columns.Add("Numero de Turno");
            dt.Columns.Add("Hora inicio");
            dt.Columns.Add("Hora fin");
            dt.Columns.Add("Id Agenda");
            for (int t = 0; t < listaDeTurnos.Count; t++)
            {
                DataRow dr = dt.NewRow();

                //dr[0] = 1;
                dr[0] = turnos[t].nroTurno;
                dr[1] = turnos[t].inicio;
                dr[2] = turnos[t].fin;
                dr[3] = turnos[t].nroIdAgenda;
                dt.Rows.Add(dr);
            }
            grillaProfesional.DataSource = dt;

            dt.NewRow();


        }

        public void mostrarTodosLosHorariosDisponibles()
        {
            grillaProfesional.Columns["Seleccionar"].Visible = false;
            listaDeTurnos = null;
            listaDeTurnos = new List<Turno>();

            ConnectorClass con = ConnectorClass.Instance;

            DataTable horario = con.executeQuery("select AGD_HORA_INICIO, AGD_HORA_FIN, DIA_NOMBRE from BUGDEVELOPING.AGENDA_DIA inner join BUGDEVELOPING.AGENDA_PERSONAL on (AGD_AG_CODIGO = AG_CODIGO) inner join BUGDVELOPING.DIA on (DIA_ID = AGD_DIA_ID) where AG_MEDICO =" + idProfesional);
            // DataTable horario = con.executeQuery("select  h.HORA_INICIO, h.HORA_FIN, dia.NOMBRE from hardwell.AGENDA_DIA as h inner join HARDWELL.AGENDA as d on (h.ID_PROFESIONAL=d.ID_PROFESIONAL) inner join HARDWELL.DIA as dia on (dia.ID_DIA=h.ID_DIA) where d.ID_PROFESIONAL=" + idProfesional);

            int cantDiasAtencion = horario.Rows.Count;

            //Hace esto por cada dia
            for (int k = 0; k < cantDiasAtencion; k++)
            {
                TimeSpan f = (TimeSpan)horario.Rows[k].ItemArray[1];
                TimeSpan i = (TimeSpan)horario.Rows[k].ItemArray[0];
                String nombreDia = horario.Rows[k].ItemArray[2].ToString();

                TimeSpan diferencia = i - f;
                TimeSpan mediaHora = new TimeSpan(0, 0, 30, 0);

                int n = 1;

                while (i.CompareTo(f) != 0)
                {
                    //defino las horas de inicio y fin de atencion
                    TimeSpan horaInicio = i;
                    i = i.Add(mediaHora);
                    TimeSpan horaFin = i;

                    //armo el turno
                    Turno turno = new Turno(n, horaInicio, horaFin, nombreDia);

                    //lo agrego a los turnos
                    listaDeTurnos.Add(turno);


                    n++;
                }
            }

            Turno rr = new Turno();

            Turno[] turnos = listaDeTurnos.ToArray();

            DataTable dt = new DataTable();
            dt.Columns.Add("Dia");
            dt.Columns.Add("Numero de Turno");
            dt.Columns.Add("Hora inicio");
            dt.Columns.Add("Hora fin");
            for (int t = 0; t < listaDeTurnos.Count; t++)
            {
                DataRow dr = dt.NewRow();

                //dr[0] = 1;
                dr[0] = turnos[t].nombreDia;
                dr[1] = turnos[t].nroTurno;
                dr[2] = turnos[t].inicio;
                dr[3] = turnos[t].fin;
                dt.Rows.Add(dr);
            }
            grillaProfesional.DataSource = dt;

            dt.NewRow();



        }

        private void buscarHorario_Click(object sender, EventArgs e)
        {
            if (fechasDisponibles.SelectedItem == null) { mostrarTodosLosHorariosDisponibles(); } else { mostrarTodosLosHorariosDisponiblesSegunFecha(); }

        }

        private void limpiarGrilla_Click(object sender, EventArgs e)
        {
            grillaProfesional.DataSource = "";
            fechasDisponibles.SelectedItem = null;
            listaDeTurnos = null;
            listaDeTurnos = new List<Turno>();
            grillaProfesional.Columns["Seleccionar"].Visible = true;
            diasDeLaSemana.SelectedItem = null;

            //   limpiarGrilla.Enabled = false;

        }

        //NO AGREGA DESDE TODOS LOS HORARIOS
        private void grillaProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((grillaProfesional.Rows.Count > 0) && (grillaProfesional.Columns[e.ColumnIndex].HeaderText == "Seleccionar"))
            {
                ConnectorClass con = ConnectorClass.Instance;

                fechaElegida = DateTime.Parse(fechasDisponibles.SelectedValue.ToString());
                TimeSpan horaElegida = DateTime.Parse(grillaProfesional.CurrentRow.Cells[2].Value.ToString()).TimeOfDay;

                con.executeQuery("insert into BUGDEVELOPING.TURNO (T_AFILIADO, T_MEDICO, T_AGENDA, T_FECHA, T_HORA) values ('" + idPaciente2 + "', '" + idProfesional + "' , '" + idAgenda + "' ,'" + fechaElegida + "', '" + horaElegida + "') ");
                MessageBox.Show("Turno agregado correctamente");
                mostrarTodosLosHorariosDisponiblesSegunFecha();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fechasDisponibles.SelectedItem = null;
            Object zx = diasDeLaSemana.SelectedValue;
            String mer = Convert.ToString(zx);
            System.Console.WriteLine(mer); //System data viw
            diaElegido = mer;

            AgregarFechasALaLista();
            generarComboboxFechas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int result = 0;
            if (!int.TryParse(numeroDeAfiliado.Text, out result))
            {
                numeroDeAfiliado.Text = "";
                MessageBox.Show("Solo se permiten numeros");
            }
            else
            {
                idPaciente2 = numeroDeAfiliado.Text;
                ConnectorClass con = ConnectorClass.Instance;
                string query = "select * from BUGDEVELOPING.PACIENTE where PA_PERSONA = " + idPaciente2;
                DataTable data = new DataTable();

                data = con.executeQuery(query);
                if (data.Rows.Count != 0)
                { //osea el profesional existe
                    agregarAfiliado.Enabled = false;
                    numeroDeAfiliado.Enabled = false;
                    diasDeLaSemana.Enabled = true;
                    buscarHorario.Enabled = true;
                    limpiarGrilla.Enabled = true;
                    fechasDisponibles.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El profesional elegido no existe");
                }
            }
        }
    }
}
