namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class IngresoTurno
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNUMEROTURNO = new System.Windows.Forms.TextBox();
            this.buttonINGRESAR = new System.Windows.Forms.Button();
            this.labelPROF = new System.Windows.Forms.Label();
            this.textBoxPROF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Número de Turno para Registrar el Resultado de la Atención:";
            // 
            // textBoxNUMEROTURNO
            // 
            this.textBoxNUMEROTURNO.Location = new System.Drawing.Point(82, 51);
            this.textBoxNUMEROTURNO.Name = "textBoxNUMEROTURNO";
            this.textBoxNUMEROTURNO.Size = new System.Drawing.Size(208, 20);
            this.textBoxNUMEROTURNO.TabIndex = 1;
            // 
            // buttonINGRESAR
            // 
            this.buttonINGRESAR.Location = new System.Drawing.Point(116, 180);
            this.buttonINGRESAR.Name = "buttonINGRESAR";
            this.buttonINGRESAR.Size = new System.Drawing.Size(124, 23);
            this.buttonINGRESAR.TabIndex = 2;
            this.buttonINGRESAR.Text = "Registrar Resultado";
            this.buttonINGRESAR.UseVisualStyleBackColor = true;
            this.buttonINGRESAR.Click += new System.EventHandler(this.buttonINGRESAR_Click);
            // 
            // labelPROF
            // 
            this.labelPROF.AutoSize = true;
            this.labelPROF.Location = new System.Drawing.Point(12, 96);
            this.labelPROF.Name = "labelPROF";
            this.labelPROF.Size = new System.Drawing.Size(299, 13);
            this.labelPROF.TabIndex = 3;
            this.labelPROF.Text = "Ingrese el Número de Profesional para validar esta Operación:";
            // 
            // textBoxPROF
            // 
            this.textBoxPROF.Location = new System.Drawing.Point(82, 132);
            this.textBoxPROF.Name = "textBoxPROF";
            this.textBoxPROF.Size = new System.Drawing.Size(208, 20);
            this.textBoxPROF.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IngresoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPROF);
            this.Controls.Add(this.labelPROF);
            this.Controls.Add(this.buttonINGRESAR);
            this.Controls.Add(this.textBoxNUMEROTURNO);
            this.Controls.Add(this.label1);
            this.Name = "IngresoTurno";
            this.Text = "Registro de Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNUMEROTURNO;
        private System.Windows.Forms.Button buttonINGRESAR;
        private System.Windows.Forms.Label labelPROF;
        private System.Windows.Forms.TextBox textBoxPROF;
        private System.Windows.Forms.Button button1;
    }
}