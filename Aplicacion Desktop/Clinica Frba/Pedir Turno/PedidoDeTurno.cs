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
using Clinica_Frba.Abm_de_Afiliado;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class PedidoDeTurno : Form
    {
        
        public PedidoDeTurno()
        {
            InitializeComponent();
        }

        public PedidoDeTurno(long idAf)
        {
            InitializeComponent();
            idAfiliado = idAf;
            info.Text = "A continuación seleccione el profesional y el día y horario del turno:";
            afiliadoLabel.Text = String.Format("NRO:{0}", idAfiliado);
            seleccionarAfiliado.Visible = false;
        }

        private long idProfesional = 0;
        private long idAgenda = 0;
        private long idAfiliado = 0;
        private long idEspecialidad = 0;

        private void seleccionarProfesional_Click(object sender, EventArgs e)
        {
            SeleccionProfesionalPorEspecialidad window = new SeleccionProfesionalPorEspecialidad();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                profesionalLabel.Text = String.Format("ID:{0} ({2} {1})", window.selected.Cells["ID_PROFESIONAL"].Value.ToString(), window.selected.Cells["NOMBRE"].Value.ToString(), window.selected.Cells["APELLIDO"].Value.ToString());
                idProfesional = long.Parse(window.selected.Cells["ID_PROFESIONAL"].Value.ToString());
                idAgenda = long.Parse(window.selected.Cells["AGENDA"].Value.ToString());
                idEspecialidad = window.idEspecialidad;
            }
        }

        private void seleccionarAfiliado_Click(object sender, EventArgs e)
        {
            SeleccionAfiliado window = new SeleccionAfiliado();
            DialogResult resultSeleccion = window.ShowDialog();
            if (resultSeleccion == DialogResult.OK)
            {
                idAfiliado = long.Parse(window.selected.Cells["PA_NAFILIADO"].Value.ToString());
                afiliadoLabel.Text = String.Format("NRO:{0} ({2} {1})", window.selected.Cells["PA_NAFILIADO"].Value.ToString(), window.selected.Cells["PE_NOMBRE"].Value.ToString(), window.selected.Cells["PE_APELLIDO"].Value.ToString());
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (idProfesional.Equals(0L))
            {
                MessageBox.Show("No seleccionó ningún profesional. Por favor seleccione uno para poder continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (idAfiliado.Equals(0L))
            {
                MessageBox.Show("No seleccionó ningún afiliado. Por favor seleccione uno para poder continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!turnos.SelectedRows.Count.Equals(1))
            {
                MessageBox.Show("No seleccionó ningún turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ConnectorClass con = ConnectorClass.Instance;
            DateTime fecha = (DateTime)turnos.SelectedRows[0].Cells["FECHA"].Value;
            TimeSpan hora = (TimeSpan)turnos.SelectedRows[0].Cells["HORA"].Value;
            String patternInsertarTurno = "INSERT INTO BUGDEVELOPING.TURNO (T_AFILIADO, T_MEDICO, T_AGENDA, T_FECHA, T_HORA, T_ESPECIALIDAD) VALUES ({0},{1},{2},CONVERT(DATE,'{3}',112),CONVERT(TIME,'{4}',112),{5})";
            String queryInsertarTurno = String.Format(patternInsertarTurno, idAfiliado, idProfesional, idAgenda, fecha.ToString("yyyyMMdd"), hora, idEspecialidad);
            con.executeQuery(queryInsertarTurno);
            MessageBox.Show("El turno fué registrado correctamente.", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (idProfesional.Equals(0L))
            {
                MessageBox.Show("No seleccionó ningún profesional. Por favor, elija uno para poder buscar los turnos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ConnectorClass con = ConnectorClass.Instance;
            String patternTurnos = "SELECT DIA, FECHA, HORA FROM BUGDEVELOPING.BUSCAR_TURNOS_DISPONIBLES({0}, CONVERT(DATE, {1}, 112))";
            String queryTurnos = String.Format(patternTurnos, idAgenda, ConfigurationManager.AppSettings["fechaSistema"]);
            System.Diagnostics.Debug.WriteLine(queryTurnos);
            turnos.DataSource = con.executeQuery(queryTurnos);
            if (turnos.RowCount.Equals(0))
            {
                MessageBox.Show("El profesional seleccionado posee toda su agenda ocupada. Por favor, seleccione otro.", "Sin turnos disponibles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
