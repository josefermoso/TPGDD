namespace Clinica_Frba.Pedir_Turno
{
    partial class PedidoDeTurno
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
            this.info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seleccionarProfesional = new System.Windows.Forms.Button();
            this.seleccionarAfiliado = new System.Windows.Forms.Button();
            this.profesionalLabel = new System.Windows.Forms.Label();
            this.afiliadoLabel = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.turnos = new System.Windows.Forms.DataGridView();
            this.buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(58, 21);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(375, 13);
            this.info.TabIndex = 0;
            this.info.Text = "A continuación seleccione el profesional, el afiliado y el día y horario del turn" +
                "o:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profesional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Afiliado:";
            // 
            // seleccionarProfesional
            // 
            this.seleccionarProfesional.Location = new System.Drawing.Point(64, 53);
            this.seleccionarProfesional.Name = "seleccionarProfesional";
            this.seleccionarProfesional.Size = new System.Drawing.Size(372, 23);
            this.seleccionarProfesional.TabIndex = 3;
            this.seleccionarProfesional.Text = "Seleccionar un profesional";
            this.seleccionarProfesional.UseVisualStyleBackColor = true;
            this.seleccionarProfesional.Click += new System.EventHandler(this.seleccionarProfesional_Click);
            // 
            // seleccionarAfiliado
            // 
            this.seleccionarAfiliado.Location = new System.Drawing.Point(64, 83);
            this.seleccionarAfiliado.Name = "seleccionarAfiliado";
            this.seleccionarAfiliado.Size = new System.Drawing.Size(372, 23);
            this.seleccionarAfiliado.TabIndex = 4;
            this.seleccionarAfiliado.Text = "Seleccionar un afiliado";
            this.seleccionarAfiliado.UseVisualStyleBackColor = true;
            this.seleccionarAfiliado.Click += new System.EventHandler(this.seleccionarAfiliado_Click);
            // 
            // profesionalLabel
            // 
            this.profesionalLabel.AutoSize = true;
            this.profesionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesionalLabel.Location = new System.Drawing.Point(130, 126);
            this.profesionalLabel.Name = "profesionalLabel";
            this.profesionalLabel.Size = new System.Drawing.Size(196, 13);
            this.profesionalLabel.TabIndex = 5;
            this.profesionalLabel.Text = "No seleccionó ningún profesional";
            // 
            // afiliadoLabel
            // 
            this.afiliadoLabel.AutoSize = true;
            this.afiliadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afiliadoLabel.Location = new System.Drawing.Point(129, 149);
            this.afiliadoLabel.Name = "afiliadoLabel";
            this.afiliadoLabel.Size = new System.Drawing.Size(175, 13);
            this.afiliadoLabel.TabIndex = 6;
            this.afiliadoLabel.Text = "No seleccionó ningún afiliado";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(321, 373);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(407, 373);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // turnos
            // 
            this.turnos.AllowUserToAddRows = false;
            this.turnos.AllowUserToDeleteRows = false;
            this.turnos.AllowUserToOrderColumns = true;
            this.turnos.AllowUserToResizeColumns = false;
            this.turnos.AllowUserToResizeRows = false;
            this.turnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnos.Location = new System.Drawing.Point(28, 212);
            this.turnos.MultiSelect = false;
            this.turnos.Name = "turnos";
            this.turnos.ReadOnly = true;
            this.turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.turnos.Size = new System.Drawing.Size(437, 144);
            this.turnos.TabIndex = 12;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(28, 183);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(437, 23);
            this.buscar.TabIndex = 13;
            this.buscar.Text = "Buscar turnos disponibles";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // PedidoDeTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 408);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.turnos);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.afiliadoLabel);
            this.Controls.Add(this.profesionalLabel);
            this.Controls.Add(this.seleccionarAfiliado);
            this.Controls.Add(this.seleccionarProfesional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Name = "PedidoDeTurno";
            this.Text = "Pedir turno";
            ((System.ComponentModel.ISupportInitialize)(this.turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button seleccionarProfesional;
        private System.Windows.Forms.Button seleccionarAfiliado;
        private System.Windows.Forms.Label profesionalLabel;
        private System.Windows.Forms.Label afiliadoLabel;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.DataGridView turnos;
        private System.Windows.Forms.Button buscar;
    }
}