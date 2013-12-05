namespace Clinica_Frba.Abm_de_Rol
{
    partial class FiltrarRol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLIMPIAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBUSCAR = new System.Windows.Forms.Button();
            this.textboxBUSQUEDA = new System.Windows.Forms.TextBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonCREAR = new System.Windows.Forms.Button();
            this.REGRESAR_PRINCIPAL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLIMPIAR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonBUSCAR);
            this.groupBox1.Controls.Add(this.textboxBUSQUEDA);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 88);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Búsqueda:";
            // 
            // buttonLIMPIAR
            // 
            this.buttonLIMPIAR.Location = new System.Drawing.Point(9, 56);
            this.buttonLIMPIAR.Name = "buttonLIMPIAR";
            this.buttonLIMPIAR.Size = new System.Drawing.Size(117, 26);
            this.buttonLIMPIAR.TabIndex = 33;
            this.buttonLIMPIAR.Text = "Limpiar";
            this.buttonLIMPIAR.UseVisualStyleBackColor = true;
            this.buttonLIMPIAR.Click += new System.EventHandler(this.buttonLIMPIAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // buttonBUSCAR
            // 
            this.buttonBUSCAR.Location = new System.Drawing.Point(281, 56);
            this.buttonBUSCAR.Name = "buttonBUSCAR";
            this.buttonBUSCAR.Size = new System.Drawing.Size(117, 26);
            this.buttonBUSCAR.TabIndex = 27;
            this.buttonBUSCAR.Text = "Buscar";
            this.buttonBUSCAR.UseVisualStyleBackColor = true;
            this.buttonBUSCAR.Click += new System.EventHandler(this.buttonBUSCAR_Click);
            // 
            // textboxBUSQUEDA
            // 
            this.textboxBUSQUEDA.Location = new System.Drawing.Point(74, 19);
            this.textboxBUSQUEDA.Name = "textboxBUSQUEDA";
            this.textboxBUSQUEDA.Size = new System.Drawing.Size(324, 20);
            this.textboxBUSQUEDA.TabIndex = 25;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToResizeColumns = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvRoles.Enabled = false;
            this.dgvRoles.Location = new System.Drawing.Point(12, 163);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRoles.Size = new System.Drawing.Size(403, 117);
            this.dgvRoles.TabIndex = 36;
            this.dgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Modificar Rol";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 75;
            // 
            // buttonCREAR
            // 
            this.buttonCREAR.Location = new System.Drawing.Point(12, 12);
            this.buttonCREAR.Name = "buttonCREAR";
            this.buttonCREAR.Size = new System.Drawing.Size(398, 23);
            this.buttonCREAR.TabIndex = 37;
            this.buttonCREAR.Text = "Crear Nuevo Rol";
            this.buttonCREAR.UseVisualStyleBackColor = true;
            this.buttonCREAR.Click += new System.EventHandler(this.buttonCREAR_Click);
            // 
            // REGRESAR_PRINCIPAL
            // 
            this.REGRESAR_PRINCIPAL.Location = new System.Drawing.Point(21, 306);
            this.REGRESAR_PRINCIPAL.Name = "REGRESAR_PRINCIPAL";
            this.REGRESAR_PRINCIPAL.Size = new System.Drawing.Size(394, 23);
            this.REGRESAR_PRINCIPAL.TabIndex = 38;
            this.REGRESAR_PRINCIPAL.Text = "Regresar al Menu Principal";
            this.REGRESAR_PRINCIPAL.UseVisualStyleBackColor = true;
            this.REGRESAR_PRINCIPAL.Click += new System.EventHandler(this.REGRESAR_PRINCIPAL_Click);
            // 
            // Filtrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 341);
            this.Controls.Add(this.REGRESAR_PRINCIPAL);
            this.Controls.Add(this.buttonCREAR);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.groupBox1);
            this.Name = "Filtrar";
            this.Text = "Búsqueda de Roles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBUSCAR;
        private System.Windows.Forms.TextBox textboxBUSQUEDA;
        private System.Windows.Forms.Button buttonLIMPIAR;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button buttonCREAR;
        private System.Windows.Forms.Button REGRESAR_PRINCIPAL;
    }
}