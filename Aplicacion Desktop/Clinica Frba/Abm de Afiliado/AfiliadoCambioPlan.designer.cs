namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class AfiliadoCambioPlan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_cambioPlan = new System.Windows.Forms.TextBox();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivos de cambio de plan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox_cambioPlan
            // 
            this.textBox_cambioPlan.Location = new System.Drawing.Point(71, 57);
            this.textBox_cambioPlan.Name = "textBox_cambioPlan";
            this.textBox_cambioPlan.Size = new System.Drawing.Size(100, 20);
            this.textBox_cambioPlan.TabIndex = 2;
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(71, 119);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 3;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // AfiliadoCambioPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 179);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.textBox_cambioPlan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AfiliadoCambioPlan";
            this.Text = "AfiliadoCambioPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_cambioPlan;
        private System.Windows.Forms.Button button_Aceptar;
    }
}