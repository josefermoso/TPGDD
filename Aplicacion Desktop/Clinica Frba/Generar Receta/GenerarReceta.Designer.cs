namespace Clinica_Frba.Generar_Receta
{
    partial class GenerarReceta
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
            this.labelNUMEROBONOFAR = new System.Windows.Forms.Label();
            this.textBoxBONOFAR = new System.Windows.Forms.TextBox();
            this.dgvDrogas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonGENERARUNASOLA = new System.Windows.Forms.Button();
            this.buttonGENERARMASDEUNA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNOMBREMED = new System.Windows.Forms.TextBox();
            this.buttonBUSCARMED = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTOTAL = new System.Windows.Forms.Label();
            this.buttonLIMPIAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrogas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNUMEROBONOFAR
            // 
            this.labelNUMEROBONOFAR.AutoSize = true;
            this.labelNUMEROBONOFAR.Location = new System.Drawing.Point(13, 22);
            this.labelNUMEROBONOFAR.Name = "labelNUMEROBONOFAR";
            this.labelNUMEROBONOFAR.Size = new System.Drawing.Size(237, 13);
            this.labelNUMEROBONOFAR.TabIndex = 0;
            this.labelNUMEROBONOFAR.Text = "Ingrese el número de Bono Farmacia a consumir:";
            // 
            // textBoxBONOFAR
            // 
            this.textBoxBONOFAR.Location = new System.Drawing.Point(256, 19);
            this.textBoxBONOFAR.Name = "textBoxBONOFAR";
            this.textBoxBONOFAR.Size = new System.Drawing.Size(194, 20);
            this.textBoxBONOFAR.TabIndex = 1;
            // 
            // dgvDrogas
            // 
            this.dgvDrogas.AllowUserToAddRows = false;
            this.dgvDrogas.AllowUserToDeleteRows = false;
            this.dgvDrogas.AllowUserToResizeColumns = false;
            this.dgvDrogas.AllowUserToResizeRows = false;
            this.dgvDrogas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDrogas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDrogas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrogas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvDrogas.Enabled = false;
            this.dgvDrogas.Location = new System.Drawing.Point(12, 116);
            this.dgvDrogas.MultiSelect = false;
            this.dgvDrogas.Name = "dgvDrogas";
            this.dgvDrogas.ReadOnly = true;
            this.dgvDrogas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDrogas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDrogas.Size = new System.Drawing.Size(438, 141);
            this.dgvDrogas.TabIndex = 38;
            this.dgvDrogas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 69;
            // 
            // buttonGENERARUNASOLA
            // 
            this.buttonGENERARUNASOLA.Location = new System.Drawing.Point(16, 325);
            this.buttonGENERARUNASOLA.Name = "buttonGENERARUNASOLA";
            this.buttonGENERARUNASOLA.Size = new System.Drawing.Size(201, 23);
            this.buttonGENERARUNASOLA.TabIndex = 39;
            this.buttonGENERARUNASOLA.Text = "Generar Única Receta";
            this.buttonGENERARUNASOLA.UseVisualStyleBackColor = true;
            this.buttonGENERARUNASOLA.Click += new System.EventHandler(this.buttonGENERARUNASOLA_Click);
            // 
            // buttonGENERARMASDEUNA
            // 
            this.buttonGENERARMASDEUNA.Location = new System.Drawing.Point(239, 325);
            this.buttonGENERARMASDEUNA.Name = "buttonGENERARMASDEUNA";
            this.buttonGENERARMASDEUNA.Size = new System.Drawing.Size(211, 23);
            this.buttonGENERARMASDEUNA.TabIndex = 40;
            this.buttonGENERARMASDEUNA.Text = "Generar Receta y Confeccionar Otra";
            this.buttonGENERARMASDEUNA.UseVisualStyleBackColor = true;
            this.buttonGENERARMASDEUNA.Click += new System.EventHandler(this.buttonGENERARMASDEUNA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Opcional: Busque un medicamento por su nombre:";
            // 
            // textBoxNOMBREMED
            // 
            this.textBoxNOMBREMED.Location = new System.Drawing.Point(261, 52);
            this.textBoxNOMBREMED.Name = "textBoxNOMBREMED";
            this.textBoxNOMBREMED.Size = new System.Drawing.Size(189, 20);
            this.textBoxNOMBREMED.TabIndex = 42;
            // 
            // buttonBUSCARMED
            // 
            this.buttonBUSCARMED.Location = new System.Drawing.Point(127, 87);
            this.buttonBUSCARMED.Name = "buttonBUSCARMED";
            this.buttonBUSCARMED.Size = new System.Drawing.Size(211, 23);
            this.buttonBUSCARMED.TabIndex = 43;
            this.buttonBUSCARMED.Text = "Buscar Medicamento";
            this.buttonBUSCARMED.UseVisualStyleBackColor = true;
            this.buttonBUSCARMED.Click += new System.EventHandler(this.buttonBUSCARMED_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Total medicamentos seleccionados:";
            // 
            // labelTOTAL
            // 
            this.labelTOTAL.AutoSize = true;
            this.labelTOTAL.Location = new System.Drawing.Point(426, 272);
            this.labelTOTAL.Name = "labelTOTAL";
            this.labelTOTAL.Size = new System.Drawing.Size(13, 13);
            this.labelTOTAL.TabIndex = 45;
            this.labelTOTAL.Text = "0";
            // 
            // buttonLIMPIAR
            // 
            this.buttonLIMPIAR.Location = new System.Drawing.Point(12, 267);
            this.buttonLIMPIAR.Name = "buttonLIMPIAR";
            this.buttonLIMPIAR.Size = new System.Drawing.Size(211, 23);
            this.buttonLIMPIAR.TabIndex = 46;
            this.buttonLIMPIAR.Text = "Limpiar Selección";
            this.buttonLIMPIAR.UseVisualStyleBackColor = true;
            this.buttonLIMPIAR.Click += new System.EventHandler(this.buttonLIMPIAR_Click);
            // 
            // GenerarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 359);
            this.Controls.Add(this.buttonLIMPIAR);
            this.Controls.Add(this.labelTOTAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBUSCARMED);
            this.Controls.Add(this.textBoxNOMBREMED);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGENERARMASDEUNA);
            this.Controls.Add(this.buttonGENERARUNASOLA);
            this.Controls.Add(this.dgvDrogas);
            this.Controls.Add(this.textBoxBONOFAR);
            this.Controls.Add(this.labelNUMEROBONOFAR);
            this.Name = "GenerarReceta";
            this.Text = "Generar Receta Médica";
            this.Load += new System.EventHandler(this.mostrarDrogas);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrogas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNUMEROBONOFAR;
        private System.Windows.Forms.TextBox textBoxBONOFAR;
        private System.Windows.Forms.DataGridView dgvDrogas;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button buttonGENERARUNASOLA;
        private System.Windows.Forms.Button buttonGENERARMASDEUNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNOMBREMED;
        private System.Windows.Forms.Button buttonBUSCARMED;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTOTAL;
        private System.Windows.Forms.Button buttonLIMPIAR;
    }
}