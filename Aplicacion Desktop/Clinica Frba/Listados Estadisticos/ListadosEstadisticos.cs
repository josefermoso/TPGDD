using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class ListadosEstadisticos : Form
    {
      public ListadosEstadisticos()
        {
            InitializeComponent();
        }

        private void textBoxAnio_TextChanged(object sender, EventArgs e)
        {

            if (numericUpDown1.Value.ToString() == "1")
            {
                textBoxSdesde.Text = textBoxAnio.Text.ToString() + "-01-01";
                textBoxSHasta.Text = textBoxAnio.Text.ToString() + "-06-30";
            }
            if (numericUpDown1.Value.ToString() == "2")
            {
                textBoxSdesde.Text = textBoxAnio.Text.ToString() + "-06-01";
                textBoxSHasta.Text = textBoxAnio.Text.ToString() + "-12-31";
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value.ToString() == "1")
            {
                textBoxSdesde.Text = textBoxAnio.Text.ToString() + "-01-01";
                textBoxSHasta.Text = textBoxAnio.Text.ToString() + "-06-30";
            }
            if (numericUpDown1.Value.ToString() == "2")
            {
                textBoxSdesde.Text = textBoxAnio.Text.ToString() + "-06-01";
                textBoxSHasta.Text = textBoxAnio.Text.ToString() + "-12-31";
            }

        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            if (textBoxAnio.Text.Length == 0)
            {
                ConnectorClass con = ConnectorClass.Instance;


                String listado1 = "select top 5 E.Descripcion as Especialidad, E.ID_ESPECIALIDAD as ID_Especialidad, COUNT(*) as Cancelaciones from hardwell.profesional_especialidad PE, hardwell.profesional P, hardwell.turno T right join HARDWELL.TURNO_CANCELADO TC on (t.ID_TURNO = tc.ID_TURNO), hardwell.especialidad E where E.ID_Especialidad = PE.id_especialidad and PE.id_profesional = p.id_profesional and p.id_profesional = t.id_profesional group by E.Descripcion, E.ID_ESPECIALIDAD order by 3 desc";
                String listado2 = "select top 5 A.NRO_AFILIADO Nro_Afiliado, A.NOMBRE Nombre, A.APELLIDO Apellido, TD.DESCRIPCION Tipo_Documento, A.DOCUMENTO Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from HARDWELL.BONO_FARMACIA bf left join HARDWELL.COMPRA_BONO_FARMACIA cf on ( cf.ID_BONO_FARMACIA = bf.ID_BONO_FARMACIA), HARDWELL.AFILIADO A, HARDWELL.TIPO_DOCUMENTO TD where cf.NRO_AFILIADO = a.NRO_AFILIADO and A.ID_TIPO_DOCUMENTO = TD.ID_TIPO_DOCUMENTO group by a.NRO_AFILIADO, A.NOMBRE, A.APELLIDO, A.DOCUMENTO, TD.DESCRIPCION order by 6 desc";
                String listado3 = "select top 5 E.ID_ESPECIALIDAD Id_Especialidad, E.descripcion Especialidad, TE.DESCRIPCION Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from HARDWELL.ESPECIALIDAD E, HARDWELL.PROFESIONAL_ESPECIALIDAD PE, HARDWELL.PROFESIONAL P, HARDWELL.TURNO T, HARDWELL.CONSULTA_MEDICA CM, HARDWELL.RECETA R, HARDWELL.TIPO_ESPECIALIDAD TE where TE.ID_TIPO_ESPECIALIDAD = E.ID_TIPO_ESPECIALIDAD and E.ID_ESPECIALIDAD = PE.ID_ESPECIALIDAD and PE.ID_PROFESIONAL = P.ID_PROFESIONAL and T.ID_PROFESIONAL = P.ID_PROFESIONAL and CM.ID_TURNO = T.ID_TURNO and R.NUMERO_CONSULTA = CM.NUMERO_CONSULTA and not R.ID_BONO_FARMACIA is NULL group by E.ID_ESPECIALIDAD,e.DESCRIPCION, E.ID_ESPECIALIDAD, TE.DESCRIPCION order by 4 desc";
                String vistaListado4 = "create view Cantidades as select a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION, COUNT (*) as Cantidad from HARDWELL.TIPO_DOCUMENTO td, hardwell.afiliado a, hardwell.COMPRA_BONO_CONSULTA cc, hardwell.BONO_CONSULTA bc where a.ID_TIPO_DOCUMENTO = td.ID_TIPO_DOCUMENTO and a.NRO_AFILIADO = cc.NRO_AFILIADO and cc.ID_BONO_CONSULTA = bc.ID_BONO_CONSULTA and cc.COMPRADO_POR = 2 and bc.NUMERO_CONSULTA is not null group by a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION union all select a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION, COUNT (*) as Cantidad from HARDWELL.TIPO_DOCUMENTO td, hardwell.afiliado a, hardwell.compra_bono_farmacia cf, hardwell.bono_farmacia bf, hardwell.receta r where a.ID_TIPO_DOCUMENTO = td.ID_TIPO_DOCUMENTO and a.NRO_AFILIADO = cf.NRO_AFILIADO and cf.ID_BONO_FARMACIA = bf.ID_BONO_FARMACIA and cf.COMPRADO_POR = 2 and bf.ID_BONO_FARMACIA = r.ID_BONO_FARMACIA group by a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION";
                String listado4 = "select top 10 Nro_afiliado as Numero_Afiliado,Nombre, Apellido, Documento, Descripcion, SUM(cantidad) as Cantidad_De_Bonos from Cantidades group by Nro_afiliado, nombre, apellido, documento, descripcion order by 6 desc drop view Cantidades";

                con.executeQuery(vistaListado4);

                dataGridViewL1.DataSource = con.executeQuery(listado1);
                dataGridViewL2.DataSource = con.executeQuery(listado2);
                dataGridViewL3.DataSource = con.executeQuery(listado3);
                dataGridViewL4.DataSource = con.executeQuery(listado4);
            }
            else
            {
               int result = 0;
               if (!int.TryParse(textBoxAnio.Text, out result))
               {
                   textBoxAnio.Text = "";
                   MessageBox.Show("Solo se permiten numeros");
               }
               else
               {
                   if (textBoxAnio.Text.Length > 4 || textBoxAnio.Text.Length < 4 || Convert.ToInt32(textBoxAnio.Text) < 1800 || Convert.ToInt32(textBoxAnio.Text) > 2013)
                   {
                       textBoxAnio.Text = "";
                       MessageBox.Show("Año invalido");
                   }
                   else
                   {
                       if (numericUpDown1.Value.ToString() == "1")
                       {
                           ConnectorClass con = ConnectorClass.Instance;

                           String listado1 = "select top 5 E.Descripcion as Especialidad, E.ID_ESPECIALIDAD as ID_Especialidad, COUNT(*) as Cancelaciones from hardwell.profesional_especialidad PE, hardwell.profesional P, hardwell.turno T right join HARDWELL.TURNO_CANCELADO TC on (t.ID_TURNO = tc.ID_TURNO), hardwell.especialidad E where E.ID_Especialidad = PE.id_especialidad and PE.id_profesional = p.id_profesional and p.id_profesional = t.id_profesional and T.FECHA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by E.Descripcion, E.ID_ESPECIALIDAD order by 3 desc";
                           String listado2 = "select top 5 A.NRO_AFILIADO Nro_Afiliado, A.NOMBRE Nombre, A.APELLIDO Apellido, TD.DESCRIPCION Tipo_Documento, A.DOCUMENTO Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from HARDWELL.BONO_FARMACIA bf left join HARDWELL.COMPRA_BONO_FARMACIA cf on ( cf.ID_BONO_FARMACIA = bf.ID_BONO_FARMACIA), HARDWELL.AFILIADO A, HARDWELL.TIPO_DOCUMENTO TD where cf.NRO_AFILIADO = a.NRO_AFILIADO and bf.FECHA_VENCIMIENTO between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) and A.ID_TIPO_DOCUMENTO = TD.ID_TIPO_DOCUMENTO group by a.NRO_AFILIADO, A.NOMBRE, A.APELLIDO, A.DOCUMENTO, TD.DESCRIPCION order by 6 desc";
                           String listado3 = "select top 5 E.ID_ESPECIALIDAD Id_Especialidad, E.descripcion Especialidad, TE.DESCRIPCION Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from HARDWELL.ESPECIALIDAD E, HARDWELL.PROFESIONAL_ESPECIALIDAD PE, HARDWELL.PROFESIONAL P, HARDWELL.TURNO T, HARDWELL.CONSULTA_MEDICA CM, HARDWELL.RECETA R, HARDWELL.TIPO_ESPECIALIDAD TE where TE.ID_TIPO_ESPECIALIDAD = E.ID_TIPO_ESPECIALIDAD and E.ID_ESPECIALIDAD = PE.ID_ESPECIALIDAD and PE.ID_PROFESIONAL = P.ID_PROFESIONAL and T.ID_PROFESIONAL = P.ID_PROFESIONAL and CM.ID_TURNO = T.ID_TURNO and R.NUMERO_CONSULTA = CM.NUMERO_CONSULTA and not R.ID_BONO_FARMACIA is NULL and CM.FECHA_CONSULTA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by E.ID_ESPECIALIDAD,e.DESCRIPCION, E.ID_ESPECIALIDAD, TE.DESCRIPCION order by 4 desc";
                           String vistaListado4 = "create view Cantidades as select a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION, COUNT (*) as Cantidad from HARDWELL.TIPO_DOCUMENTO td, hardwell.afiliado a, hardwell.COMPRA_BONO_CONSULTA cc, hardwell.BONO_CONSULTA bc where a.ID_TIPO_DOCUMENTO = td.ID_TIPO_DOCUMENTO and a.NRO_AFILIADO = cc.NRO_AFILIADO and cc.ID_BONO_CONSULTA = bc.ID_BONO_CONSULTA and cc.COMPRADO_POR = 2 and bc.NUMERO_CONSULTA is not null and cc.FECHA_COMPRA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION union all select a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION, COUNT (*) as Cantidad from HARDWELL.TIPO_DOCUMENTO td, hardwell.afiliado a, hardwell.compra_bono_farmacia cf, hardwell.bono_farmacia bf, hardwell.receta r where a.ID_TIPO_DOCUMENTO = td.ID_TIPO_DOCUMENTO and a.NRO_AFILIADO = cf.NRO_AFILIADO and cf.ID_BONO_FARMACIA = bf.ID_BONO_FARMACIA and cf.COMPRADO_POR = 2 and bf.ID_BONO_FARMACIA = r.ID_BONO_FARMACIA and cf.FECHA_COMPRA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION";
                           String listado4 = "select top 10 Nro_afiliado as Numero_Afiliado,Nombre, Apellido, Documento, Descripcion, SUM(cantidad) as Cantidad_De_Bonos from Cantidades group by Nro_afiliado, nombre, apellido, documento, descripcion order by 6 desc drop view Cantidades";

                           con.executeQuery(vistaListado4);

                           dataGridViewL1.DataSource = con.executeQuery(listado1);
                           dataGridViewL2.DataSource = con.executeQuery(listado2);
                           dataGridViewL3.DataSource = con.executeQuery(listado3);
                           dataGridViewL4.DataSource = con.executeQuery(listado4);


                       }
                       if (numericUpDown1.Value.ToString() == "2")
                       {
                           ConnectorClass con = ConnectorClass.Instance;

                           String listado1 = "select top 5 E.Descripcion as Especialidad, E.ID_ESPECIALIDAD as ID_Especialidad, COUNT(*) as Cancelaciones from hardwell.profesional_especialidad PE, hardwell.profesional P, hardwell.turno T right join HARDWELL.TURNO_CANCELADO TC on (t.ID_TURNO = tc.ID_TURNO), hardwell.especialidad E where E.ID_Especialidad = PE.id_especialidad and PE.id_profesional = p.id_profesional and p.id_profesional = t.id_profesional and T.FECHA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 09:00:00.000',121) group by E.Descripcion, E.ID_ESPECIALIDAD order by 3 desc";
                           String listado2 = "select top 5 A.NRO_AFILIADO Nro_Afiliado, A.NOMBRE Nombre, A.APELLIDO Apellido, TD.DESCRIPCION Tipo_Documento, A.DOCUMENTO Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from HARDWELL.BONO_FARMACIA bf left join HARDWELL.COMPRA_BONO_FARMACIA cf on ( cf.ID_BONO_FARMACIA = bf.ID_BONO_FARMACIA), HARDWELL.AFILIADO A, HARDWELL.TIPO_DOCUMENTO TD where cf.NRO_AFILIADO = a.NRO_AFILIADO and bf.FECHA_VENCIMIENTO between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 09:00:00.000',121) and A.ID_TIPO_DOCUMENTO = TD.ID_TIPO_DOCUMENTO group by a.NRO_AFILIADO, A.NOMBRE, A.APELLIDO, A.DOCUMENTO, TD.DESCRIPCION order by 6 desc";
                           String listado3 = "select top 5 E.ID_ESPECIALIDAD Id_Especialidad, E.descripcion Especialidad, TE.DESCRIPCION Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from HARDWELL.ESPECIALIDAD E, HARDWELL.PROFESIONAL_ESPECIALIDAD PE, HARDWELL.PROFESIONAL P, HARDWELL.TURNO T, HARDWELL.CONSULTA_MEDICA CM, HARDWELL.RECETA R, HARDWELL.TIPO_ESPECIALIDAD TE where TE.ID_TIPO_ESPECIALIDAD = E.ID_TIPO_ESPECIALIDAD and E.ID_ESPECIALIDAD = PE.ID_ESPECIALIDAD and PE.ID_PROFESIONAL = P.ID_PROFESIONAL and T.ID_PROFESIONAL = P.ID_PROFESIONAL and CM.ID_TURNO = T.ID_TURNO and R.NUMERO_CONSULTA = CM.NUMERO_CONSULTA and not R.ID_BONO_FARMACIA is NULL and CM.FECHA_CONSULTA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 18:00:00.000',121) group by E.ID_ESPECIALIDAD,e.DESCRIPCION, E.ID_ESPECIALIDAD, TE.DESCRIPCION order by 4 desc";
                           String vistaListado4 = "create view Cantidades as select a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION, COUNT (*) as Cantidad from HARDWELL.TIPO_DOCUMENTO td, hardwell.afiliado a, hardwell.COMPRA_BONO_CONSULTA cc, hardwell.BONO_CONSULTA bc where a.ID_TIPO_DOCUMENTO = td.ID_TIPO_DOCUMENTO and a.NRO_AFILIADO = cc.NRO_AFILIADO and cc.ID_BONO_CONSULTA = bc.ID_BONO_CONSULTA and cc.COMPRADO_POR = 2 and bc.NUMERO_CONSULTA is not null and cc.FECHA_COMPRA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 18:00:00.000',121) group by a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION union all select a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION, COUNT (*) as Cantidad from HARDWELL.TIPO_DOCUMENTO td, hardwell.afiliado a, hardwell.compra_bono_farmacia cf, hardwell.bono_farmacia bf, hardwell.receta r where a.ID_TIPO_DOCUMENTO = td.ID_TIPO_DOCUMENTO and a.NRO_AFILIADO = cf.NRO_AFILIADO and cf.ID_BONO_FARMACIA = bf.ID_BONO_FARMACIA and cf.COMPRADO_POR = 2 and bf.ID_BONO_FARMACIA = r.ID_BONO_FARMACIA and cf.FECHA_COMPRA between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 18:00:00.000',121) group by a.NRO_AFILIADO, a.NOMBRE,a.APELLIDO,a.DOCUMENTO, td.DESCRIPCION";
                           String listado4 = "select top 10 Nro_afiliado as Numero_Afiliado,Nombre, Apellido, Documento, Descripcion, SUM(cantidad) as Cantidad_De_Bonos from Cantidades group by Nro_afiliado, nombre, apellido, documento, descripcion order by 6 desc drop view Cantidades";

                           con.executeQuery(vistaListado4);

                           dataGridViewL1.DataSource = con.executeQuery(listado1);
                           dataGridViewL2.DataSource = con.executeQuery(listado2);
                           dataGridViewL3.DataSource = con.executeQuery(listado3);
                           dataGridViewL4.DataSource = con.executeQuery(listado4);

                       }

                   }
               }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxAnio.Text = "";
            textBoxSdesde.Text = "";
            textBoxSHasta.Text = "";

            dataGridViewL1.DataSource = "";
            dataGridViewL2.DataSource = "";
            dataGridViewL3.DataSource = "";
            dataGridViewL4.DataSource = "";
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clinica_Frba.MenuPrincipal.menuActivo.Show();
        }

    }
}
