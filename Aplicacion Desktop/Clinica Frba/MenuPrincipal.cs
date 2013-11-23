﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba
{
    public partial class MenuPrincipal : Form
    {
        public static string userId;
        public static string rolQueMostrara;
        public static MenuPrincipal menuActivo;

        public MenuPrincipal()
        {
            menuActivo = this;
            InitializeComponent();
        }

        private void cargarFuncionalides(object sender, EventArgs e)
        {
            //this.rolesToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "1");
            //this.afiliadosToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "2");
            //this.profesionalesToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "3");
            //this.cancelarAtenciónToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "9");
            //this.comprarBonosToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "5");
            //this.generarRecetaToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "10");
            //this.generarRecetaToolStripMenuItem.Visible = false;
            //this.pedirTurnosToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "6");
            //this.registrarAgendaDelMédicoToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "4");
            //this.registrarLlegadaDelPacienteToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "7");
            //this.registarResultadoDeLaAtenciónToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "8");
            //this.obtenerEstadísticasToolStripMenuItem.Visible = Clinica_Frba.Abm_de_Rol.FuncionesRol.existeFunEnRol(rolQueMostrara, "11");

        }

        private void comprarBonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectorClass con = ConnectorClass.Instance;
            String validacion = "select r.ROL_NOMBRE from BUDEVELOPING.ROL r, BUGDEVELOPING.USUARIO_ROL ur, BUGDEVELOPING.USUARIO u where u.USUARIO_USERNAME = '" + Clinica_Frba.Login.LoginForm.nombreUsuario + "' and u.USUARIO_ID = ur.USUARIO_ID and r.ROL_ID = ur.ROL_ID";
            DataTable data = new DataTable();
            data = con.executeQuery(validacion);
            if (data.Rows[0][0].ToString() == "Administrativo" || data.Rows[0][0].ToString() == "Administrador del Sistema")
            {
               /* Compra_de_Bono.BonosAministrativo frmBonoAdm = new Compra_de_Bono.BonosAministrativo();
                frmBonoAdm.Show();
                this.Hide();*/
            }
            if (data.Rows[0][0].ToString() == "Afiliado")
            {
                /*Compra_de_Bono.BonosAfiliado frmBonoAfil = new Clinica_Frba.Compra_de_Bono.BonosAfiliado();
                frmBonoAfil.Show();
                this.Hide();*/
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Abm_de_Rol.FiltrarRol abmRol = new Clinica_Frba.Abm_de_Rol.FiltrarRol();
            abmRol.Show();
            this.Hide();
        }

        private void buttonCAMBIAR_rol_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Login.ElegirRol.electorRolActivo.Show();
            this.Close();
        }

        private void afiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Clinica_Frba.Abm_de_Profesional.MenuProfesional()).Show();
        }

        private void cancelarAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectorClass con = ConnectorClass.Instance;
            String validacion = "select r.nombre from HARDWELL.ROL r, HARDWELL.USUARIO_ROL ur, HARDWELL.USUARIO u where u.USERNAME = '" + Clinica_Frba.Login.LoginForm.nombreUsuario + "' and u.ID_USUARIO = ur.ID_USUARIO and r.ID_ROL = ur.ID_ROL";
            DataTable data = new DataTable();
            data = con.executeQuery(validacion);
            if (data.Rows[0][0].ToString() == "Profesional")
            {
                /*Cancelar_atencion.CancelacionProf frmCan = new Clinica_Frba.Cancelar_atencion.CancelacionProf();
                frmCan.Show();
                this.Hide();*/
            }
            if (data.Rows[0][0].ToString() == "Afiliado")
            {
                /*Cancelar_atencion.CancelacionAfiliado frmCan = new Clinica_Frba.Cancelar_atencion.CancelacionAfiliado();
                frmCan.Show();

                this.Hide();*/
            }
        }

        private void generarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedirTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConnectorClass con = ConnectorClass.Instance;
            String validacion2 = "select r.nombre from BUGDEVELOPING.ROL r, HARDWELL.USUARIO_ROL ur, HARDWELL.USUARIO u where u.USERNAME = '" + Clinica_Frba.Login.LoginForm.nombreUsuario + "' and u.ID_USUARIO = ur.ID_USUARIO and r.ID_ROL = ur.ID_ROL";
            DataTable data2 = new DataTable();
            data2 = con.executeQuery(validacion2);

            if (data2.Rows[0][0].ToString() == "Administrador del Sistema")
            {
              /*  pedido_turno.buscarProfesional ventanaPedirTurno = new Clinica_Frba.pedido_turno.buscarProfesional();
                ventanaPedirTurno.quienEs = "Administrador del Sistema";
                ventanaPedirTurno.Show();
                this.Hide();*/
            }

            if (data2.Rows[0][0].ToString() == "Afiliado")
            {
                /*pedido_turno.buscarProfesional ventanaPedirTurno = new Clinica_Frba.pedido_turno.buscarProfesional();
                ventanaPedirTurno.idPaciente = userId;
                ventanaPedirTurno.Show();
                this.Hide();*/
            }
        }

        private void registrarAgendaDelMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* SqlConnector con = SqlConnector.getInstance();
            String validacion = "select * from HARDWELL.AGENDA as d where d.ID_PROFESIONAL=" + userId;
            DataTable data = new DataTable();
            data = con.executeQuery(validacion);

            String validacion2 = "select r.nombre from HARDWELL.ROL r, HARDWELL.USUARIO_ROL ur, HARDWELL.USUARIO u where u.USERNAME = '" + Clinica_Frba.Login.LoginForm.nombreUsuario + "' and u.ID_USUARIO = ur.ID_USUARIO and r.ID_ROL = ur.ID_ROL";
            DataTable data2 = new DataTable();
            data = con.executeQuery(validacion2);

            if (data.Rows.Count == 0)
            {
                if (data2.Rows[0][0].ToString() == "Profesional")
                {
                    Registrar_Agenda.Agenda ventanaAgenda = new Clinica_Frba.Registrar_Agenda.Agenda();
                    ventanaAgenda.idProfesionalLogueado = userId;
                    ventanaAgenda.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ya se selecciono agenda");
                }

            }

            if (data.Rows[0][0].ToString() == "Administrador del Sistema") ;
            {
                Registrar_Agenda.Agenda ventanaAgenda = new Clinica_Frba.Registrar_Agenda.Agenda();
                ventanaAgenda.quienEs = "Administrador del Sistema";
                ventanaAgenda.Show();
                this.Hide();
            }
            */
        }

        private void registrarLlegadaDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            NewFolder5.Form1 registro = new NewFolder5.Form1();
            registro.Show();
            */
        }

        private void registarResultadoDeLaAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Registro_Resultado_Atencion.IngresoTurno reg = new Registro_Resultado_Atencion.IngresoTurno();
            reg.Show();*/
        }

        private void obtenerEstadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Clinica_Frba.Listados_Estadisticos.Listados frmListados = new Clinica_Frba.Listados_Estadisticos.Listados();
            this.Hide();
            frmListados.Show();*/
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}