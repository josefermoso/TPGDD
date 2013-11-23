namespace Clinica_Frba.Generar_Receta
{
    partial class CantidadDeMedicamentos
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
            this.comboBoxCANTIDAD = new System.Windows.Forms.ComboBox();
            this.buttonACEPTAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la cantidad a recetar:";
            // 
            // comboBoxCANTIDAD
            // 
            this.comboBoxCANTIDAD.FormattingEnabled = true;
            this.comboBoxCANTIDAD.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxCANTIDAD.Location = new System.Drawing.Point(187, 21);
            this.comboBoxCANTIDAD.Name = "comboBoxCANTIDAD";
            this.comboBoxCANTIDAD.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCANTIDAD.TabIndex = 1;
            this.comboBoxCANTIDAD.SelectedIndexChanged += new System.EventHandler(this.comboBoxCANTIDAD_SelectedIndexChanged);
            // 
            // buttonACEPTAR
            // 
            this.buttonACEPTAR.Location = new System.Drawing.Point(125, 59);
            this.buttonACEPTAR.Name = "buttonACEPTAR";
            this.buttonACEPTAR.Size = new System.Drawing.Size(75, 23);
            this.buttonACEPTAR.TabIndex = 2;
            this.buttonACEPTAR.Text = "Aceptar";
            this.buttonACEPTAR.UseVisualStyleBackColor = true;
            this.buttonACEPTAR.Click += new System.EventHandler(this.buttonACEPTAR_Click);
            // 
            // CantidadDeMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 92);
            this.Controls.Add(this.buttonACEPTAR);
            this.Controls.Add(this.comboBoxCANTIDAD);
            this.Controls.Add(this.label1);
            this.Name = "CantidadDeMedicamentos";
            this.Text = "Cantidad a Recetar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCANTIDAD;
        private System.Windows.Forms.Button buttonACEPTAR;
    }
}