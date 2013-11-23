namespace Clinica_Frba.Login
{
    partial class LoginForm
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
            this.labelUSERNAME = new System.Windows.Forms.Label();
            this.labelPASSWORD = new System.Windows.Forms.Label();
            this.buttonINGRESAR = new System.Windows.Forms.Button();
            this.textBoxUSERNAME = new System.Windows.Forms.TextBox();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUSERNAME
            // 
            this.labelUSERNAME.AutoSize = true;
            this.labelUSERNAME.Location = new System.Drawing.Point(12, 39);
            this.labelUSERNAME.Name = "labelUSERNAME";
            this.labelUSERNAME.Size = new System.Drawing.Size(79, 13);
            this.labelUSERNAME.TabIndex = 0;
            this.labelUSERNAME.Text = "Ingrese usuario";
            // 
            // labelPASSWORD
            // 
            this.labelPASSWORD.AutoSize = true;
            this.labelPASSWORD.Location = new System.Drawing.Point(12, 97);
            this.labelPASSWORD.Name = "labelPASSWORD";
            this.labelPASSWORD.Size = new System.Drawing.Size(98, 13);
            this.labelPASSWORD.TabIndex = 1;
            this.labelPASSWORD.Text = "Ingrese contraseña";
            // 
            // buttonINGRESAR
            // 
            this.buttonINGRESAR.Location = new System.Drawing.Point(124, 158);
            this.buttonINGRESAR.Name = "buttonINGRESAR";
            this.buttonINGRESAR.Size = new System.Drawing.Size(125, 23);
            this.buttonINGRESAR.TabIndex = 2;
            this.buttonINGRESAR.Text = "Ingresar";
            this.buttonINGRESAR.UseVisualStyleBackColor = true;
            this.buttonINGRESAR.Click += new System.EventHandler(this.buttonINGRESAR_Click);
            // 
            // textBoxUSERNAME
            // 
            this.textBoxUSERNAME.Location = new System.Drawing.Point(124, 36);
            this.textBoxUSERNAME.Name = "textBoxUSERNAME";
            this.textBoxUSERNAME.Size = new System.Drawing.Size(222, 20);
            this.textBoxUSERNAME.TabIndex = 3;
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(124, 94);
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.Size = new System.Drawing.Size(222, 20);
            this.textBoxPASSWORD.TabIndex = 4;
            this.textBoxPASSWORD.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 220);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.textBoxUSERNAME);
            this.Controls.Add(this.buttonINGRESAR);
            this.Controls.Add(this.labelPASSWORD);
            this.Controls.Add(this.labelUSERNAME);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Bienvenido - Debe loggearse para ingresar al Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUSERNAME;
        private System.Windows.Forms.Label labelPASSWORD;
        private System.Windows.Forms.Button buttonINGRESAR;
        private System.Windows.Forms.TextBox textBoxUSERNAME;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
    }
}