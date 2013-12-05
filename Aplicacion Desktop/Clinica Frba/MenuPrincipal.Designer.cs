namespace Clinica_Frba
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarBonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedirTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAgendaDelMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLlegadaDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarResultadoDeLaAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerEstadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCAMBIAR_rol = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 2;
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.afiliadosToolStripMenuItem,
            this.profesionalesToolStripMenuItem});
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // afiliadosToolStripMenuItem
            // 
            this.afiliadosToolStripMenuItem.Name = "afiliadosToolStripMenuItem";
            this.afiliadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afiliadosToolStripMenuItem.Text = "Afiliados";
            this.afiliadosToolStripMenuItem.Click += new System.EventHandler(this.afiliadosToolStripMenuItem_Click);
            // 
            // profesionalesToolStripMenuItem
            // 
            this.profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            this.profesionalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesionalesToolStripMenuItem.Text = "Profesionales";
            this.profesionalesToolStripMenuItem.Click += new System.EventHandler(this.profesionalesToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarAtenciónToolStripMenuItem,
            this.comprarBonosToolStripMenuItem,
            this.generarRecetaToolStripMenuItem,
            this.pedirTurnosToolStripMenuItem,
            this.registrarAgendaDelMédicoToolStripMenuItem,
            this.registrarLlegadaDelPacienteToolStripMenuItem,
            this.registarResultadoDeLaAtenciónToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // cancelarAtenciónToolStripMenuItem
            // 
            this.cancelarAtenciónToolStripMenuItem.Name = "cancelarAtenciónToolStripMenuItem";
            this.cancelarAtenciónToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cancelarAtenciónToolStripMenuItem.Text = "Cancelar Atención";
            this.cancelarAtenciónToolStripMenuItem.Click += new System.EventHandler(this.cancelarAtenciónToolStripMenuItem_Click);
            // 
            // comprarBonosToolStripMenuItem
            // 
            this.comprarBonosToolStripMenuItem.Name = "comprarBonosToolStripMenuItem";
            this.comprarBonosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.comprarBonosToolStripMenuItem.Text = "Comprar Bonos";
            this.comprarBonosToolStripMenuItem.Click += new System.EventHandler(this.comprarBonosToolStripMenuItem_Click);
            // 
            // generarRecetaToolStripMenuItem
            // 
            this.generarRecetaToolStripMenuItem.Name = "generarRecetaToolStripMenuItem";
            this.generarRecetaToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.generarRecetaToolStripMenuItem.Text = "Generar Receta";
            // 
            // pedirTurnosToolStripMenuItem
            // 
            this.pedirTurnosToolStripMenuItem.Name = "pedirTurnosToolStripMenuItem";
            this.pedirTurnosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.pedirTurnosToolStripMenuItem.Text = "Pedir Turnos";
            this.pedirTurnosToolStripMenuItem.Click += new System.EventHandler(this.pedirTurnosToolStripMenuItem_Click);
            // 
            // registrarAgendaDelMédicoToolStripMenuItem
            // 
            this.registrarAgendaDelMédicoToolStripMenuItem.Name = "registrarAgendaDelMédicoToolStripMenuItem";
            this.registrarAgendaDelMédicoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.registrarAgendaDelMédicoToolStripMenuItem.Text = "Registrar Agenda del Médico";
            this.registrarAgendaDelMédicoToolStripMenuItem.Click += new System.EventHandler(this.registrarAgendaDelMédicoToolStripMenuItem_Click);
            // 
            // registrarLlegadaDelPacienteToolStripMenuItem
            // 
            this.registrarLlegadaDelPacienteToolStripMenuItem.Name = "registrarLlegadaDelPacienteToolStripMenuItem";
            this.registrarLlegadaDelPacienteToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.registrarLlegadaDelPacienteToolStripMenuItem.Text = "Registrar Llegada del Paciente";
            this.registrarLlegadaDelPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarLlegadaDelPacienteToolStripMenuItem_Click);
            // 
            // registarResultadoDeLaAtenciónToolStripMenuItem
            // 
            this.registarResultadoDeLaAtenciónToolStripMenuItem.Name = "registarResultadoDeLaAtenciónToolStripMenuItem";
            this.registarResultadoDeLaAtenciónToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.registarResultadoDeLaAtenciónToolStripMenuItem.Text = "Registar Resultado de la Atención";
            this.registarResultadoDeLaAtenciónToolStripMenuItem.Click += new System.EventHandler(this.registarResultadoDeLaAtenciónToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obtenerEstadísticasToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.informaciónToolStripMenuItem.Text = "Información Estadística";
            // 
            // obtenerEstadísticasToolStripMenuItem
            // 
            this.obtenerEstadísticasToolStripMenuItem.Name = "obtenerEstadísticasToolStripMenuItem";
            this.obtenerEstadísticasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.obtenerEstadísticasToolStripMenuItem.Text = "Obtener Estadísticas";
            this.obtenerEstadísticasToolStripMenuItem.Click += new System.EventHandler(this.obtenerEstadísticasToolStripMenuItem_Click);
            // 
            // buttonCAMBIAR_rol
            // 
            this.buttonCAMBIAR_rol.Location = new System.Drawing.Point(12, 238);
            this.buttonCAMBIAR_rol.Name = "buttonCAMBIAR_rol";
            this.buttonCAMBIAR_rol.Size = new System.Drawing.Size(293, 23);
            this.buttonCAMBIAR_rol.TabIndex = 3;
            this.buttonCAMBIAR_rol.Text = "Elegir Otro Rol Activo";
            this.buttonCAMBIAR_rol.UseVisualStyleBackColor = true;
            this.buttonCAMBIAR_rol.Click += new System.EventHandler(this.buttonCAMBIAR_rol_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 273);
            this.Controls.Add(this.buttonCAMBIAR_rol);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.cargarFuncionalides);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAgendaDelMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLlegadaDelPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarBonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedirTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarResultadoDeLaAtenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerEstadísticasToolStripMenuItem;
        private System.Windows.Forms.Button buttonCAMBIAR_rol;
    }
}