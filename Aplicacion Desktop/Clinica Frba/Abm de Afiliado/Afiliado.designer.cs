namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class Afiliado
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
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_NumeroAfiliado = new System.Windows.Forms.Label();
            this.textBox_NumeroDoc = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_planMedico = new System.Windows.Forms.ComboBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.button_accion = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_AgregarMiembro = new System.Windows.Forms.Button();
            this.comboBox_sexo = new System.Windows.Forms.ComboBox();
            this.comboBox_tipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.comboBox_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(364, 93);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(185, 20);
            this.textBox_Apellido.TabIndex = 3;
            this.textBox_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Apellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Location = new System.Drawing.Point(304, 127);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.labelEstadoCivil.TabIndex = 26;
            this.labelEstadoCivil.Text = "Estado Civil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Plan médico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Numero Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tipo Documento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Numero Afiliado:";
            // 
            // label_NumeroAfiliado
            // 
            this.label_NumeroAfiliado.AutoSize = true;
            this.label_NumeroAfiliado.Location = new System.Drawing.Point(118, 33);
            this.label_NumeroAfiliado.Name = "label_NumeroAfiliado";
            this.label_NumeroAfiliado.Size = new System.Drawing.Size(28, 13);
            this.label_NumeroAfiliado.TabIndex = 28;
            this.label_NumeroAfiliado.Text = "XXX";
            // 
            // textBox_NumeroDoc
            // 
            this.textBox_NumeroDoc.Location = new System.Drawing.Point(415, 62);
            this.textBox_NumeroDoc.Name = "textBox_NumeroDoc";
            this.textBox_NumeroDoc.Size = new System.Drawing.Size(134, 20);
            this.textBox_NumeroDoc.TabIndex = 30;
            this.textBox_NumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumeroDoc_KeyPress);
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(88, 159);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(185, 20);
            this.textBox_Mail.TabIndex = 33;
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(88, 190);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(185, 20);
            this.textBox_Direccion.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(406, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // comboBox_planMedico
            // 
            this.comboBox_planMedico.FormattingEnabled = true;
            this.comboBox_planMedico.Location = new System.Drawing.Point(384, 185);
            this.comboBox_planMedico.Name = "comboBox_planMedico";
            this.comboBox_planMedico.Size = new System.Drawing.Size(165, 21);
            this.comboBox_planMedico.TabIndex = 36;
            this.comboBox_planMedico.SelectedIndexChanged += new System.EventHandler(this.comboBox_planMedico_SelectedIndexChanged);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(88, 224);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(185, 20);
            this.textBox_Telefono.TabIndex = 37;
            this.textBox_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telefono_KeyPress);
            // 
            // button_accion
            // 
            this.button_accion.Location = new System.Drawing.Point(364, 266);
            this.button_accion.Name = "button_accion";
            this.button_accion.Size = new System.Drawing.Size(75, 23);
            this.button_accion.TabIndex = 38;
            this.button_accion.Text = "Confirmar";
            this.button_accion.UseVisualStyleBackColor = true;
            this.button_accion.Click += new System.EventHandler(this.button_accion_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(455, 266);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 39;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_AgregarMiembro
            // 
            this.button_AgregarMiembro.Location = new System.Drawing.Point(442, 217);
            this.button_AgregarMiembro.Name = "button_AgregarMiembro";
            this.button_AgregarMiembro.Size = new System.Drawing.Size(107, 23);
            this.button_AgregarMiembro.TabIndex = 40;
            this.button_AgregarMiembro.Text = "Agregar Miembro";
            this.button_AgregarMiembro.UseVisualStyleBackColor = true;
            this.button_AgregarMiembro.Click += new System.EventHandler(this.button_AgregarMiembro_Click);
            // 
            // comboBox_sexo
            // 
            this.comboBox_sexo.FormattingEnabled = true;
            this.comboBox_sexo.Location = new System.Drawing.Point(88, 123);
            this.comboBox_sexo.Name = "comboBox_sexo";
            this.comboBox_sexo.Size = new System.Drawing.Size(185, 21);
            this.comboBox_sexo.TabIndex = 41;
            // 
            // comboBox_tipoDocumento
            // 
            this.comboBox_tipoDocumento.FormattingEnabled = true;
            this.comboBox_tipoDocumento.Location = new System.Drawing.Point(121, 62);
            this.comboBox_tipoDocumento.Name = "comboBox_tipoDocumento";
            this.comboBox_tipoDocumento.Size = new System.Drawing.Size(152, 21);
            this.comboBox_tipoDocumento.TabIndex = 42;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(88, 93);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(185, 20);
            this.textBox_Nom.TabIndex = 43;
            this.textBox_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nom_KeyPress);
            // 
            // comboBox_EstadoCivil
            // 
            this.comboBox_EstadoCivil.FormattingEnabled = true;
            this.comboBox_EstadoCivil.Location = new System.Drawing.Point(384, 123);
            this.comboBox_EstadoCivil.Name = "comboBox_EstadoCivil";
            this.comboBox_EstadoCivil.Size = new System.Drawing.Size(165, 21);
            this.comboBox_EstadoCivil.TabIndex = 44;
            this.comboBox_EstadoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBox_EstadoCivil_SelectedIndexChanged);
            // 
            // Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 312);
            this.Controls.Add(this.comboBox_EstadoCivil);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.comboBox_tipoDocumento);
            this.Controls.Add(this.comboBox_sexo);
            this.Controls.Add(this.button_AgregarMiembro);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_accion);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.comboBox_planMedico);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_NumeroDoc);
            this.Controls.Add(this.label_NumeroAfiliado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelEstadoCivil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Afiliado";
            this.Text = "Afiliado";
            this.Load += new System.EventHandler(this.Afiliado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEstadoCivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_NumeroAfiliado;
        private System.Windows.Forms.TextBox textBox_NumeroDoc;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_planMedico;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Button button_accion;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_AgregarMiembro;
        private System.Windows.Forms.ComboBox comboBox_sexo;
        private System.Windows.Forms.ComboBox comboBox_tipoDocumento;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.ComboBox comboBox_EstadoCivil;
    }
}