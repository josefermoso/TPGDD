namespace Clinica_Frba.Listados_Estadisticos
{
    partial class ConfigurarListado
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
            this.labelAÑO = new System.Windows.Forms.Label();
            this.maskedTextBoxAÑO = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxSEMESTRE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVOLVER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Listado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAÑO
            // 
            this.labelAÑO.AutoSize = true;
            this.labelAÑO.Location = new System.Drawing.Point(24, 31);
            this.labelAÑO.Name = "labelAÑO";
            this.labelAÑO.Size = new System.Drawing.Size(219, 13);
            this.labelAÑO.TabIndex = 2;
            this.labelAÑO.Text = "Ingrese el año desaeado: (1990 - Actualidad)";
            // 
            // maskedTextBoxAÑO
            // 
            this.maskedTextBoxAÑO.Location = new System.Drawing.Point(348, 28);
            this.maskedTextBoxAÑO.Mask = "9999";
            this.maskedTextBoxAÑO.Name = "maskedTextBoxAÑO";
            this.maskedTextBoxAÑO.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBoxAÑO.TabIndex = 3;
            this.maskedTextBoxAÑO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxAÑO_MaskInputRejected);
            // 
            // comboBoxSEMESTRE
            // 
            this.comboBoxSEMESTRE.FormattingEnabled = true;
            this.comboBoxSEMESTRE.Items.AddRange(new object[] {
            "PRIMER SEMESTRE",
            "SEGUNDO SEMESTRE"});
            this.comboBoxSEMESTRE.Location = new System.Drawing.Point(236, 70);
            this.comboBoxSEMESTRE.Name = "comboBoxSEMESTRE";
            this.comboBoxSEMESTRE.Size = new System.Drawing.Size(142, 21);
            this.comboBoxSEMESTRE.TabIndex = 4;
            this.comboBoxSEMESTRE.SelectedIndexChanged += new System.EventHandler(this.comboBoxSEMESTRE_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el semestre deseado:";
            // 
            // buttonVOLVER
            // 
            this.buttonVOLVER.Location = new System.Drawing.Point(218, 128);
            this.buttonVOLVER.Name = "buttonVOLVER";
            this.buttonVOLVER.Size = new System.Drawing.Size(160, 52);
            this.buttonVOLVER.TabIndex = 6;
            this.buttonVOLVER.Text = "Elegir otro Listado";
            this.buttonVOLVER.UseVisualStyleBackColor = true;
            this.buttonVOLVER.Click += new System.EventHandler(this.buttonVOLVER_Click);
            // 
            // ConfigurarListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 199);
            this.Controls.Add(this.buttonVOLVER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSEMESTRE);
            this.Controls.Add(this.maskedTextBoxAÑO);
            this.Controls.Add(this.labelAÑO);
            this.Controls.Add(this.button1);
            this.Name = "ConfigurarListado";
            this.Text = "Configurar Listado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAÑO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAÑO;
        private System.Windows.Forms.ComboBox comboBoxSEMESTRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVOLVER;
    }
}