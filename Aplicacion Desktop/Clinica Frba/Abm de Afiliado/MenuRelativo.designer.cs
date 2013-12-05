namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class MenuRelativo
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
            this.button_Conyugue = new System.Windows.Forms.Button();
            this.button_Relativo = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Conyugue
            // 
            this.button_Conyugue.Location = new System.Drawing.Point(59, 23);
            this.button_Conyugue.Name = "button_Conyugue";
            this.button_Conyugue.Size = new System.Drawing.Size(180, 64);
            this.button_Conyugue.TabIndex = 0;
            this.button_Conyugue.Text = "Agregar Conyugue";
            this.button_Conyugue.UseVisualStyleBackColor = true;
            this.button_Conyugue.Click += new System.EventHandler(this.button_Conyugue_Click);
            // 
            // button_Relativo
            // 
            this.button_Relativo.Location = new System.Drawing.Point(56, 104);
            this.button_Relativo.Name = "button_Relativo";
            this.button_Relativo.Size = new System.Drawing.Size(180, 64);
            this.button_Relativo.TabIndex = 1;
            this.button_Relativo.Text = "Agregar Relativo";
            this.button_Relativo.UseVisualStyleBackColor = true;
            this.button_Relativo.Click += new System.EventHandler(this.button_Relativo_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(56, 197);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(180, 64);
            this.button_Cancelar.TabIndex = 2;
            this.button_Cancelar.Text = "Volver";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // MenuRelativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Relativo);
            this.Controls.Add(this.button_Conyugue);
            this.Name = "MenuRelativo";
            this.Text = "Menu Relativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Conyugue;
        private System.Windows.Forms.Button button_Relativo;
        private System.Windows.Forms.Button button_Cancelar;
    }
}