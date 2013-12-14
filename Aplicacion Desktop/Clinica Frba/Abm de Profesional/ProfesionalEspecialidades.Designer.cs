namespace Clinica_Frba.Abm_de_Profesional
{
    partial class ProfesionalEspecialidades
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
            this.disponibles = new System.Windows.Forms.ListBox();
            this.asignadas = new System.Windows.Forms.ListBox();
            this.agregar = new System.Windows.Forms.Button();
            this.quitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.tiposEspecialidades = new System.Windows.Forms.ComboBox();
            this.filtrarEspecialidades = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disponibles
            // 
            this.disponibles.FormattingEnabled = true;
            this.disponibles.HorizontalScrollbar = true;
            this.disponibles.Location = new System.Drawing.Point(481, 68);
            this.disponibles.Name = "disponibles";
            this.disponibles.Size = new System.Drawing.Size(319, 199);
            this.disponibles.TabIndex = 0;
            this.disponibles.SelectedIndexChanged += new System.EventHandler(this.disponibles_SelectedIndexChanged);
            // 
            // asignadas
            // 
            this.asignadas.FormattingEnabled = true;
            this.asignadas.HorizontalScrollbar = true;
            this.asignadas.Location = new System.Drawing.Point(33, 68);
            this.asignadas.Name = "asignadas";
            this.asignadas.Size = new System.Drawing.Size(319, 199);
            this.asignadas.TabIndex = 1;
            this.asignadas.SelectedIndexChanged += new System.EventHandler(this.asignadas_SelectedIndexChanged);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(380, 129);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "<<";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(380, 169);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(75, 23);
            this.quitar.TabIndex = 3;
            this.quitar.Text = ">>";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asignadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Disponibles";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(633, 330);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 6;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(725, 330);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 7;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // tiposEspecialidades
            // 
            this.tiposEspecialidades.FormattingEnabled = true;
            this.tiposEspecialidades.Location = new System.Drawing.Point(545, 38);
            this.tiposEspecialidades.Name = "tiposEspecialidades";
            this.tiposEspecialidades.Size = new System.Drawing.Size(174, 21);
            this.tiposEspecialidades.TabIndex = 8;
            this.tiposEspecialidades.SelectedIndexChanged += new System.EventHandler(this.tiposEspecialidades_SelectedIndexChanged);
            // 
            // filtrarEspecialidades
            // 
            this.filtrarEspecialidades.Location = new System.Drawing.Point(725, 38);
            this.filtrarEspecialidades.Name = "filtrarEspecialidades";
            this.filtrarEspecialidades.Size = new System.Drawing.Size(75, 23);
            this.filtrarEspecialidades.TabIndex = 9;
            this.filtrarEspecialidades.Text = "Filtrar";
            this.filtrarEspecialidades.UseVisualStyleBackColor = true;
            this.filtrarEspecialidades.Click += new System.EventHandler(this.filtrarEspecialidades_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(380, 212);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProfesionalEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 368);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.filtrarEspecialidades);
            this.Controls.Add(this.tiposEspecialidades);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.asignadas);
            this.Controls.Add(this.disponibles);
            this.Name = "ProfesionalEspecialidades";
            this.Text = "ABM Profesional - Especialidades";
            this.Load += new System.EventHandler(this.ABMProfesionalEspecialidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox disponibles;
        private System.Windows.Forms.ListBox asignadas;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button quitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.ComboBox tiposEspecialidades;
        private System.Windows.Forms.Button filtrarEspecialidades;
        private System.Windows.Forms.Button limpiar;
    }
}