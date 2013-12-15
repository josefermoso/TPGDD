namespace Clinica_Frba.Listados_Estadisticos
{
    partial class ResultadoListado
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
            this.dataGridViewLISTADO = new System.Windows.Forms.DataGridView();
            this.buttonCANCELAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLISTADO)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLISTADO
            // 
            this.dataGridViewLISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLISTADO.Location = new System.Drawing.Point(36, 12);
            this.dataGridViewLISTADO.Name = "dataGridViewLISTADO";
            this.dataGridViewLISTADO.Size = new System.Drawing.Size(708, 206);
            this.dataGridViewLISTADO.TabIndex = 0;
            // 
            // buttonCANCELAR
            // 
            this.buttonCANCELAR.Location = new System.Drawing.Point(340, 234);
            this.buttonCANCELAR.Name = "buttonCANCELAR";
            this.buttonCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCELAR.TabIndex = 1;
            this.buttonCANCELAR.Text = "Cancelar";
            this.buttonCANCELAR.UseVisualStyleBackColor = true;
            this.buttonCANCELAR.Click += new System.EventHandler(this.buttonCANCELAR_Click);
            // 
            // ResultadoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 272);
            this.Controls.Add(this.buttonCANCELAR);
            this.Controls.Add(this.dataGridViewLISTADO);
            this.Name = "ResultadoListado";
            this.Text = "ResultadoListado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLISTADO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLISTADO;
        private System.Windows.Forms.Button buttonCANCELAR;
    }
}