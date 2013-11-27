using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Generar_Receta
{
    public partial class CantidadDeMedicamentos : Form
    {
        public string idMedicamento;
        public string cantidad;
        public string aclaracion;
        private static Generar_Receta.GenerarReceta receta;
        public CantidadDeMedicamentos(String medicamentoID, Generar_Receta.GenerarReceta RecetaCreada)
        {

            idMedicamento = medicamentoID;
            InitializeComponent();
            receta = RecetaCreada;
        }

        private void buttonACEPTAR_Click(object sender, EventArgs e)
        {

            cantidad = comboBoxCANTIDAD.Text;
            if (cantidad == "1")
            {
                aclaracion = "Uno";
                if (verifcarMedNoRepetido() == 0)
                {
                    receta.agregarMed(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya ha seleccionado ese medicamento");
                }


            }
            else if (cantidad == "2")
            {
                aclaracion = "Dos";
                if (verifcarMedNoRepetido() == 0)
                {
                    receta.agregarMed(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya ha seleccionado ese medicamento");
                }

            }
            else if (cantidad == "3")
            {
                aclaracion = "Tres";
                if (verifcarMedNoRepetido() == 0)
                {
                    receta.agregarMed(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya ha seleccionado ese medicamento");
                }

            }
            else if (cantidad == "4")
            {
                aclaracion = "Cuatro";
                if (verifcarMedNoRepetido() == 0)
                {
                    receta.agregarMed(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya ha seleccionado ese medicamento");
                }

            }
            else if (cantidad == "5")
            {
                aclaracion = "Cinco";
                if (verifcarMedNoRepetido() == 0)
                {
                    receta.agregarMed(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya ha seleccionado ese medicamento");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cantidad para esta medicamento");
            }


        }

        private void comboBoxCANTIDAD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int verifcarMedNoRepetido()
        {

            List<string> subList = new List<string>();

            foreach (CantidadDeMedicamentos formCantidad in receta.listaDrogas)
            {
                subList.Add(formCantidad.idMedicamento);
            }

            if (subList.Count == 0)
            {
                return 0;
            }
            else if (subList.Contains(idMedicamento))
            {
                return 1;
            }
            else { return 0; }
        }

    }
}
