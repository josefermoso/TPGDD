namespace Clinica_Frba.Registro_de_LLegada
{
    partial class TurnosDadosProfesional
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
            this.button1 = new System.Windows.Forms.Button();
            this.limpiarGrilla = new System.Windows.Forms.Button();
            this.buscarHorario = new System.Windows.Forms.Button();
            this.grillaProfesional = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelNroAfiliado = new System.Windows.Forms.Label();
            this.nombreAfiliado = new System.Windows.Forms.TextBox();
            this.idBono = new System.Windows.Forms.Label();
            this.idBonoAUsar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // limpiarGrilla
            // 
            this.limpiarGrilla.Location = new System.Drawing.Point(459, 164);
            this.limpiarGrilla.Name = "limpiarGrilla";
            this.limpiarGrilla.Size = new System.Drawing.Size(75, 23);
            this.limpiarGrilla.TabIndex = 11;
            this.limpiarGrilla.Text = "Limpiar";
            this.limpiarGrilla.UseVisualStyleBackColor = true;
            this.limpiarGrilla.Click += new System.EventHandler(this.limpiarGrilla_Click);
            // 
            // buscarHorario
            // 
            this.buscarHorario.Location = new System.Drawing.Point(459, 119);
            this.buscarHorario.Name = "buscarHorario";
            this.buscarHorario.Size = new System.Drawing.Size(75, 23);
            this.buscarHorario.TabIndex = 10;
            this.buscarHorario.Text = "Turnos";
            this.buscarHorario.UseVisualStyleBackColor = true;
            this.buscarHorario.Click += new System.EventHandler(this.buscarHorario_Click);
            // 
            // grillaProfesional
            // 
            this.grillaProfesional.AllowUserToAddRows = false;
            this.grillaProfesional.AllowUserToDeleteRows = false;
            this.grillaProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.grillaProfesional.Location = new System.Drawing.Point(12, 98);
            this.grillaProfesional.MultiSelect = false;
            this.grillaProfesional.Name = "grillaProfesional";
            this.grillaProfesional.ReadOnly = true;
            this.grillaProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProfesional.Size = new System.Drawing.Size(396, 157);
            this.grillaProfesional.TabIndex = 13;
            this.grillaProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProfesional_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // labelNroAfiliado
            // 
            this.labelNroAfiliado.AutoSize = true;
            this.labelNroAfiliado.Location = new System.Drawing.Point(32, 24);
            this.labelNroAfiliado.Name = "labelNroAfiliado";
            this.labelNroAfiliado.Size = new System.Drawing.Size(61, 13);
            this.labelNroAfiliado.TabIndex = 18;
            this.labelNroAfiliado.Text = "Nro Afiliado";
            // 
            // nombreAfiliado
            // 
            this.nombreAfiliado.Location = new System.Drawing.Point(114, 24);
            this.nombreAfiliado.Name = "nombreAfiliado";
            this.nombreAfiliado.Size = new System.Drawing.Size(100, 20);
            this.nombreAfiliado.TabIndex = 19;
            // 
            // idBono
            // 
            this.idBono.AutoSize = true;
            this.idBono.Location = new System.Drawing.Point(32, 63);
            this.idBono.Name = "idBono";
            this.idBono.Size = new System.Drawing.Size(76, 13);
            this.idBono.TabIndex = 20;
            this.idBono.Text = "Bono Consulta";
            // 
            // idBonoAUsar
            // 
            this.idBonoAUsar.Location = new System.Drawing.Point(114, 60);
            this.idBonoAUsar.Name = "idBonoAUsar";
            this.idBonoAUsar.Size = new System.Drawing.Size(100, 20);
            this.idBonoAUsar.TabIndex = 21;
            // 
            // TurnosDadosProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 284);
            this.Controls.Add(this.idBonoAUsar);
            this.Controls.Add(this.idBono);
            this.Controls.Add(this.nombreAfiliado);
            this.Controls.Add(this.labelNroAfiliado);
            this.Controls.Add(this.grillaProfesional);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.limpiarGrilla);
            this.Controls.Add(this.buscarHorario);
            this.Name = "TurnosDadosProfesional";
            this.Text = "TurnosDadosProfesional";
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button limpiarGrilla;
        private System.Windows.Forms.Button buscarHorario;
        private System.Windows.Forms.DataGridView grillaProfesional;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Label labelNroAfiliado;
        private System.Windows.Forms.TextBox nombreAfiliado;
        private System.Windows.Forms.Label idBono;
        private System.Windows.Forms.TextBox idBonoAUsar;
    }
}