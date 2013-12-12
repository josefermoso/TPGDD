using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using Clinica_Frba.Abm_de_Profesional;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class RegistroAgenda : Form
    {
        long idProfesional = 0;
        List<RegistrarDia> diasSeleccionados = new List<RegistrarDia>();

        public RegistroAgenda()
        {
            InitializeComponent();
        }

        public RegistroAgenda(long id)
        {
            InitializeComponent();
            idProfesional = id;
            info.Text = "A continuación, elija los días y horarios en los que usted atenderá:";
            nombreProfesional.Text = String.Format("ID:{0}", idProfesional);
            seleccionarProfesional.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarProfesional_Click(object sender, EventArgs e)
        {
            SeleccionProfesional window = new SeleccionProfesional();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                idProfesional = long.Parse(window.selected.Cells["ID_PROFESIONAL"].Value.ToString());
                nombreProfesional.Text = String.Format("ID:{0} ({2} {1})", window.selected.Cells["ID_PROFESIONAL"].Value.ToString(), window.selected.Cells["NOMBRE"].Value.ToString(), window.selected.Cells["APELLIDO"].Value.ToString());
            }
        }

        private void agregarDia_Click(object sender, EventArgs e)
        {
            RegistrarDia window = new RegistrarDia();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                System.Diagnostics.Debug.WriteLine(String.Format("Agregó el día {0} y horario {1} a {2}", window.diaSeleccionadoNombre, window.horaDesdeSeleccionada, window.horaHastaSeleccionada));

                //Valido que las horas acumuladas sean menores a 48
                int horasAcumuladas = 0;
                TimeSpan horarioInicio = TimeSpan.Parse(window.horaDesdeSeleccionada);
                TimeSpan horarioFin = TimeSpan.Parse(window.horaHastaSeleccionada);
                horasAcumuladas = horasAcumuladas + horarioFin.Subtract(horarioInicio).Hours;
                foreach (RegistrarDia rd in diasSeleccionados)
                {
                    horarioInicio = TimeSpan.Parse(rd.horaDesdeSeleccionada);
                    horarioFin = TimeSpan.Parse(rd.horaHastaSeleccionada);
                    horasAcumuladas = horasAcumuladas + horarioFin.Subtract(horarioInicio).Hours;
                }

                System.Diagnostics.Debug.WriteLine(String.Format("La cantidad total de horas acumuladas es {0}.", horasAcumuladas));

                if (horasAcumuladas >= 48)
                {
                    MessageBox.Show("No se puede cargar el día ya que las horas acumuladas sobrepasan el límite de 48 hs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Valido si el día que cargó ya lo había cargado, lo reemplazo (Esto me ahorra tener que hacer una opción de MODIFICAR
                foreach (RegistrarDia w in diasSeleccionados)
                {
                    int d = w.diaSeleccionado;
                    if (d.Equals(window.diaSeleccionado))
                    {
                        diasSeleccionados.Remove(w);
                        break;
                    }
                }
                diasSeleccionados.Add(window);
                actualizarListaDeDiasAgregados();
            }
        }

        private void actualizarListaDeDiasAgregados()
        {
            diasAgregados.Items.Clear();
            foreach (RegistrarDia dia in diasSeleccionados)
            {
                diasAgregados.Items.Add(String.Format("{0} {1} a {2}", dia.diaSeleccionadoNombre, dia.horaDesdeSeleccionada, dia.horaHastaSeleccionada));
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (idProfesional.Equals(0L))
            {
                MessageBox.Show("Debe seleccionar un profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (diasSeleccionados.Count.Equals(0))
            {
                MessageBox.Show("No agregó ningún día a la agenda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (fechaDesde.Value.CompareTo(fechaHasta.Value) >= 0)
            {
                MessageBox.Show("La fecha de fin de la agenda no puede ser anterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (fechaDesde.Value.AddDays(120).CompareTo(fechaHasta.Value) < 0)
            {
                MessageBox.Show("La agenda no puede tener un período ´mayor a 120 días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ConnectorClass con = ConnectorClass.Instance;
            String query;

            String patternValidarFecha = "SELECT COUNT(AG_CODIGO) FROM BUGDEVELOPING.AGENDA_PERSONAL WHERE AG_MEDICO = {0} AND AG_HASTA_DIA > CONVERT(DATETIME, '{1}' ,112);";
            query = String.Format(patternValidarFecha, idProfesional, fechaDesde.Value.ToString("yyyyMMdd"));
            System.Diagnostics.Debug.WriteLine(query);
            int agendasEnEsaFecha = (int)con.executeQueryEscalar(query);
            if (!agendasEnEsaFecha.Equals(0))
            {
                MessageBox.Show("El profesional ya tiene una agenda y el rango de fechas de la misma se superpone con la actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //############### Pasó todas las validaciones, ya puedo insertar la agenda.
            System.Diagnostics.Debug.WriteLine("### Insertando agenda..");
            String patternInsertarAgenda = "INSERT INTO BUGDEVELOPING.AGENDA_PERSONAL (AG_MEDICO, AG_DESDE_DIA, AG_HASTA_DIA) VALUES ({0},CONVERT(DATETIME,'{1}',112),CONVERT(DATETIME,'{2}',112))";
            query = String.Format(patternInsertarAgenda, idProfesional, fechaDesde.Value.ToString("yyyyMMdd"), fechaHasta.Value.ToString("yyyyMMdd"));
            System.Diagnostics.Debug.WriteLine(query);
            con.executeQuery(query);

            String patternInsertarAgendaDia = "INSERT INTO BUGDEVELOPING.AGENDA_DIA (AGD_DIA_ID, AGD_HORA_INICIO, AGD_HORA_FIN, AGD_AG_CODIGO) VALUES ({0},CONVERT(TIME,'{1}',112),CONVERT(TIME,'{2}',112), (SELECT TOP 1 AG_CODIGO FROM BUGDEVELOPING.AGENDA_PERSONAL WHERE AG_MEDICO = {3} ORDER BY 1 DESC));";
            foreach (RegistrarDia dia in diasSeleccionados)
            {
                System.Diagnostics.Debug.WriteLine("### Insertando día..");
                query = String.Format(patternInsertarAgendaDia, dia.diaSeleccionado, dia.horaDesdeSeleccionada, dia.horaHastaSeleccionada, idProfesional);
                System.Diagnostics.Debug.WriteLine(query);
                con.executeQuery(query);
            }

            MessageBox.Show("La agenda fué generada correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }
    }
}
