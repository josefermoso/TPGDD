﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Abm_de_Rol;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class RolMenu : Form
    {
        public RolMenu() :
            base()
        {
            InitializeComponent();
        }

        private void RolMenu_Load(object sender, EventArgs e)
        {

        }

        private void altaButton_Click(object sender, EventArgs e)
        {
            (new AltaRol()).ShowDialog();
        }

        private void filtroButton_Click(object sender, EventArgs e)
        {
            (new FiltrarRol()).ShowDialog();
        }

        private void modificacionButton_Click(object sender, EventArgs e)
        {
            (new FormModifRol()).ShowDialog();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
