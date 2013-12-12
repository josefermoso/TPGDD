namespace Clinica_Frba.Pedir_Turno
{
    partial class SeleccionProfesionalPorEspecialidad
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
            this.especialidad = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.profesionales = new System.Windows.Forms.DataGridView();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // especialidad
            // 
            this.especialidad.FormattingEnabled = true;
            this.especialidad.Location = new System.Drawing.Point(32, 70);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(227, 21);
            this.especialidad.TabIndex = 0;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(277, 68);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(147, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // profesionales
            // 
            this.profesionales.AllowUserToAddRows = false;
            this.profesionales.AllowUserToDeleteRows = false;
            this.profesionales.AllowUserToOrderColumns = true;
            this.profesionales.AllowUserToResizeColumns = false;
            this.profesionales.AllowUserToResizeRows = false;
            this.profesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profesionales.Location = new System.Drawing.Point(32, 112);
            this.profesionales.MultiSelect = false;
            this.profesionales.Name = "profesionales";
            this.profesionales.ReadOnly = true;
            this.profesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profesionales.Size = new System.Drawing.Size(392, 126);
            this.profesionales.TabIndex = 2;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(259, 262);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 3;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(349, 262);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elija el ID del profesional o una especialidad:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(136, 44);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(123, 20);
            this.id.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // SeleccionProfesionalPorEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.profesionales);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.especialidad);
            this.Name = "SeleccionProfesionalPorEspecialidad";
            this.Text = "Seleccionar profesional";
            ((System.ComponentModel.ISupportInitialize)(this.profesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox especialidad;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView profesionales;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
    }
}