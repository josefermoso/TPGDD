namespace Clinica_Frba.Pedir_Turno
{
    partial class ProfesionalSeleccionado
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
            this.grillaProfesional = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fechasDisponibles = new System.Windows.Forms.ComboBox();
            this.buscarHorario = new System.Windows.Forms.Button();
            this.limpiarGrilla = new System.Windows.Forms.Button();
            this.labelDiaDeLaSemana = new System.Windows.Forms.Label();
            this.diasDeLaSemana = new System.Windows.Forms.ComboBox();
            this.obtenerNroAfiliado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumeroAfiliado = new System.Windows.Forms.Label();
            this.numeroDeAfiliado = new System.Windows.Forms.TextBox();
            this.agregarAfiliado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProfesional
            // 
            this.grillaProfesional.AllowUserToAddRows = false;
            this.grillaProfesional.AllowUserToDeleteRows = false;
            this.grillaProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.grillaProfesional.Location = new System.Drawing.Point(23, 145);
            this.grillaProfesional.MultiSelect = false;
            this.grillaProfesional.Name = "grillaProfesional";
            this.grillaProfesional.ReadOnly = true;
            this.grillaProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProfesional.Size = new System.Drawing.Size(396, 157);
            this.grillaProfesional.TabIndex = 2;
            this.grillaProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProfesional_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // fechasDisponibles
            // 
            this.fechasDisponibles.FormattingEnabled = true;
            this.fechasDisponibles.Location = new System.Drawing.Point(151, 102);
            this.fechasDisponibles.Name = "fechasDisponibles";
            this.fechasDisponibles.Size = new System.Drawing.Size(191, 21);
            this.fechasDisponibles.TabIndex = 3;
            this.fechasDisponibles.SelectedIndexChanged += new System.EventHandler(this.fechasDisponibles_SelectedIndexChanged);
            // 
            // buscarHorario
            // 
            this.buscarHorario.Location = new System.Drawing.Point(469, 169);
            this.buscarHorario.Name = "buscarHorario";
            this.buscarHorario.Size = new System.Drawing.Size(75, 23);
            this.buscarHorario.TabIndex = 5;
            this.buscarHorario.Text = "Horarios";
            this.buscarHorario.UseVisualStyleBackColor = true;
            this.buscarHorario.Click += new System.EventHandler(this.buscarHorario_Click);
            // 
            // limpiarGrilla
            // 
            this.limpiarGrilla.Location = new System.Drawing.Point(469, 214);
            this.limpiarGrilla.Name = "limpiarGrilla";
            this.limpiarGrilla.Size = new System.Drawing.Size(75, 23);
            this.limpiarGrilla.TabIndex = 6;
            this.limpiarGrilla.Text = "Limpiar";
            this.limpiarGrilla.UseVisualStyleBackColor = true;
            this.limpiarGrilla.Click += new System.EventHandler(this.limpiarGrilla_Click);
            // 
            // labelDiaDeLaSemana
            // 
            this.labelDiaDeLaSemana.AutoSize = true;
            this.labelDiaDeLaSemana.Location = new System.Drawing.Point(46, 66);
            this.labelDiaDeLaSemana.Name = "labelDiaDeLaSemana";
            this.labelDiaDeLaSemana.Size = new System.Drawing.Size(91, 13);
            this.labelDiaDeLaSemana.TabIndex = 7;
            this.labelDiaDeLaSemana.Text = "Dia de la Semana";
            this.labelDiaDeLaSemana.Click += new System.EventHandler(this.label2_Click);
            // 
            // diasDeLaSemana
            // 
            this.diasDeLaSemana.FormattingEnabled = true;
            this.diasDeLaSemana.Location = new System.Drawing.Point(151, 63);
            this.diasDeLaSemana.Name = "diasDeLaSemana";
            this.diasDeLaSemana.Size = new System.Drawing.Size(191, 21);
            this.diasDeLaSemana.TabIndex = 8;
            this.diasDeLaSemana.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // obtenerNroAfiliado
            // 
            this.obtenerNroAfiliado.Location = new System.Drawing.Point(469, 258);
            this.obtenerNroAfiliado.Name = "obtenerNroAfiliado";
            this.obtenerNroAfiliado.Size = new System.Drawing.Size(75, 23);
            this.obtenerNroAfiliado.TabIndex = 9;
            this.obtenerNroAfiliado.Text = "Cancelar";
            this.obtenerNroAfiliado.UseVisualStyleBackColor = true;
            this.obtenerNroAfiliado.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fechas Disponibles";
            // 
            // labelNumeroAfiliado
            // 
            this.labelNumeroAfiliado.AutoSize = true;
            this.labelNumeroAfiliado.Location = new System.Drawing.Point(46, 31);
            this.labelNumeroAfiliado.Name = "labelNumeroAfiliado";
            this.labelNumeroAfiliado.Size = new System.Drawing.Size(81, 13);
            this.labelNumeroAfiliado.TabIndex = 10;
            this.labelNumeroAfiliado.Text = "Numero Afiliado";
            // 
            // numeroDeAfiliado
            // 
            this.numeroDeAfiliado.Location = new System.Drawing.Point(151, 28);
            this.numeroDeAfiliado.Name = "numeroDeAfiliado";
            this.numeroDeAfiliado.Size = new System.Drawing.Size(100, 20);
            this.numeroDeAfiliado.TabIndex = 11;
            // 
            // agregarAfiliado
            // 
            this.agregarAfiliado.Location = new System.Drawing.Point(278, 26);
            this.agregarAfiliado.Name = "agregarAfiliado";
            this.agregarAfiliado.Size = new System.Drawing.Size(75, 23);
            this.agregarAfiliado.TabIndex = 12;
            this.agregarAfiliado.Text = "Validar";
            this.agregarAfiliado.UseVisualStyleBackColor = true;
            this.agregarAfiliado.Click += new System.EventHandler(this.button2_Click);
            // 
            // InfoProfesionalSeleccionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 314);
            this.Controls.Add(this.agregarAfiliado);
            this.Controls.Add(this.numeroDeAfiliado);
            this.Controls.Add(this.labelNumeroAfiliado);
            this.Controls.Add(this.obtenerNroAfiliado);
            this.Controls.Add(this.diasDeLaSemana);
            this.Controls.Add(this.labelDiaDeLaSemana);
            this.Controls.Add(this.limpiarGrilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscarHorario);
            this.Controls.Add(this.fechasDisponibles);
            this.Controls.Add(this.grillaProfesional);
            this.Name = "InfoProfesionalSeleccionado";
            this.Text = "InfoProfesionalSeleccionado";
            this.Load += new System.EventHandler(this.InfoProfesionalSeleccionado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProfesional;
        private System.Windows.Forms.ComboBox fechasDisponibles;
        private System.Windows.Forms.Button buscarHorario;
        private System.Windows.Forms.Button limpiarGrilla;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Label labelDiaDeLaSemana;
        private System.Windows.Forms.ComboBox diasDeLaSemana;
        private System.Windows.Forms.Button obtenerNroAfiliado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumeroAfiliado;
        private System.Windows.Forms.TextBox numeroDeAfiliado;
        private System.Windows.Forms.Button agregarAfiliado;
    }
}