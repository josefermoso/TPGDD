namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class RegistroResultadoAtencion
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
            this.checkBoxATENDIDO = new System.Windows.Forms.CheckBox();
            this.dateTimePickerHoraFin = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerFECHA = new System.Windows.Forms.DateTimePicker();
            this.labelFECHA = new System.Windows.Forms.Label();
            this.textBoxDIAGNOSTICO = new System.Windows.Forms.TextBox();
            this.labelDIAGNOSTICO = new System.Windows.Forms.Label();
            this.labelSINTOMAS = new System.Windows.Forms.Label();
            this.textBoxSINTOMAS = new System.Windows.Forms.TextBox();
            this.checkBoxRECETA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxATENDIDO
            // 
            this.checkBoxATENDIDO.AutoSize = true;
            this.checkBoxATENDIDO.Location = new System.Drawing.Point(12, 25);
            this.checkBoxATENDIDO.Name = "checkBoxATENDIDO";
            this.checkBoxATENDIDO.Size = new System.Drawing.Size(199, 17);
            this.checkBoxATENDIDO.TabIndex = 0;
            this.checkBoxATENDIDO.Text = "¿Ocurrió Efectivamente la Atención?";
            this.checkBoxATENDIDO.UseVisualStyleBackColor = true;
            this.checkBoxATENDIDO.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePickerHORA
            // 
            this.dateTimePickerHoraFin.CausesValidation = false;
            this.dateTimePickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFin.Location = new System.Drawing.Point(248, 90);
            this.dateTimePickerHoraFin.Name = "dateTimePickerHORA";
            this.dateTimePickerHoraFin.ShowUpDown = true;
            this.dateTimePickerHoraFin.Size = new System.Drawing.Size(78, 20);
            this.dateTimePickerHoraFin.TabIndex = 1;
            this.dateTimePickerHoraFin.Value = new System.DateTime(2013, 11, 4, 0, 0, 0, 0);
            this.dateTimePickerHoraFin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar Resultado de Atención";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerFECHA
            // 
            this.dateTimePickerFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFECHA.Location = new System.Drawing.Point(11, 90);
            this.dateTimePickerFECHA.MaxDate = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            this.dateTimePickerFECHA.MinDate = new System.DateTime(2013, 11, 15, 0, 0, 0, 0);
            this.dateTimePickerFECHA.Name = "dateTimePickerFECHA";
            this.dateTimePickerFECHA.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFECHA.TabIndex = 3;
            this.dateTimePickerFECHA.Value = new System.DateTime(2013, 11, 15, 23, 23, 0, 0);
            // 
            // labelFECHA
            // 
            this.labelFECHA.AutoSize = true;
            this.labelFECHA.Location = new System.Drawing.Point(77, 60);
            this.labelFECHA.Name = "labelFECHA";
            this.labelFECHA.Size = new System.Drawing.Size(205, 13);
            this.labelFECHA.TabIndex = 4;
            this.labelFECHA.Text = "Ingrese Fecha y Hora Real de la Atención";
            // 
            // textBoxDIAGNOSTICO
            // 
            this.textBoxDIAGNOSTICO.Location = new System.Drawing.Point(12, 164);
            this.textBoxDIAGNOSTICO.Name = "textBoxDIAGNOSTICO";
            this.textBoxDIAGNOSTICO.Size = new System.Drawing.Size(314, 20);
            this.textBoxDIAGNOSTICO.TabIndex = 5;
            // 
            // labelDIAGNOSTICO
            // 
            this.labelDIAGNOSTICO.AutoSize = true;
            this.labelDIAGNOSTICO.Location = new System.Drawing.Point(8, 137);
            this.labelDIAGNOSTICO.Name = "labelDIAGNOSTICO";
            this.labelDIAGNOSTICO.Size = new System.Drawing.Size(182, 13);
            this.labelDIAGNOSTICO.TabIndex = 6;
            this.labelDIAGNOSTICO.Text = "Ingrese el Diagnóstico de la Consulta";
            // 
            // labelSINTOMAS
            // 
            this.labelSINTOMAS.AutoSize = true;
            this.labelSINTOMAS.Location = new System.Drawing.Point(8, 207);
            this.labelSINTOMAS.Name = "labelSINTOMAS";
            this.labelSINTOMAS.Size = new System.Drawing.Size(168, 13);
            this.labelSINTOMAS.TabIndex = 7;
            this.labelSINTOMAS.Text = "Ingrese los Síntomas del Paciente";
            // 
            // textBoxSINTOMAS
            // 
            this.textBoxSINTOMAS.Location = new System.Drawing.Point(11, 235);
            this.textBoxSINTOMAS.Name = "textBoxSINTOMAS";
            this.textBoxSINTOMAS.Size = new System.Drawing.Size(314, 20);
            this.textBoxSINTOMAS.TabIndex = 8;
            // 
            // checkBoxRECETA
            // 
            this.checkBoxRECETA.AutoSize = true;
            this.checkBoxRECETA.Location = new System.Drawing.Point(12, 288);
            this.checkBoxRECETA.Name = "checkBoxRECETA";
            this.checkBoxRECETA.Size = new System.Drawing.Size(279, 17);
            this.checkBoxRECETA.TabIndex = 9;
            this.checkBoxRECETA.Text = "¿Desea generar una receta a partir de esta atención?";
            this.checkBoxRECETA.UseVisualStyleBackColor = true;
            // 
            // RegistroResultadoAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 368);
            this.Controls.Add(this.checkBoxRECETA);
            this.Controls.Add(this.textBoxSINTOMAS);
            this.Controls.Add(this.labelSINTOMAS);
            this.Controls.Add(this.labelDIAGNOSTICO);
            this.Controls.Add(this.textBoxDIAGNOSTICO);
            this.Controls.Add(this.labelFECHA);
            this.Controls.Add(this.dateTimePickerFECHA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerHoraFin);
            this.Controls.Add(this.checkBoxATENDIDO);
            this.Name = "RegistroResultadoAtencion";
            this.Text = "Registro de Resultado de Atencion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxATENDIDO;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFECHA;
        private System.Windows.Forms.Label labelFECHA;
        private System.Windows.Forms.TextBox textBoxDIAGNOSTICO;
        private System.Windows.Forms.Label labelDIAGNOSTICO;
        private System.Windows.Forms.Label labelSINTOMAS;
        private System.Windows.Forms.TextBox textBoxSINTOMAS;
        private System.Windows.Forms.CheckBox checkBoxRECETA;
    }
}