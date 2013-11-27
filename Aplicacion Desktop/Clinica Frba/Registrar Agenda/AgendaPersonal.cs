using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class Agenda : Form
    {
        DateTime HORA_FIN;
        DateTime HORA_INICIO;
        DateTime fDesde;
        DateTime fHasta;
        int horasW = 0;
        int horaspre48 = 0;
        int nroDia;
        Decimal minutosDesde = -1;
        Decimal minutosHasta = -1;
        Decimal horaDesde;
        Decimal horaHasta;
        Boolean todOk = true;
        public string quienEs;

        public string idProfesionalLogueado;

        // 1 ocupado
        struct diaAgenda
        {
            public int nroDia;
            public DateTime inicio;
            public DateTime fin;
            public int ocupado;
        }

        diaAgenda[] dias = new diaAgenda[8];

        public static DataTable AgregarRubrosAlComboBox()
        {

            ConnectorClass Conexion = ConnectorClass.Instance;
            DataTable Dt;
            Dt = Conexion.executeQuery("select DIA_NOMBRE, DIA_ID from BUGDEVELOPING.DIA where DIA_ID <> 7");
            return Dt;

        }

        public Boolean agregoTodosLosDias()
        {
            int nro = 0;
            foreach (diaAgenda dia in dias)
            {
                if (dia.ocupado == 1)
                {
                    nro++;
                }
            }
            if (nro == 5) { return true; } else { return false; }
        }

        public Boolean sinDatosVacios()
        {

            if (fDesde.ToString() == "" | fHasta.ToString() == "" |
                minutosDesde == -1 | minutosHasta == -1) { MessageBox.Show("Datos Vacios"); return false; }
            else { return true; }

        }
        public Boolean horarioSabado()
        {
            Boolean rta = false;

            if (hrsDesde.Value >= 10 && hrsHasta.Value <= 15)
            {
                if (minutosHasta == 30 && hrsHasta.Value == 15)
                {
                    rta = false;

                }
                else { rta = true; }
            }
            else { rta = false; }

            return rta;
        }

        public void validarFechas()
        {
            if (fHasta.CompareTo(fDesde) > 0)
            {
                TimeSpan t = new TimeSpan();
                t = fHasta - fDesde;
                if (t.Days <= 120) { seleccionarFechaHasta.Enabled = false; }
                else { MessageBox.Show("No se puede superar los 120 dias"); }
            }
            else { MessageBox.Show("Fecha incorrecta"); }


        }


        public void armarHoras()
        {
            horaDesde = hrsDesde.Value;
            horaHasta = hrsHasta.Value;
            minutosDesde = System.Convert.ToDecimal(comboBoxMinutosDesde.SelectedItem.ToString());
            minutosHasta = System.Convert.ToDecimal(comboBoxMinutosHasta.SelectedItem.ToString());

            HORA_INICIO = new DateTime(2001, 01, 01, (int)horaDesde, (int)minutosDesde, 0);
            HORA_FIN = new DateTime(2001, 01, 01, (int)horaHasta, (int)minutosHasta, 0);
        }

        public int horasTrabajadas()
        {

            TimeSpan difHoras = HORA_FIN - HORA_INICIO;

            return (difHoras.Hours);
        }

        public Agenda()
        {
            InitializeComponent();
            finalizar.Enabled = false;
        }

        private void Agenda_Load_1(object sender, EventArgs e)
        {
            if (quienEs != "Administrador del Sistema")
            {
                agregarProfesional.Enabled = false;
                nroProfesional.Enabled = false;

            }
            else
            {
                AgregarDia.Enabled = false;
                comboBoxDias.Enabled = false;
                comboBoxMinutosDesde.Enabled = false;
                comboBoxMinutosHasta.Enabled = false;
                seleccionarFechaDesde.Enabled = false;
                hrsDesde.Enabled = false;
                hrsHasta.Enabled = false;

            }
            DataTable DtRubros;
            //Lleno el Combo Box de Rubros
            DtRubros = AgregarRubrosAlComboBox();
            comboBoxDias.DataSource = DtRubros;
            comboBoxDias.DisplayMember = "DIA_NOMBRE";
            comboBoxDias.ValueMember = "DIA_ID";
            comboBoxDias.Enabled = true;

            seleccionarFechaHasta.Enabled = false;

        }

        private void AgregarDia_Click(object sender, EventArgs e)
        {
            todOk = true;
            armarHoras();
            if (sinDatosVacios())
            {
                if (HORA_FIN > HORA_INICIO)
                {
                    System.Console.WriteLine("horas Laburadas: {0}", horasW);
                    horaspre48 = horasW;
                    horasW = horasTrabajadas() + horasW;
                    System.Console.WriteLine("obtenidos los datos: {0}", horasW);

                    if (horasW < 48)
                    {

                        String id_dia = comboBoxDias.SelectedValue.ToString();
                        String y = HORA_INICIO.ToString();
                        String z = HORA_FIN.ToString();

                        System.Console.WriteLine("se elijio el dia: {0}", id_dia);

                        nroDia = (int)System.Convert.ToDecimal(comboBoxDias.SelectedValue.ToString());

                        System.Console.WriteLine("desde {0}:{1}", horaDesde, minutosDesde);
                        System.Console.WriteLine("hasta {0}:{1}", horaHasta, minutosHasta);

                        System.Console.WriteLine("Desde: {0}", fDesde);
                        System.Console.WriteLine("Hasta: {0}", fHasta);

                        TimeSpan dif = fHasta - fDesde;
                        int diferenciaDias = dif.Days;

                        System.Console.WriteLine("La diferencia en dias es: {0}", diferenciaDias);

                        //si ya selecciono ese dia
                        if (dias[nroDia].ocupado == 1)
                        {
                            MessageBox.Show("Ya se selecciono horario para ese dia");
                            todOk = false;
                        }



                        if (diferenciaDias > 120)
                        {
                            MessageBox.Show("Vuelva a Seleccionar Las Fechas");
                            todOk = false;
                        }


                        if (id_dia == "6" && !horarioSabado())
                        {
                            MessageBox.Show("Horario de atencion invalido");
                            todOk = false;
                        }


                        if (horaHasta == 20 && minutosHasta == 30 && comboBoxDias.SelectedValue.ToString() != "6") { MessageBox.Show("Vuelva a elegir el horario final"); todOk = false; }

                        if (agregoTodosLosDias()) { AgregarDia.Enabled = false; }

                        //  if (HORA_FIN < HORA_INICIO) { MessageBox.Show("Vuelva a elegir el horario "); todOk = false; }

                        //UNA VEZ QUE PASA LAS VALIDACIONES 

                        if (todOk)
                        {
                            System.Console.WriteLine("entre");
                            //System.Console.WriteLine("Hasta: {0}",fHasta);
                            dias[nroDia].nroDia = nroDia;
                            dias[nroDia].inicio = HORA_INICIO;
                            dias[nroDia].fin = HORA_FIN;
                            dias[nroDia].ocupado = 1;

                            System.Console.WriteLine("Hasta: {0}{1}{2}{3}", nroDia, HORA_INICIO, HORA_FIN, dias[nroDia].ocupado);
                            finalizar.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("supero las 48 hrs semanales");
                        horasW = horaspre48;
                    }
                }
            }

        }

        private void seleccionarFechaDesde_Click(object sender, EventArgs e)
        {
            fDesde = monthCalendar1.SelectionStart;

            if (fDesde.DayOfWeek.ToString() == "Sunday")
            {
                MessageBox.Show("Elija otro dia");
                todOk = false;
            }
            else
            {

                seleccionarFechaDesde.Enabled = false;
                seleccionarFechaHasta.Enabled = true;

            }


        }

        private void seleccionarFechaHasta_Click(object sender, EventArgs e)
        {
            fHasta = monthCalendar1.SelectionStart;

            if (fHasta.DayOfWeek.ToString() == "Sunday")
            {
                MessageBox.Show("Elija otro dia");
                todOk = false;
            }
            else
            {

                validarFechas();

            }

        }


        private void monthCalendar1_DateChanged_2(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AHORA NO VOY A TENER MAS ID_AGENDA, DIRECTAMENTE VA A SER EL ID_PROFESIONAL
            ConnectorClass con = ConnectorClass.Instance;

            ////SACO ESTE
            //DataTable nroIdAgenda = con.executeQuery("select top 1 a.ID_AGENDA from HARDWELL.AGENDA as a order by a.ID_AGENDA DESC");


            //      //Si no habia ningun id en la tabla      
            // if (nroIdAgenda.Rows.Count == 0)
            //{
            //    con.executeQuery("insert into HARDWELL.AGENDA (ID_AGENDA,ID_PROFESIONAL,FECHA_DESDE,FECHA_HASTA) values (1, '" + idProfesionalLogueado + "','" + fDesde + "','" + fHasta + "') ");

            //    foreach (diaAgenda dia in dias)
            //    {

            //        if (dia.ocupado == 1)
            //        {
            //            con.executeQuery("insert into HARDWELL.AGENDA_DIA (ID_AGENDA,ID_DIA,HORA_INICIO,HORA_FIN) values (1 ,'" + dia.nroDia + "','" + dia.inicio + "','" + dia.fin + "') ");
            //        }
            //    }
            //}
            //else
            //{
            //    panchu = (int)System.Convert.ToDecimal(nroIdAgenda.Rows[0].ItemArray[0].ToString());

            //    panchu = panchu + 1;

            //    con.executeQuery("insert into HARDWELL.AGENDA (ID_AGENDA,ID_PROFESIONAL,FECHA_DESDE,FECHA_HASTA) values ('" + panchu + "', '" + idProfesionalLogueado + "','" + fDesde + "','" + fHasta + "') ");

            //    foreach (diaAgenda dia in dias)
            //    {

            //        if (dia.ocupado == 1)
            //        {
            //            con.executeQuery("insert into HARDWELL.AGENDA_DIA (ID_AGENDA,ID_DIA,HORA_INICIO,HORA_FIN) values ('" + panchu + "' ,'" + dia.nroDia + "','" + dia.inicio + "','" + dia.fin + "') ");
            //        }
            //    }                            
            //}

            // PRIMERO LO METE EN LA AGENDA

            con.executeQuery("insert into BUGDEVELOPING.AGENDA_PERSONAL (AG_MEDICO, AG_DESDE_DIA, AG_HASTA_DIA) values ('" + idProfesionalLogueado + "','" + fDesde + "','" + fHasta + "') ");

            //AGENDA DIA

            //'" + idProfesionalLogueado + "'

            DataTable idAgenda = con.executeQuery("select top 1 AG_MEDICO from BUGDEVELOPING.AGENDA_PERSONAL WHERE AG_MEDICO = '" + idProfesionalLogueado + "' order by 1 DESC");

            String id = idAgenda.Rows[0].ItemArray[0].ToString();


            foreach (diaAgenda dia in dias)
            {

                if (dia.ocupado == 1)
                {
                    con.executeQuery("insert into BUGDEVELOPING.AGENDA_DIA (AGD_AG_MEDICO, AGD_DIA_ID, AGD_HORA_INICIO, AGD_HORA_FIN) values ('" + id + "','" + dia.nroDia + "','" + dia.inicio + "','" + dia.fin + "') ");
                }
            }

            MessageBox.Show("Agenda Creada Exitosamente");
            finalizar.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

        private void agregarProfesional_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(nroProfesional.Text, out result))
            {
                nroProfesional.Text = "";
                MessageBox.Show("Solo se permiten numeros");
            }
            else
            {
                idProfesionalLogueado = nroProfesional.Text;

                ConnectorClass con = ConnectorClass.Instance;
                // String validacion = "select * from HARDWELL.AGENDA as d where d.ID_PROFESIONAL=" + nroProfesional.Text;
                String validacion2 = "select * from BUGDEVELOPING.MEDICO as d where d.ME_PERSONA=" + nroProfesional.Text;
                // DataTable data = new DataTable();
                DataTable data2 = new DataTable();

                data2 = con.executeQuery(validacion2);
                //data = con.executeQuery(validacion);

                //Valida que no tenga agenda
                //Valida que exista el profesional
                if (data2.Rows.Count != 0)
                {
                    agregarProfesional.Enabled = false;
                    nroProfesional.Enabled = false;
                    AgregarDia.Enabled = true;
                    comboBoxDias.Enabled = true;
                    comboBoxMinutosDesde.Enabled = true;
                    comboBoxMinutosHasta.Enabled = true;
                    seleccionarFechaDesde.Enabled = true;
                    hrsDesde.Enabled = true;
                    hrsHasta.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El profesional elegido no existe");
                }


            }
        }
    }
}
