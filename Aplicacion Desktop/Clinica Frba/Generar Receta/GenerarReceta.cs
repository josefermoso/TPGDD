using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;
using System.Configuration;

namespace Clinica_Frba.Generar_Receta
{
    public partial class GenerarReceta : Form
    {
        public static String ConsultaNUM;
        public List<CantidadDeMedicamentos> listaDrogas = new List<CantidadDeMedicamentos>();
        public static Generar_Receta.GenerarReceta receta;

        public GenerarReceta(String numConsulta)
        {
            receta = this;
            ConsultaNUM = numConsulta;
            InitializeComponent();
        }


        private void mostrarDrogas(object sender, EventArgs e)
        {
            String query = "SELECT M_ID AS 'NUMERO DE MEDICAMENTO' , M_DESCRIPCION AS 'DESCRIPCION' FROM BUGDEVELOPING.MEDICAMENTOS WHERE M_DESCRIPCION LIKE " + "'%" + textBoxNOMBREMED.Text + "%' ORDER BY M_DESCRIPCION";

            if (textBoxNOMBREMED.Text == "")
            {
                query = "SELECT M_ID AS 'NUMERO DE MEDICAMENTO' , M_DESCRIPCION AS 'DESCRIPCION' FROM BUGDEVELOPING.MEDICAMENTOS WHERE M_DESCRIPCION IS NOT NULL ORDER BY M_DESCRIPCION";
            }

            ConnectorClass con = ConnectorClass.Instance;
            dgvDrogas.DataSource = con.executeQuery(query);
            dgvDrogas.Enabled = true;

        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvDrogas.Rows.Count > 0) && (dgvDrogas.Columns[e.ColumnIndex].HeaderText == "Seleccionar"))
            {
                if (listaDrogas.Count() == 5)
                {

                    MessageBox.Show("No se pueden seleccionar mas de 5 medicamentos");
                }
                else
                {
                    CantidadDeMedicamentos meds = new CantidadDeMedicamentos(dgvDrogas.CurrentRow.Cells[1].Value.ToString(), receta);
                    meds.Show();

                }
            }

        }

        private void buttonBUSCARMED_Click(object sender, EventArgs e)
        {
            String query = "SELECT M_ID AS 'NUMERO DE MEDICAMENTO' , M_DESCRIPCION AS 'DESCRIPCION' FROM BUGDEVELOPING.MEDICAMENTOS WHERE M_DESCRIPCION LIKE " + "'%" + textBoxNOMBREMED.Text + "%' ORDER BY M_DESCRIPCION";

            if (textBoxNOMBREMED.Text == "")
            {
                query =
                query = "SELECT M_ID AS 'NUMERO DE MEDICAMENTO' , M_DESCRIPCION AS 'DESCRIPCION' FROM BUGDEVELOPING.MEDICAMENTOS ORDER BY M_DESCRIPCION";
            }

            ConnectorClass con = ConnectorClass.Instance;
            dgvDrogas.DataSource = con.executeQuery(query);
            dgvDrogas.Enabled = true;

        }

        private void buttonLIMPIAR_Click(object sender, EventArgs e)
        {
            listaDrogas.Clear();
            labelTOTAL.Text = "0";
        }

        public void agregarMed(CantidadDeMedicamentos med)
        {
            listaDrogas.Add(med);
            labelTOTAL.Text = listaDrogas.Count().ToString();
        }

        private void buttonGENERARUNASOLA_Click(object sender, EventArgs e)
        {
            crearReceta();
        }

        private void crearReceta()
        {
            try
            {
                Convert.ToInt32(textBoxBONOFAR.Text);
                String resultadoOp = FuncionesGenerarReceta.crearRecetaYValidar(textBoxBONOFAR.Text, ConsultaNUM, ConfigurationManager.AppSettings["fechaSistema"]);
                if (resultadoOp == "0")
                {
                    if (labelTOTAL.Text == "0")
                    {
                        MessageBox.Show("Debe seleccionar algún medicamento antes de crear la receta");
                        FuncionesGenerarReceta.borrarRecetaRecienGenerada(textBoxBONOFAR.Text);
                    }
                    else
                    {
                        MessageBox.Show("Receta creada exitosamente");
                        agregarListaDeMedicamentos();
                    }

                }
                if (resultadoOp == "1")
                {
                    MessageBox.Show("El bono ya ha sido consumido previamente");
                }
                if (resultadoOp == "2")
                {
                    MessageBox.Show("El bono esta vencido");
                }


            }
            catch
            {

                MessageBox.Show("El numero de bono es invalido");
            }


        }

        private void buttonGENERARMASDEUNA_Click(object sender, EventArgs e)
        {
            crearReceta();
            GenerarReceta nuevaReceta = new GenerarReceta(ConsultaNUM);
            this.Hide();
            nuevaReceta.Show();
        }

        private void agregarListaDeMedicamentos()
        {
            String recetaCreada = FuncionesGenerarReceta.getRecetaGenerada(textBoxBONOFAR.Text);
            foreach (CantidadDeMedicamentos med in listaDrogas)
            {
                FuncionesGenerarReceta.insertarReceta_Droga(recetaCreada, med.idMedicamento, med.cantidad, med.aclaracion);
            }
        }
    }
}
