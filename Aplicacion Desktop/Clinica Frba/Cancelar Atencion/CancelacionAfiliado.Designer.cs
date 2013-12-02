namespace Clinica_Frba.Cancelar_Atencion
{
    partial class CancelacionAfiliado
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
            this.labelNroAfil = new System.Windows.Forms.Label();
            this.textBoxNroAfil = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.dataGridViewTurnos = new System.Windows.Forms.DataGridView();
            this.groupBoxCancelar = new System.Windows.Forms.GroupBox();
            this.textBoxNumTurn = new System.Windows.Forms.TextBox();
            this.labelNumTurn = new System.Windows.Forms.Label();
            this.labelMotivo = new System.Windows.Forms.Label();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).BeginInit();
            this.groupBoxCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNroAfil
            // 
            this.labelNroAfil.AutoSize = true;
            this.labelNroAfil.Location = new System.Drawing.Point(12, 9);
            this.labelNroAfil.Name = "labelNroAfil";
            this.labelNroAfil.Size = new System.Drawing.Size(98, 13);
            this.labelNroAfil.TabIndex = 2;
            this.labelNroAfil.Text = "Numero de afiliado:";
            // 
            // textBoxNroAfil
            // 
            this.textBoxNroAfil.Location = new System.Drawing.Point(15, 25);
            this.textBoxNroAfil.Name = "textBoxNroAfil";
            this.textBoxNroAfil.ReadOnly = true;
            this.textBoxNroAfil.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroAfil.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(141, 25);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(145, 23);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar Turnos";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Location = new System.Drawing.Point(12, 51);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(157, 13);
            this.labelSeleccion.TabIndex = 7;
            this.labelSeleccion.Text = "Seleccione el turno a cancelar: ";
            // 
            // dataGridViewTurnos
            // 
            this.dataGridViewTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurnos.Location = new System.Drawing.Point(15, 73);
            this.dataGridViewTurnos.Name = "dataGridViewTurnos";
            this.dataGridViewTurnos.Size = new System.Drawing.Size(466, 269);
            this.dataGridViewTurnos.TabIndex = 8;
            // 
            // groupBoxCancelar
            // 
            this.groupBoxCancelar.Controls.Add(this.textBoxNumTurn);
            this.groupBoxCancelar.Controls.Add(this.labelNumTurn);
            this.groupBoxCancelar.Controls.Add(this.labelMotivo);
            this.groupBoxCancelar.Controls.Add(this.textBoxMotivo);
            this.groupBoxCancelar.Controls.Add(this.buttonCancelar);
            this.groupBoxCancelar.Location = new System.Drawing.Point(489, 73);
            this.groupBoxCancelar.Name = "groupBoxCancelar";
            this.groupBoxCancelar.Size = new System.Drawing.Size(250, 269);
            this.groupBoxCancelar.TabIndex = 9;
            this.groupBoxCancelar.TabStop = false;
            this.groupBoxCancelar.Text = "Cancelacion";
            // 
            // textBoxNumTurn
            // 
            this.textBoxNumTurn.Location = new System.Drawing.Point(9, 36);
            this.textBoxNumTurn.Name = "textBoxNumTurn";
            this.textBoxNumTurn.ReadOnly = true;
            this.textBoxNumTurn.Size = new System.Drawing.Size(139, 20);
            this.textBoxNumTurn.TabIndex = 8;
            // 
            // labelNumTurn
            // 
            this.labelNumTurn.AutoSize = true;
            this.labelNumTurn.Location = new System.Drawing.Point(6, 20);
            this.labelNumTurn.Name = "labelNumTurn";
            this.labelNumTurn.Size = new System.Drawing.Size(142, 13);
            this.labelNumTurn.TabIndex = 7;
            this.labelNumTurn.Text = "Numero de turno a cancelar:";
            // 
            // labelMotivo
            // 
            this.labelMotivo.AutoSize = true;
            this.labelMotivo.Location = new System.Drawing.Point(6, 75);
            this.labelMotivo.Name = "labelMotivo";
            this.labelMotivo.Size = new System.Drawing.Size(103, 13);
            this.labelMotivo.TabIndex = 6;
            this.labelMotivo.Text = "Motivo cancelacion:";
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(6, 91);
            this.textBoxMotivo.MaxLength = 200;
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(238, 143);
            this.textBoxMotivo.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(6, 240);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(145, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar Turno";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(443, 25);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(145, 23);
            this.buttonSeleccionar.TabIndex = 11;
            this.buttonSeleccionar.Text = "Seleccionar Turno";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(594, 25);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(145, 23);
            this.buttonVolver.TabIndex = 12;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // CancelacionAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 346);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxCancelar);
            this.Controls.Add(this.dataGridViewTurnos);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNroAfil);
            this.Controls.Add(this.labelNroAfil);
            this.Name = "CancelacionAfiliado";
            this.Text = "Cancelacion de turnos";
            this.Load += new System.EventHandler(this.CancelacionAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).EndInit();
            this.groupBoxCancelar.ResumeLayout(false);
            this.groupBoxCancelar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNroAfil;
        private System.Windows.Forms.TextBox textBoxNroAfil;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.DataGridView dataGridViewTurnos;
        private System.Windows.Forms.GroupBox groupBoxCancelar;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelMotivo;
        private System.Windows.Forms.TextBox textBoxNumTurn;
        private System.Windows.Forms.Label labelNumTurn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonVolver;
    }
}