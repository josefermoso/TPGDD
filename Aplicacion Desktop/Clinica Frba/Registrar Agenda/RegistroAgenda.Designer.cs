namespace Clinica_Frba.Registrar_Agenda
{
    partial class RegistroAgenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agregarDia = new System.Windows.Forms.Button();
            this.diasAgregados = new System.Windows.Forms.ListBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreProfesional = new System.Windows.Forms.Label();
            this.seleccionarProfesional = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fechaHasta);
            this.groupBox1.Controls.Add(this.fechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(425, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validez agenda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha desde:";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(139, 75);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 1;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(139, 40);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agregarDia);
            this.groupBox2.Controls.Add(this.diasAgregados);
            this.groupBox2.Location = new System.Drawing.Point(34, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Días agregados";
            // 
            // agregarDia
            // 
            this.agregarDia.Location = new System.Drawing.Point(67, 96);
            this.agregarDia.Name = "agregarDia";
            this.agregarDia.Size = new System.Drawing.Size(229, 23);
            this.agregarDia.TabIndex = 5;
            this.agregarDia.Text = "Agregar nuevo día";
            this.agregarDia.UseVisualStyleBackColor = true;
            this.agregarDia.Click += new System.EventHandler(this.agregarDia_Click);
            // 
            // diasAgregados
            // 
            this.diasAgregados.FormattingEnabled = true;
            this.diasAgregados.Location = new System.Drawing.Point(67, 26);
            this.diasAgregados.Name = "diasAgregados";
            this.diasAgregados.Size = new System.Drawing.Size(229, 56);
            this.diasAgregados.TabIndex = 4;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(718, 299);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(637, 299);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 5;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Profesional:";
            // 
            // nombreProfesional
            // 
            this.nombreProfesional.AutoSize = true;
            this.nombreProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProfesional.Location = new System.Drawing.Point(101, 101);
            this.nombreProfesional.Name = "nombreProfesional";
            this.nombreProfesional.Size = new System.Drawing.Size(196, 13);
            this.nombreProfesional.TabIndex = 7;
            this.nombreProfesional.Text = "No seleccionó ningún profesional";
            this.nombreProfesional.Click += new System.EventHandler(this.label4_Click);
            // 
            // seleccionarProfesional
            // 
            this.seleccionarProfesional.Location = new System.Drawing.Point(34, 62);
            this.seleccionarProfesional.Name = "seleccionarProfesional";
            this.seleccionarProfesional.Size = new System.Drawing.Size(759, 23);
            this.seleccionarProfesional.TabIndex = 8;
            this.seleccionarProfesional.Text = "Seleccionar un profesional";
            this.seleccionarProfesional.UseVisualStyleBackColor = true;
            this.seleccionarProfesional.Click += new System.EventHandler(this.seleccionarProfesional_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(31, 27);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(589, 13);
            this.info.TabIndex = 9;
            this.info.Text = "A continuación, seleccione el profesional que desea agregar su agenda y elija los" +
                " días y horarios en que atenderá el mismo:";
            // 
            // RegistroAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 341);
            this.Controls.Add(this.info);
            this.Controls.Add(this.seleccionarProfesional);
            this.Controls.Add(this.nombreProfesional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroAgenda";
            this.Text = "Registrar agenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button agregarDia;
        private System.Windows.Forms.ListBox diasAgregados;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreProfesional;
        private System.Windows.Forms.Button seleccionarProfesional;
        private System.Windows.Forms.Label info;
    }
}