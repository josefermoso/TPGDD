namespace Clinica_Frba.Abm_de_Rol
{
    partial class FormModifRol
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
            this.lablelNUEVONOMBRE = new System.Windows.Forms.Label();
            this.labelFUNCIONALIDADES = new System.Windows.Forms.Label();
            this.labelESTADO = new System.Windows.Forms.Label();
            this.txtbNOMBRE = new System.Windows.Forms.TextBox();
            this.clbFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.buttonLIMPIAR = new System.Windows.Forms.Button();
            this.buttonMODIFICAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lablelNUEVONOMBRE
            // 
            this.lablelNUEVONOMBRE.AutoSize = true;
            this.lablelNUEVONOMBRE.Location = new System.Drawing.Point(12, 25);
            this.lablelNUEVONOMBRE.Name = "lablelNUEVONOMBRE";
            this.lablelNUEVONOMBRE.Size = new System.Drawing.Size(82, 13);
            this.lablelNUEVONOMBRE.TabIndex = 38;
            this.lablelNUEVONOMBRE.Text = "Nuevo Nombre:";
            // 
            // labelFUNCIONALIDADES
            // 
            this.labelFUNCIONALIDADES.AutoSize = true;
            this.labelFUNCIONALIDADES.Location = new System.Drawing.Point(7, 77);
            this.labelFUNCIONALIDADES.Name = "labelFUNCIONALIDADES";
            this.labelFUNCIONALIDADES.Size = new System.Drawing.Size(139, 13);
            this.labelFUNCIONALIDADES.TabIndex = 44;
            this.labelFUNCIONALIDADES.Text = "Funcionalidades Asignadas:";
            // 
            // labelESTADO
            // 
            this.labelESTADO.AutoSize = true;
            this.labelESTADO.Location = new System.Drawing.Point(12, 226);
            this.labelESTADO.Name = "labelESTADO";
            this.labelESTADO.Size = new System.Drawing.Size(79, 13);
            this.labelESTADO.TabIndex = 45;
            this.labelESTADO.Text = "Estado del Rol:";
            // 
            // txtbNOMBRE
            // 
            this.txtbNOMBRE.Location = new System.Drawing.Point(175, 18);
            this.txtbNOMBRE.Name = "txtbNOMBRE";
            this.txtbNOMBRE.Size = new System.Drawing.Size(256, 20);
            this.txtbNOMBRE.TabIndex = 46;
            // 
            // clbFuncionalidades
            // 
            this.clbFuncionalidades.CheckOnClick = true;
            this.clbFuncionalidades.FormattingEnabled = true;
            this.clbFuncionalidades.Location = new System.Drawing.Point(175, 44);
            this.clbFuncionalidades.Name = "clbFuncionalidades";
            this.clbFuncionalidades.Size = new System.Drawing.Size(256, 169);
            this.clbFuncionalidades.Sorted = true;
            this.clbFuncionalidades.TabIndex = 47;
            // 
            // cbActivo
            // 
            this.cbActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.cbActivo.Location = new System.Drawing.Point(175, 226);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(256, 21);
            this.cbActivo.TabIndex = 48;
            // 
            // buttonLIMPIAR
            // 
            this.buttonLIMPIAR.Location = new System.Drawing.Point(15, 269);
            this.buttonLIMPIAR.Name = "buttonLIMPIAR";
            this.buttonLIMPIAR.Size = new System.Drawing.Size(117, 26);
            this.buttonLIMPIAR.TabIndex = 49;
            this.buttonLIMPIAR.Text = "Limpiar";
            this.buttonLIMPIAR.UseVisualStyleBackColor = true;
            this.buttonLIMPIAR.Click += new System.EventHandler(this.buttonLIMPIAR_Click);
            // 
            // buttonMODIFICAR
            // 
            this.buttonMODIFICAR.Location = new System.Drawing.Point(314, 269);
            this.buttonMODIFICAR.Name = "buttonMODIFICAR";
            this.buttonMODIFICAR.Size = new System.Drawing.Size(117, 26);
            this.buttonMODIFICAR.TabIndex = 50;
            this.buttonMODIFICAR.Text = "Modificar";
            this.buttonMODIFICAR.UseVisualStyleBackColor = true;
            this.buttonMODIFICAR.Click += new System.EventHandler(this.buttonMODIFICAR_Click);
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 316);
            this.Controls.Add(this.buttonMODIFICAR);
            this.Controls.Add(this.buttonLIMPIAR);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.clbFuncionalidades);
            this.Controls.Add(this.txtbNOMBRE);
            this.Controls.Add(this.labelESTADO);
            this.Controls.Add(this.labelFUNCIONALIDADES);
            this.Controls.Add(this.lablelNUEVONOMBRE);
            this.Name = "ModificarRol";
            this.Text = "Modificar Rol Seleccionado";
            this.Load += new System.EventHandler(this.FormModifRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablelNUEVONOMBRE;
        private System.Windows.Forms.Label labelFUNCIONALIDADES;
        private System.Windows.Forms.Label labelESTADO;
        private System.Windows.Forms.TextBox txtbNOMBRE;
        private System.Windows.Forms.CheckedListBox clbFuncionalidades;
        private System.Windows.Forms.ComboBox cbActivo;
        private System.Windows.Forms.Button buttonLIMPIAR;
        private System.Windows.Forms.Button buttonMODIFICAR;
    }
}