namespace Clinica_Frba.Abm_de_Profesional
{
    partial class SeleccionProfesional
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
            this.documento = new System.Windows.Forms.TextBox();
            this.documentoLabel = new System.Windows.Forms.Label();
            this.similares = new System.Windows.Forms.CheckBox();
            this.tipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoLabel = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.apellidolabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.grillaProfesional = new System.Windows.Forms.DataGridView();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.documento);
            this.groupBox1.Controls.Add(this.documentoLabel);
            this.groupBox1.Controls.Add(this.similares);
            this.groupBox1.Controls.Add(this.tipoDocumento);
            this.groupBox1.Controls.Add(this.tipoDocumentoLabel);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.apellidolabel);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.idlabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(408, 66);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(151, 20);
            this.documento.TabIndex = 4;
            // 
            // documentoLabel
            // 
            this.documentoLabel.AutoSize = true;
            this.documentoLabel.Location = new System.Drawing.Point(336, 69);
            this.documentoLabel.Name = "documentoLabel";
            this.documentoLabel.Size = new System.Drawing.Size(65, 13);
            this.documentoLabel.TabIndex = 20;
            this.documentoLabel.Text = "Documento:";
            // 
            // similares
            // 
            this.similares.AutoSize = true;
            this.similares.Location = new System.Drawing.Point(463, 102);
            this.similares.Name = "similares";
            this.similares.Size = new System.Drawing.Size(96, 17);
            this.similares.TabIndex = 5;
            this.similares.Text = "Incluir similares";
            this.similares.UseVisualStyleBackColor = true;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.FormattingEnabled = true;
            this.tipoDocumento.Location = new System.Drawing.Point(407, 29);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Size = new System.Drawing.Size(152, 21);
            this.tipoDocumento.TabIndex = 2;
            // 
            // tipoDocumentoLabel
            // 
            this.tipoDocumentoLabel.AutoSize = true;
            this.tipoDocumentoLabel.Location = new System.Drawing.Point(312, 33);
            this.tipoDocumentoLabel.Name = "tipoDocumentoLabel";
            this.tipoDocumentoLabel.Size = new System.Drawing.Size(89, 13);
            this.tipoDocumentoLabel.TabIndex = 18;
            this.tipoDocumentoLabel.Text = "Tipo Documento:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(65, 66);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(211, 20);
            this.apellido.TabIndex = 3;
            // 
            // apellidolabel
            // 
            this.apellidolabel.AutoSize = true;
            this.apellidolabel.Location = new System.Drawing.Point(12, 69);
            this.apellidolabel.Name = "apellidolabel";
            this.apellidolabel.Size = new System.Drawing.Size(47, 13);
            this.apellidolabel.TabIndex = 16;
            this.apellidolabel.Text = "Apellido:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(65, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(210, 20);
            this.id.TabIndex = 1;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(40, 32);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(19, 13);
            this.idlabel.TabIndex = 14;
            this.idlabel.Text = "Id:";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(451, 186);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(189, 23);
            this.buscar.TabIndex = 6;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(24, 186);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(189, 23);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // grillaProfesional
            // 
            this.grillaProfesional.AllowUserToAddRows = false;
            this.grillaProfesional.AllowUserToDeleteRows = false;
            this.grillaProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProfesional.Location = new System.Drawing.Point(24, 230);
            this.grillaProfesional.MultiSelect = false;
            this.grillaProfesional.Name = "grillaProfesional";
            this.grillaProfesional.ReadOnly = true;
            this.grillaProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProfesional.Size = new System.Drawing.Size(616, 157);
            this.grillaProfesional.TabIndex = 9;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(472, 405);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(565, 405);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // SeleccionProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 440);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.grillaProfesional);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeleccionProfesional";
            this.Text = "Seleccionar Profesional";
            this.Load += new System.EventHandler(this.SeleccionProfesional_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label apellidolabel;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label documentoLabel;
        private System.Windows.Forms.ComboBox tipoDocumento;
        private System.Windows.Forms.Label tipoDocumentoLabel;
        private System.Windows.Forms.CheckBox similares;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.DataGridView grillaProfesional;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
    }
}