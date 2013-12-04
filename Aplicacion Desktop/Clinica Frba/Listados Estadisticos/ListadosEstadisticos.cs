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


                String listado1 = "select top 5 es_descripcion as Especialidad, es_id as ID_Especialidad, COUNT(*) as Cancelaciones from BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO right join BUGDEVELOPING.CANCELACION_TURNO on (ct_turno = t_id), BUGDEVELOPING.ESPECIALIDAD where es_id = em_especialidad and em_medico = me_persona and me_persona = t_medico group by es_descripcion, es_id order by 3 desc";
                String listado2 = "select top 5 pa_nAfiliado Nro_Afiliado, pe_nombre Nombre, pe_apellido Apellido, pe_tipo_doc, pe_num_doc Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from BUGDEVELOPING.BONO_FARMACIA left join BUGDEVELOPING.COMPRA_BONO on (cb_bono = bf_bono_numero) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) where pa_nAfiliado = co_afiliado group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc";
                String listado3 = "select top 5 es_id Id_Especialidad, es_descripcion Especialidad, tipo_es_descripcion Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from BUGDEVELOPING.ESPECIALIDAD, BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO, BUGDEVELOPING.CONSULTA, BUGDEVELOPING.RECETA_MEDICA, BUGDEVELOPING.TIPO_ESPECIALIDAD where tipo_es_id = es_tipo and es_id = em_especialidad and em_medico = me_persona and t_medico = me_persona and con_turno = t_id and rm_consulta = con_numero and not rm_bono is NULL group by es_id, es_descripcion, tipo_es_descripcion order by 4 desc";
                String vistaListado4 = "create view Cantidades as select pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, COUNT (*) as Cantidad from BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) inner join BUGDEVELOPING.TURNO on (t_afiliado = pa_nAfiliado), BUGDEVELOPING.COMPRA_BONO inner join BUGDEVELOPING.COMPRA on (co_numero = cb_numero), BUGDEVELOPING.BONO_CONSULTA where pa_nAfiliado <> co_afiliado and cb_bono = bc_bono_numero and bc_numero_consulta is not null group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc union all select pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, COUNT (*) as Cantidad from BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) inner join BUGDEVELOPING.TURNO on (t_afiliado = pa_nAfiliado) inner join BUGDEVELOPING.CONSULTA on (t_id = con_turno) inner join BUGDEVELOPING.RECETA_MEDICA on (rm_consulta = con_numero) inner join BUGDEVELOPING.COMPRA_BONO on (cb_bono = rm_bono) inner join BUGDEVELOPING.COMPRA on (co_numero = cb_numero) inner join BUGDEVELOPING.BONO_FARMACIA on (bf_bono_numero = rm_bono) where pa_nAfiliado <> co_afiliado group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc";
                String listado4 = "select top 10 pa_nafiliado as Numero_Afiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, SUM(cantidad) as Cantidad_De_Bonos from dbo.Cantidades group by pa_nafiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc drop view dbo.Cantidades";

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

                           String listado1 = "select top 5 es_descripcion as Especialidad, es_id as ID_Especialidad, COUNT(*) as Cancelaciones from BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO right join BUGDEVELOPING.CANCELACION_TURNO on (ct_turno = t_id), BUGDEVELOPING.ESPECIALIDAD where es_id = em_especialidad and em_medico = me_persona and me_persona = t_medico and t_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by es_descripcion, es_id order by 3 desc";
                           String listado2 = "select top 5 pa_nAfiliado Nro_Afiliado, pe_nombre Nombre, pe_apellido Apellido, pe_tipo_doc, pe_num_doc Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from BUGDEVELOPING.BONO_FARMACIA left join BUGDEVELOPING.COMPRA_BONO on (cb_bono = bf_bono_numero) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) where pa_nAfiliado = co_afiliado and bf_fecha_vencimiento between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc";
                           String listado3 = "select top 5 es_id Id_Especialidad, es_descripcion Especialidad, tipo_es_descripcion Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from BUGDEVELOPING.ESPECIALIDAD, BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO, BUGDEVELOPING.CONSULTA, BUGDEVELOPING.RECETA_MEDICA, BUGDEVELOPING.TIPO_ESPECIALIDAD where tipo_es_id = es_tipo and es_id = em_especialidad and em_medico = me_persona and t_medico = me_persona and con_turno = t_id and rm_consulta = con_numero and not rm_bono is NULL and con_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by es_id, es_descripcion, tipo_es_descripcion order by 4 desc";
                           String vistaListado4 = "create view Cantidades as select pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, COUNT (*) as Cantidad from BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) inner join BUGDEVELOPING.TURNO on (t_afiliado = pa_nAfiliado), BUGDEVELOPING.COMPRA_BONO inner join BUGDEVELOPING.COMPRA on (co_numero = cb_numero), BUGDEVELOPING.BONO_CONSULTA where pa_nAfiliado <> co_afiliado and cb_bono = bc_bono_numero and bc_numero_consulta is not null and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc union all select pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, COUNT (*) as Cantidad from BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) inner join BUGDEVELOPING.TURNO on (t_afiliado = pa_nAfiliado) inner join BUGDEVELOPING.CONSULTA on (t_id = con_turno) inner join BUGDEVELOPING.RECETA_MEDICA on (rm_consulta = con_numero) inner join BUGDEVELOPING.COMPRA_BONO on (cb_bono = rm_bono) inner join BUGDEVELOPING.COMPRA on (co_numero = cb_numero) inner join BUGDEVELOPING.BONO_FARMACIA on (bf_bono_numero = rm_bono) where pa_nAfiliado <> co_afiliado and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-01-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-30 18:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc";
                           String listado4 = "select top 10 pa_nafiliado as Numero_Afiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, SUM(cantidad) as Cantidad_De_Bonos from dbo.Cantidades group by pa_nafiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc drop view dbo.Cantidades";

                           con.executeQuery(vistaListado4);

                           dataGridViewL1.DataSource = con.executeQuery(listado1);
                           dataGridViewL2.DataSource = con.executeQuery(listado2);
                           dataGridViewL3.DataSource = con.executeQuery(listado3);
                           dataGridViewL4.DataSource = con.executeQuery(listado4);


                       }
                       if (numericUpDown1.Value.ToString() == "2")
                       {
                           ConnectorClass con = ConnectorClass.Instance;

                           String listado1 = "select top 5 es_descripcion as Especialidad, es_id as ID_Especialidad, COUNT(*) as Cancelaciones from BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO right join BUGDEVELOPING.CANCELACION_TURNO on (ct_turno = t_id), BUGDEVELOPING.ESPECIALIDAD where es_id = em_especialidad and em_medico = me_persona and me_persona = t_medico and t_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 09:00:00.000',121) group by es_descripcion, es_id order by 3 desc";
                           String listado2 = "select top 5 pa_nAfiliado Nro_Afiliado, pe_nombre Nombre, pe_apellido Apellido, pe_tipo_doc, pe_num_doc Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from BUGDEVELOPING.BONO_FARMACIA left join BUGDEVELOPING.COMPRA_BONO on (cb_bono = bf_bono_numero) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) where pa_nAfiliado = co_afiliado and bf_fecha_vencimiento between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 09:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc";
                           String listado3 = "select top 5 es_id Id_Especialidad, es_descripcion Especialidad, tipo_es_descripcion Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from BUGDEVELOPING.ESPECIALIDAD, BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO, BUGDEVELOPING.CONSULTA, BUGDEVELOPING.RECETA_MEDICA, BUGDEVELOPING.TIPO_ESPECIALIDAD where tipo_es_id = es_tipo and es_id = em_especialidad and em_medico = me_persona and t_medico = me_persona and con_turno = t_id and rm_consulta = con_numero and not rm_bono is NULL and con_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 18:00:00.000',121) group by es_id, es_descripcion, tipo_es_descripcion order by 4 desc";
                           String vistaListado4 = "create view Cantidades as select pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, COUNT (*) as Cantidad from BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) inner join BUGDEVELOPING.TURNO on (t_afiliado = pa_nAfiliado), BUGDEVELOPING.COMPRA_BONO inner join BUGDEVELOPING.COMPRA on (co_numero = cb_numero), BUGDEVELOPING.BONO_CONSULTA where pa_nAfiliado <> co_afiliado and cb_bono = bc_bono_numero and bc_numero_consulta is not null and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 18:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc union all select pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, COUNT (*) as Cantidad from BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) inner join BUGDEVELOPING.TURNO on (t_afiliado = pa_nAfiliado) inner join BUGDEVELOPING.CONSULTA on (t_id = con_turno) inner join BUGDEVELOPING.RECETA_MEDICA on (rm_consulta = con_numero) inner join BUGDEVELOPING.COMPRA_BONO on (cb_bono = rm_bono) inner join BUGDEVELOPING.COMPRA on (co_numero = cb_numero) inner join BUGDEVELOPING.BONO_FARMACIA on (bf_bono_numero = rm_bono) where pa_nAfiliado <> co_afiliado and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-06-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-12-31 18:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc";
                           String listado4 = "select top 10 pa_nafiliado as Numero_Afiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc, SUM(cantidad) as Cantidad_De_Bonos from dbo.Cantidades group by pa_nafiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc drop view dbo.Cantidades";

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
