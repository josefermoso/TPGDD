namespace Clinica_Frba.Registrar_Agenda
{
    partial class Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDias = new System.Windows.Forms.ComboBox();
            this.Dia = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.Hasta = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.GroupBox();
            this.comboBoxMinutosDesde = new System.Windows.Forms.ComboBox();
            this.hrsDesde = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMinutosHasta = new System.Windows.Forms.ComboBox();
            this.hrsHasta = new System.Windows.Forms.NumericUpDown();
            this.AgregarDia = new System.Windows.Forms.Button();
            this.fechas = new System.Windows.Forms.GroupBox();
            this.seleccionarFechaHasta = new System.Windows.Forms.Button();
            this.seleccionarFechaDesde = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.finalizar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.agregarProfesional = new System.Windows.Forms.Button();
            this.labelNroProfesional = new System.Windows.Forms.Label();
            this.nroProfesional = new System.Windows.Forms.TextBox();
            this.Horario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hrsDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsHasta)).BeginInit();
            this.fechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDias
            // 
            this.comboBoxDias.FormattingEnabled = true;
            this.comboBoxDias.Location = new System.Drawing.Point(92, 58);
            this.comboBoxDias.Name = "comboBoxDias";
            this.comboBoxDias.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDias.TabIndex = 0;
            // 
            // Dia
            // 
            this.Dia.AutoSize = true;
            this.Dia.Location = new System.Drawing.Point(27, 66);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(23, 13);
            this.Dia.TabIndex = 1;
            this.Dia.Text = "Dia";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(51, 40);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 7;
            this.Desde.Text = "Desde";
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Location = new System.Drawing.Point(51, 121);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(35, 13);
            this.Hasta.TabIndex = 8;
            this.Hasta.Text = "Hasta";
            // 
            // Horario
            // 
            this.Horario.Controls.Add(this.comboBoxMinutosDesde);
            this.Horario.Controls.Add(this.hrsDesde);
            this.Horario.Controls.Add(this.comboBoxMinutosHasta);
            this.Horario.Controls.Add(this.Hasta);
            this.Horario.Controls.Add(this.hrsHasta);
            this.Horario.Controls.Add(this.Desde);
            this.Horario.Location = new System.Drawing.Point(12, 100);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(341, 163);
            this.Horario.TabIndex = 9;
            this.Horario.TabStop = false;
            this.Horario.Text = "Horarios";
            // 
            // comboBoxMinutosDesde
            // 
            this.comboBoxMinutosDesde.FormattingEnabled = true;
            this.comboBoxMinutosDesde.Items.AddRange(new object[] {
            0,
            30});
            this.comboBoxMinutosDesde.Location = new System.Drawing.Point(249, 113);
            this.comboBoxMinutosDesde.Name = "comboBoxMinutosDesde";
            this.comboBoxMinutosDesde.Size = new System.Drawing.Size(40, 21);
            this.comboBoxMinutosDesde.TabIndex = 9;
            // 
            // hrsDesde
            // 
            this.hrsDesde.Location = new System.Drawing.Point(114, 32);
            this.hrsDesde.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.hrsDesde.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.hrsDesde.Name = "hrsDesde";
            this.hrsDesde.Size = new System.Drawing.Size(45, 20);
            this.hrsDesde.TabIndex = 4;
            this.hrsDesde.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // comboBoxMinutosHasta
            // 
            this.comboBoxMinutosHasta.FormattingEnabled = true;
            this.comboBoxMinutosHasta.Items.AddRange(new object[] {
            0,
            30});
            this.comboBoxMinutosHasta.Location = new System.Drawing.Point(249, 32);
            this.comboBoxMinutosHasta.Name = "comboBoxMinutosHasta";
            this.comboBoxMinutosHasta.Size = new System.Drawing.Size(40, 21);
            this.comboBoxMinutosHasta.TabIndex = 6;
            // 
            // hrsHasta
            // 
            this.hrsHasta.Location = new System.Drawing.Point(114, 114);
            this.hrsHasta.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.hrsHasta.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.hrsHasta.Name = "hrsHasta";
            this.hrsHasta.Size = new System.Drawing.Size(45, 20);
            this.hrsHasta.TabIndex = 5;
            this.hrsHasta.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // AgregarDia
            // 
            this.AgregarDia.Location = new System.Drawing.Point(261, 56);
            this.AgregarDia.Name = "AgregarDia";
            this.AgregarDia.Size = new System.Drawing.Size(75, 23);
            this.AgregarDia.TabIndex = 10;
            this.AgregarDia.Text = "Agregar Dia";
            this.AgregarDia.UseVisualStyleBackColor = true;
            this.AgregarDia.Click += new System.EventHandler(this.AgregarDia_Click);
            // 
            // fechas
            // 
            this.fechas.Controls.Add(this.seleccionarFechaHasta);
            this.fechas.Controls.Add(this.seleccionarFechaDesde);
            this.fechas.Location = new System.Drawing.Point(406, 188);
            this.fechas.Name = "fechas";
            this.fechas.Size = new System.Drawing.Size(281, 75);
            this.fechas.TabIndex = 11;
            this.fechas.TabStop = false;
            this.fechas.Text = "Fechas";
            // 
            // seleccionarFechaHasta
            // 
            this.seleccionarFechaHasta.Location = new System.Drawing.Point(146, 28);
            this.seleccionarFechaHasta.Name = "seleccionarFechaHasta";
            this.seleccionarFechaHasta.Size = new System.Drawing.Size(75, 23);
            this.seleccionarFechaHasta.TabIndex = 14;
            this.seleccionarFechaHasta.Text = "Fecha hasta";
            this.seleccionarFechaHasta.UseVisualStyleBackColor = true;
            this.seleccionarFechaHasta.Click += new System.EventHandler(this.seleccionarFechaHasta_Click);
            // 
            // seleccionarFechaDesde
            // 
            this.seleccionarFechaDesde.Location = new System.Drawing.Point(55, 28);
            this.seleccionarFechaDesde.Name = "seleccionarFechaDesde";
            this.seleccionarFechaDesde.Size = new System.Drawing.Size(85, 23);
            this.seleccionarFechaDesde.TabIndex = 13;
            this.seleccionarFechaDesde.Text = "Fecha Desde";
            this.seleccionarFechaDesde.UseVisualStyleBackColor = true;
            this.seleccionarFechaDesde.Click += new System.EventHandler(this.seleccionarFechaDesde_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(456, 21);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(268, 287);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(85, 23);
            this.finalizar.TabIndex = 13;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(373, 287);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(85, 23);
            this.cancelar.TabIndex = 14;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // agregarProfesional
            // 
            this.agregarProfesional.Location = new System.Drawing.Point(261, 12);
            this.agregarProfesional.Name = "agregarProfesional";
            this.agregarProfesional.Size = new System.Drawing.Size(75, 23);
            this.agregarProfesional.TabIndex = 15;
            this.agregarProfesional.Text = "Validar";
            this.agregarProfesional.UseVisualStyleBackColor = true;
            this.agregarProfesional.Click += new System.EventHandler(this.agregarProfesional_Click);
            // 
            // labelNroProfesional
            // 
            this.labelNroProfesional.AutoSize = true;
            this.labelNroProfesional.Location = new System.Drawing.Point(27, 22);
            this.labelNroProfesional.Name = "labelNroProfesional";
            this.labelNroProfesional.Size = new System.Drawing.Size(35, 13);
            this.labelNroProfesional.TabIndex = 16;
            this.labelNroProfesional.Text = "Numero Profesional";
            // 
            // nroProfesional
            // 
            this.nroProfesional.Location = new System.Drawing.Point(92, 19);
            this.nroProfesional.Name = "nroProfesional";
            this.nroProfesional.Size = new System.Drawing.Size(121, 20);
            this.nroProfesional.TabIndex = 17;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 322);
            this.Controls.Add(this.nroProfesional);
            this.Controls.Add(this.labelNroProfesional);
            this.Controls.Add(this.agregarProfesional);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.fechas);
            this.Controls.Add(this.AgregarDia);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.comboBoxDias);
            this.Name = "Agenda";
            this.Text = "Personalizar Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load_1);
            this.Horario.ResumeLayout(false);
            this.Horario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hrsDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsHasta)).EndInit();
            this.fechas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDias;
        private System.Windows.Forms.Label Dia;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.GroupBox Horario;
        private System.Windows.Forms.NumericUpDown hrsDesde;
        private System.Windows.Forms.NumericUpDown hrsHasta;
        private System.Windows.Forms.Button AgregarDia;
        private System.Windows.Forms.ComboBox comboBoxMinutosHasta;
        private System.Windows.Forms.ComboBox comboBoxMinutosDesde;
        private System.Windows.Forms.GroupBox fechas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button seleccionarFechaDesde;
        private System.Windows.Forms.Button seleccionarFechaHasta;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button agregarProfesional;
        private System.Windows.Forms.Label labelNroProfesional;
        private System.Windows.Forms.TextBox nroProfesional;
    }
}