namespace Clinica_Frba.CompraBono
{
    partial class CompraBono
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_CantidadFarmacia = new System.Windows.Forms.TextBox();
            this.label_PlanCostoFarmacia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_CantidadBono = new System.Windows.Forms.TextBox();
            this.label_PlanCostoConsulta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_TotalAbonar = new System.Windows.Forms.Label();
            this.label_TotalConsulta = new System.Windows.Forms.Label();
            this.label_totalFarmacia = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Plan = new System.Windows.Forms.Label();
            this.label_numeroAfiliado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Afiliadado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_CantidadFarmacia);
            this.groupBox1.Controls.Add(this.label_PlanCostoFarmacia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 139);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bono Farmacia";
            // 
            // textBox_CantidadFarmacia
            // 
            this.textBox_CantidadFarmacia.Location = new System.Drawing.Point(95, 77);
            this.textBox_CantidadFarmacia.Name = "textBox_CantidadFarmacia";
            this.textBox_CantidadFarmacia.Size = new System.Drawing.Size(100, 20);
            this.textBox_CantidadFarmacia.TabIndex = 9;
            this.textBox_CantidadFarmacia.TextChanged += new System.EventHandler(this.textBox_CantidadFarmacia_TextChanged);
            this.textBox_CantidadFarmacia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CantidadFarmacia_KeyPress);
            // 
            // label_PlanCostoFarmacia
            // 
            this.label_PlanCostoFarmacia.AutoSize = true;
            this.label_PlanCostoFarmacia.Location = new System.Drawing.Point(101, 34);
            this.label_PlanCostoFarmacia.Name = "label_PlanCostoFarmacia";
            this.label_PlanCostoFarmacia.Size = new System.Drawing.Size(13, 13);
            this.label_PlanCostoFarmacia.TabIndex = 8;
            this.label_PlanCostoFarmacia.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo Bono";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_CantidadBono);
            this.groupBox2.Controls.Add(this.label_PlanCostoConsulta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(265, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 139);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bono Consulta";
            // 
            // textBox_CantidadBono
            // 
            this.textBox_CantidadBono.Location = new System.Drawing.Point(82, 77);
            this.textBox_CantidadBono.Name = "textBox_CantidadBono";
            this.textBox_CantidadBono.Size = new System.Drawing.Size(100, 20);
            this.textBox_CantidadBono.TabIndex = 10;
            this.textBox_CantidadBono.TextChanged += new System.EventHandler(this.textBox_CantidadBono_TextChanged);
            this.textBox_CantidadBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CantidadBono_KeyPress);
            // 
            // label_PlanCostoConsulta
            // 
            this.label_PlanCostoConsulta.AutoSize = true;
            this.label_PlanCostoConsulta.Location = new System.Drawing.Point(101, 35);
            this.label_PlanCostoConsulta.Name = "label_PlanCostoConsulta";
            this.label_PlanCostoConsulta.Size = new System.Drawing.Size(13, 13);
            this.label_PlanCostoConsulta.TabIndex = 9;
            this.label_PlanCostoConsulta.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Costo Bono";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_TotalAbonar);
            this.groupBox3.Controls.Add(this.label_TotalConsulta);
            this.groupBox3.Controls.Add(this.label_totalFarmacia);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(36, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 139);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // label_TotalAbonar
            // 
            this.label_TotalAbonar.AutoSize = true;
            this.label_TotalAbonar.Location = new System.Drawing.Point(153, 90);
            this.label_TotalAbonar.Name = "label_TotalAbonar";
            this.label_TotalAbonar.Size = new System.Drawing.Size(13, 13);
            this.label_TotalAbonar.TabIndex = 15;
            this.label_TotalAbonar.Text = "0";
            // 
            // label_TotalConsulta
            // 
            this.label_TotalConsulta.AutoSize = true;
            this.label_TotalConsulta.Location = new System.Drawing.Point(153, 61);
            this.label_TotalConsulta.Name = "label_TotalConsulta";
            this.label_TotalConsulta.Size = new System.Drawing.Size(13, 13);
            this.label_TotalConsulta.TabIndex = 14;
            this.label_TotalConsulta.Text = "0";
            // 
            // label_totalFarmacia
            // 
            this.label_totalFarmacia.AutoSize = true;
            this.label_totalFarmacia.Location = new System.Drawing.Point(153, 29);
            this.label_totalFarmacia.Name = "label_totalFarmacia";
            this.label_totalFarmacia.Size = new System.Drawing.Size(13, 13);
            this.label_totalFarmacia.TabIndex = 13;
            this.label_totalFarmacia.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total a abonar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total Bono Consulta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total Bono Farmacia:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 24);
            this.button3.TabIndex = 19;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "Confirmar Compra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Plan:";
            // 
            // label_Plan
            // 
            this.label_Plan.AutoSize = true;
            this.label_Plan.Location = new System.Drawing.Point(237, 23);
            this.label_Plan.Name = "label_Plan";
            this.label_Plan.Size = new System.Drawing.Size(87, 13);
            this.label_Plan.TabIndex = 21;
            this.label_Plan.Text = "Plan Medico 120";
            // 
            // label_numeroAfiliado
            // 
            this.label_numeroAfiliado.AutoSize = true;
            this.label_numeroAfiliado.Location = new System.Drawing.Point(107, 23);
            this.label_numeroAfiliado.Name = "label_numeroAfiliado";
            this.label_numeroAfiliado.Size = new System.Drawing.Size(43, 13);
            this.label_numeroAfiliado.TabIndex = 22;
            this.label_numeroAfiliado.Text = "700370";
            // 
            // CompraBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 406);
            this.Controls.Add(this.label_numeroAfiliado);
            this.Controls.Add(this.label_Plan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CompraBono";
            this.Text = "CompraBono";
            this.Load += new System.EventHandler(this.CompraBono_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_CantidadFarmacia;
        private System.Windows.Forms.Label label_PlanCostoFarmacia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_CantidadBono;
        private System.Windows.Forms.Label label_PlanCostoConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_TotalAbonar;
        private System.Windows.Forms.Label label_TotalConsulta;
        private System.Windows.Forms.Label label_totalFarmacia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Plan;
        private System.Windows.Forms.Label label_numeroAfiliado;
    }
}