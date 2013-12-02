namespace Clinica_Frba.Cancelar_Atencion
{
    partial class CancelacionProf
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxApe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNDoc = new System.Windows.Forms.TextBox();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.labelMotivo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSelecDia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDiaElegido = new System.Windows.Forms.TextBox();
            this.monthCalendarDia = new System.Windows.Forms.MonthCalendar();
            this.buttonAcepDia = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAceptarPeriodo = new System.Windows.Forms.Button();
            this.buttonSelHasta = new System.Windows.Forms.Button();
            this.buttonSelDesd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHasta = new System.Windows.Forms.TextBox();
            this.textBoxDesde = new System.Windows.Forms.TextBox();
            this.monthCalendarPeriodo = new System.Windows.Forms.MonthCalendar();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id del profesional";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(16, 20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(122, 20);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 4;
            // 
            // textBoxApe
            // 
            this.textBoxApe.Location = new System.Drawing.Point(228, 20);
            this.textBoxApe.Name = "textBoxApe";
            this.textBoxApe.ReadOnly = true;
            this.textBoxApe.Size = new System.Drawing.Size(100, 20);
            this.textBoxApe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nro Documento";
            // 
            // textBoxNDoc
            // 
            this.textBoxNDoc.Location = new System.Drawing.Point(334, 19);
            this.textBoxNDoc.Name = "textBoxNDoc";
            this.textBoxNDoc.ReadOnly = true;
            this.textBoxNDoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxNDoc.TabIndex = 8;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(338, 69);
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(195, 148);
            this.textBoxMotivo.TabIndex = 9;
            // 
            // labelMotivo
            // 
            this.labelMotivo.AutoSize = true;
            this.labelMotivo.Location = new System.Drawing.Point(335, 47);
            this.labelMotivo.Name = "labelMotivo";
            this.labelMotivo.Size = new System.Drawing.Size(103, 13);
            this.labelMotivo.TabIndex = 10;
            this.labelMotivo.Text = "Motivo cancelacion:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(312, 214);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSelecDia);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxDiaElegido);
            this.tabPage1.Controls.Add(this.monthCalendarDia);
            this.tabPage1.Controls.Add(this.buttonAcepDia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cancelacion por Dia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSelecDia
            // 
            this.buttonSelecDia.Location = new System.Drawing.Point(188, 125);
            this.buttonSelecDia.Name = "buttonSelecDia";
            this.buttonSelecDia.Size = new System.Drawing.Size(100, 23);
            this.buttonSelecDia.TabIndex = 17;
            this.buttonSelecDia.Text = "Seleccionar";
            this.buttonSelecDia.UseVisualStyleBackColor = true;
            this.buttonSelecDia.Click += new System.EventHandler(this.buttonSelecDia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Eliga el dia a cancelar su atencion medica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dia elegido:";
            // 
            // textBoxDiaElegido
            // 
            this.textBoxDiaElegido.Location = new System.Drawing.Point(188, 83);
            this.textBoxDiaElegido.Name = "textBoxDiaElegido";
            this.textBoxDiaElegido.ReadOnly = true;
            this.textBoxDiaElegido.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiaElegido.TabIndex = 14;
            // 
            // monthCalendarDia
            // 
            this.monthCalendarDia.Location = new System.Drawing.Point(0, 32);
            this.monthCalendarDia.Name = "monthCalendarDia";
            this.monthCalendarDia.TabIndex = 13;
            // 
            // buttonAcepDia
            // 
            this.buttonAcepDia.Location = new System.Drawing.Point(188, 165);
            this.buttonAcepDia.Name = "buttonAcepDia";
            this.buttonAcepDia.Size = new System.Drawing.Size(100, 23);
            this.buttonAcepDia.TabIndex = 12;
            this.buttonAcepDia.Text = "Aceptar";
            this.buttonAcepDia.UseVisualStyleBackColor = true;
            this.buttonAcepDia.Click += new System.EventHandler(this.buttonAcepDia_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.buttonAceptarPeriodo);
            this.tabPage2.Controls.Add(this.buttonSelHasta);
            this.tabPage2.Controls.Add(this.buttonSelDesd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxHasta);
            this.tabPage2.Controls.Add(this.textBoxDesde);
            this.tabPage2.Controls.Add(this.monthCalendarPeriodo);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(304, 188);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cancelar por Periodo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Eliga el dia a cancelar su atencion medica";
            // 
            // buttonAceptarPeriodo
            // 
            this.buttonAceptarPeriodo.Location = new System.Drawing.Point(183, 165);
            this.buttonAceptarPeriodo.Name = "buttonAceptarPeriodo";
            this.buttonAceptarPeriodo.Size = new System.Drawing.Size(100, 23);
            this.buttonAceptarPeriodo.TabIndex = 20;
            this.buttonAceptarPeriodo.Text = "Aceptar";
            this.buttonAceptarPeriodo.UseVisualStyleBackColor = true;
            this.buttonAceptarPeriodo.Click += new System.EventHandler(this.buttonAceptarPeriodo_Click);
            // 
            // buttonSelHasta
            // 
            this.buttonSelHasta.Location = new System.Drawing.Point(183, 136);
            this.buttonSelHasta.Name = "buttonSelHasta";
            this.buttonSelHasta.Size = new System.Drawing.Size(100, 23);
            this.buttonSelHasta.TabIndex = 19;
            this.buttonSelHasta.Text = "Seleccionar";
            this.buttonSelHasta.UseVisualStyleBackColor = true;
            this.buttonSelHasta.Click += new System.EventHandler(this.buttonSelHasta_Click);
            // 
            // buttonSelDesd
            // 
            this.buttonSelDesd.Location = new System.Drawing.Point(183, 68);
            this.buttonSelDesd.Name = "buttonSelDesd";
            this.buttonSelDesd.Size = new System.Drawing.Size(100, 23);
            this.buttonSelDesd.TabIndex = 18;
            this.buttonSelDesd.Text = "Seleccionar";
            this.buttonSelDesd.UseVisualStyleBackColor = true;
            this.buttonSelDesd.Click += new System.EventHandler(this.buttonSelDesd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Periodo desde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hasta:";
            // 
            // textBoxHasta
            // 
            this.textBoxHasta.Location = new System.Drawing.Point(183, 110);
            this.textBoxHasta.Name = "textBoxHasta";
            this.textBoxHasta.ReadOnly = true;
            this.textBoxHasta.Size = new System.Drawing.Size(100, 20);
            this.textBoxHasta.TabIndex = 6;
            // 
            // textBoxDesde
            // 
            this.textBoxDesde.Location = new System.Drawing.Point(183, 42);
            this.textBoxDesde.Name = "textBoxDesde";
            this.textBoxDesde.ReadOnly = true;
            this.textBoxDesde.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesde.TabIndex = 5;
            // 
            // monthCalendarPeriodo
            // 
            this.monthCalendarPeriodo.Location = new System.Drawing.Point(0, 33);
            this.monthCalendarPeriodo.Name = "monthCalendarPeriodo";
            this.monthCalendarPeriodo.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(338, 238);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 12;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(458, 238);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 13;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // CancelacionProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 273);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelMotivo);
            this.Controls.Add(this.textBoxMotivo);
            this.Controls.Add(this.textBoxNDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApe);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Name = "CancelacionProf";
            this.Text = "CancelacionProf";
            this.Load += new System.EventHandler(this.CancelacionProf_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNDoc;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.Label labelMotivo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MonthCalendar monthCalendarDia;
        private System.Windows.Forms.Button buttonAcepDia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSelecDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDiaElegido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAceptarPeriodo;
        private System.Windows.Forms.Button buttonSelHasta;
        private System.Windows.Forms.Button buttonSelDesd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHasta;
        private System.Windows.Forms.TextBox textBoxDesde;
        private System.Windows.Forms.MonthCalendar monthCalendarPeriodo;
    }
}