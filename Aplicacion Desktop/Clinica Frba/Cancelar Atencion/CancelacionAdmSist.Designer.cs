namespace Clinica_Frba.Cancelar_Atencion
{
    partial class CancelacionAdmSist
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
            this.buttonProfesional = new System.Windows.Forms.Button();
            this.buttonAfiliado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNroAoP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProfesional
            // 
            this.buttonProfesional.Location = new System.Drawing.Point(12, 87);
            this.buttonProfesional.Name = "buttonProfesional";
            this.buttonProfesional.Size = new System.Drawing.Size(75, 23);
            this.buttonProfesional.TabIndex = 0;
            this.buttonProfesional.Text = "Profesional";
            this.buttonProfesional.UseVisualStyleBackColor = true;
            this.buttonProfesional.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAfiliado
            // 
            this.buttonAfiliado.Location = new System.Drawing.Point(152, 87);
            this.buttonAfiliado.Name = "buttonAfiliado";
            this.buttonAfiliado.Size = new System.Drawing.Size(75, 23);
            this.buttonAfiliado.TabIndex = 1;
            this.buttonAfiliado.Text = "Afiliado";
            this.buttonAfiliado.UseVisualStyleBackColor = true;
            this.buttonAfiliado.Click += new System.EventHandler(this.buttonAfiliado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el numero de Afiliado o Profesional segun la cancelacion a realizar";
            // 
            // textBoxNroAoP
            // 
            this.textBoxNroAoP.Location = new System.Drawing.Point(12, 25);
            this.textBoxNroAoP.Name = "textBoxNroAoP";
            this.textBoxNroAoP.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroAoP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elija la cancelacion a la cual desea acceder";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CancelacionAdmSist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNroAoP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAfiliado);
            this.Controls.Add(this.buttonProfesional);
            this.Name = "CancelacionAdmSist";
            this.Text = "CancelacionAdmSist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProfesional;
        private System.Windows.Forms.Button buttonAfiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNroAoP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}