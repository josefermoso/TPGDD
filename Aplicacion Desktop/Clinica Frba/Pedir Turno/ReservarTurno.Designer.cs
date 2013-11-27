namespace Clinica_Frba.pedido_turno
{
    partial class buscarProfesional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaProfesional = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelNombreProfesional = new System.Windows.Forms.Label();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.especialidades = new System.Windows.Forms.ComboBox();
            this.nombreProfesional = new System.Windows.Forms.TextBox();
            this.labelApellidoProfesional = new System.Windows.Forms.Label();
            this.apellidoProfesional = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProfesional
            // 
            this.grillaProfesional.AllowUserToAddRows = false;
            this.grillaProfesional.AllowUserToDeleteRows = false;
            this.grillaProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.grillaProfesional.Location = new System.Drawing.Point(12, 91);
            this.grillaProfesional.MultiSelect = false;
            this.grillaProfesional.Name = "grillaProfesional";
            this.grillaProfesional.ReadOnly = true;
            this.grillaProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProfesional.Size = new System.Drawing.Size(740, 157);
            this.grillaProfesional.TabIndex = 1;
            this.grillaProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProfesional_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Seleccionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            // 
            // labelNombreProfesional
            // 
            this.labelNombreProfesional.AutoSize = true;
            this.labelNombreProfesional.Location = new System.Drawing.Point(35, 40);
            this.labelNombreProfesional.Name = "labelNombreProfesional";
            this.labelNombreProfesional.Size = new System.Drawing.Size(44, 13);
            this.labelNombreProfesional.TabIndex = 2;
            this.labelNombreProfesional.Text = "Nombre";
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Location = new System.Drawing.Point(501, 40);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(96, 13);
            this.labelEspecialidad.TabIndex = 3;
            this.labelEspecialidad.Text = "Elegir Especialidad";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(572, 269);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(677, 269);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 5;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // especialidades
            // 
            this.especialidades.FormattingEnabled = true;
            this.especialidades.Location = new System.Drawing.Point(603, 36);
            this.especialidades.Name = "especialidades";
            this.especialidades.Size = new System.Drawing.Size(121, 21);
            this.especialidades.TabIndex = 6;
            this.especialidades.SelectedIndexChanged += new System.EventHandler(this.especialidades_SelectedIndexChanged);
            // 
            // nombreProfesional
            // 
            this.nombreProfesional.Location = new System.Drawing.Point(85, 37);
            this.nombreProfesional.Name = "nombreProfesional";
            this.nombreProfesional.Size = new System.Drawing.Size(121, 20);
            this.nombreProfesional.TabIndex = 7;
            // 
            // labelApellidoProfesional
            // 
            this.labelApellidoProfesional.AutoSize = true;
            this.labelApellidoProfesional.Location = new System.Drawing.Point(271, 40);
            this.labelApellidoProfesional.Name = "labelApellidoProfesional";
            this.labelApellidoProfesional.Size = new System.Drawing.Size(44, 13);
            this.labelApellidoProfesional.TabIndex = 8;
            this.labelApellidoProfesional.Text = "Apellido";
            // 
            // apellidoProfesional
            // 
            this.apellidoProfesional.Location = new System.Drawing.Point(321, 37);
            this.apellidoProfesional.Name = "apellidoProfesional";
            this.apellidoProfesional.Size = new System.Drawing.Size(121, 20);
            this.apellidoProfesional.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apellidoProfesional);
            this.Controls.Add(this.labelApellidoProfesional);
            this.Controls.Add(this.nombreProfesional);
            this.Controls.Add(this.especialidades);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.labelEspecialidad);
            this.Controls.Add(this.labelNombreProfesional);
            this.Controls.Add(this.grillaProfesional);
            this.Name = "buscarProfesional";
            this.Text = "Pedido Turno";
            this.Load += new System.EventHandler(this.buscarProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProfesional;
        private System.Windows.Forms.Label labelNombreProfesional;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.ComboBox especialidades;
        private System.Windows.Forms.TextBox nombreProfesional;
        private System.Windows.Forms.Label labelApellidoProfesional;
        private System.Windows.Forms.TextBox apellidoProfesional;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
        private System.Windows.Forms.Button button1;
    }
}