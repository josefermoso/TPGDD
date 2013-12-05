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

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class ListadosEstadisticos : Form
    {
        public ListadosEstadisticos()
        {
            InitializeComponent();
        }

        private String dias;
        private String year;
        private String month;
        private String day;
        private String time;

        private String agregarCero(String a)
        {
            if (Convert.ToInt32(a) < 10) { a = "0" + a; }
            return a;
        }

        private void listadosPrimerSemestre(String a, String dias)
        {
            ConnectorClass con = ConnectorClass.Instance;

            agregarCero(a);

            String listado1 = "select top 5 es_descripcion as Especialidad, es_id as ID_Especialidad, COUNT(*) as Cancelaciones from BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO right join BUGDEVELOPING.CANCELACION_TURNO on (ct_turno = t_id), BUGDEVELOPING.ESPECIALIDAD where es_id = em_especialidad and em_medico = me_persona and me_persona = t_medico and t_fecha between ('" + textBoxAnio.Text.ToString() + "-" + a + "-01') and ('" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + "') and t_hora between ('08:00:00.0000000') and ('18:00:00.0000000')  group by es_descripcion, es_id order by 3 desc";
            String listado2 = "select top 5 pa_nAfiliado Nro_Afiliado, pe_nombre Nombre, pe_apellido Apellido, pe_tipo_doc, pe_num_doc Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from BUGDEVELOPING.BONO_FARMACIA left join BUGDEVELOPING.COMPRA_BONO on (cb_bono = bf_bono_numero) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) where pa_nAfiliado = co_afiliado and bf_fecha_vencimiento < convert(Datetime,'" + year + "-" + month + "-" + day + " 18:01:00.000',121) and bf_fecha_vencimiento between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc";
            String listado3 = "select top 5 es_id Id_Especialidad, es_descripcion Especialidad, tipo_es_descripcion Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from BUGDEVELOPING.ESPECIALIDAD, BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO, BUGDEVELOPING.CONSULTA, BUGDEVELOPING.RECETA_MEDICA, BUGDEVELOPING.TIPO_ESPECIALIDAD where tipo_es_id = es_tipo and es_id = em_especialidad and em_medico = me_persona and t_medico = me_persona and con_turno = t_id and rm_consulta = con_numero and not rm_bono is NULL and con_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by es_id, es_descripcion, tipo_es_descripcion order by 4 desc";
            String vistaListado4 = "create view Cantidades as select b_nAfiliado as 'Nro de afiliado', pe_nombre as 'Nombre', pe_apellido as 'Apellido', pe_num_doc 'Documento', pe_tipo_doc 'Tipo Doc', COUNT (*) as 'Cantidad' from BUGDEVELOPING.BONO inner join BUGDEVELOPING.COMPRA_BONO on (b_id = cb_bono) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona), BUGDEVELOPING.CONSULTA, BUGDEVELOPING.BONO_CONSULTA where b_nAfiliado is not null and co_afiliado <> b_nAfiliado and b_nAfiliado = pa_nAfiliado and bc_numero_consulta is not null and con_numero = bc_numero_consulta and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by b_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc union all select b_nAfiliado as 'Nro de afiliado', pe_nombre as 'Nombre', pe_apellido as 'Apellido', pe_num_doc 'Documento', pe_tipo_doc 'Tipo Doc', COUNT (*) as 'Cantidad' from BUGDEVELOPING.BONO inner join BUGDEVELOPING.COMPRA_BONO on (b_id = cb_bono) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona), BUGDEVELOPING.CONSULTA, BUGDEVELOPING.BONO_FARMACIA, BUGDEVELOPING.RECETA_MEDICA where b_nAfiliado is not null and co_afiliado <> b_nAfiliado and b_nAfiliado = pa_nAfiliado and bf_bono_numero IN (SELECT rm_bono FROM BUGDEVELOPING.RECETA_MEDICA) and con_numero = rm_consulta and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by b_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc";
            String listado4 = "select top 10 [Nro de afiliado] as Numero_Afiliado, Nombre, Apellido, Documento, [Tipo Doc], SUM(cantidad) as Cantidad_De_Bonos from Cantidades group by [Nro de afiliado], Nombre, Apellido, Documento, [Tipo Doc] order by 6 desc drop view Cantidades";
            
            con.executeQuery(vistaListado4);

            dataGridViewL1.DataSource = con.executeQuery(listado1);
            dataGridViewL2.DataSource = con.executeQuery(listado2);
            dataGridViewL3.DataSource = con.executeQuery(listado3);
            dataGridViewL4.DataSource = con.executeQuery(listado4);
        }

        private void listadosSegundoSemestre(String a, String dias)
        {
            ConnectorClass con = ConnectorClass.Instance;

            agregarCero(a);

            String listado1 = "select top 5 es_descripcion as Especialidad, es_id as ID_Especialidad, COUNT(*) as Cancelaciones from BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO right join BUGDEVELOPING.CANCELACION_TURNO on (ct_turno = t_id), BUGDEVELOPING.ESPECIALIDAD where es_id = em_especialidad and em_medico = me_persona and me_persona = t_medico and t_fecha between ('" + textBoxAnio.Text.ToString() + "-" + a + "-01') and ('" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + "') and t_hora between ('08:00:00.0000000') and ('18:01:00.0000000') group by es_descripcion, es_id order by 3 desc";
            String listado2 = "select top 5 pa_nAfiliado Nro_Afiliado, pe_nombre Nombre, pe_apellido Apellido, pe_tipo_doc, pe_num_doc Nro_Documento, COUNT(*) as Bonos_Farmacia_Vencidos from BUGDEVELOPING.BONO_FARMACIA left join BUGDEVELOPING.COMPRA_BONO on (cb_bono = bf_bono_numero) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona) where pa_nAfiliado = co_afiliado and bf_fecha_vencimiento < convert(datetime,'" + year + "-" + month + "-" + day + " 18:01:00.000',121)and bf_fecha_vencimiento between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by pa_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc order by 6 desc";
            String listado3 = "select top 5 es_id Id_Especialidad, es_descripcion Especialidad, tipo_es_descripcion Tipo_Especialidad_Descripcion, COUNT(*) as Bonos_Farmacia_Recetados from BUGDEVELOPING.ESPECIALIDAD, BUGDEVELOPING.ESPECIALIDAD_MEDICO, BUGDEVELOPING.MEDICO, BUGDEVELOPING.TURNO, BUGDEVELOPING.CONSULTA, BUGDEVELOPING.RECETA_MEDICA, BUGDEVELOPING.TIPO_ESPECIALIDAD where tipo_es_id = es_tipo and es_id = em_especialidad and em_medico = me_persona and t_medico = me_persona and con_turno = t_id and rm_consulta = con_numero and not rm_bono is NULL and con_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by es_id, es_descripcion, tipo_es_descripcion order by 4 desc";
            String vistaListado4 = "create view Cantidades as select b_nAfiliado as 'Nro de afiliado', pe_nombre as 'Nombre', pe_apellido as 'Apellido', pe_num_doc 'Documento', pe_tipo_doc 'Tipo Doc', COUNT (*) as 'Cantidad' from BUGDEVELOPING.BONO inner join BUGDEVELOPING.COMPRA_BONO on (b_id = cb_bono) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona), BUGDEVELOPING.CONSULTA, BUGDEVELOPING.BONO_CONSULTA where b_nAfiliado is not null and co_afiliado <> b_nAfiliado and b_nAfiliado = pa_nAfiliado and bc_numero_consulta is not null and con_numero = bc_numero_consulta and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by b_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc union all select b_nAfiliado as 'Nro de afiliado', pe_nombre as 'Nombre', pe_apellido as 'Apellido', pe_num_doc 'Documento', pe_tipo_doc 'Tipo Doc', COUNT (*) as 'Cantidad' from BUGDEVELOPING.BONO inner join BUGDEVELOPING.COMPRA_BONO on (b_id = cb_bono) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona), BUGDEVELOPING.CONSULTA, BUGDEVELOPING.BONO_FARMACIA, BUGDEVELOPING.RECETA_MEDICA where b_nAfiliado is not null and co_afiliado <> b_nAfiliado and b_nAfiliado = pa_nAfiliado and bf_bono_numero IN (SELECT rm_bono FROM BUGDEVELOPING.RECETA_MEDICA) and con_numero = rm_consulta and co_fecha between convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-01 09:00:00.000',121) and convert (Datetime,'" + textBoxAnio.Text.ToString() + "-" + a + "-" + dias + " 18:00:00.000',121) group by b_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc";
            String listado4 = "select top 10 [Nro de afiliado] as Numero_Afiliado, Nombre, Apellido, Documento, [Tipo Doc], SUM(cantidad) as Cantidad_De_Bonos from Cantidades group by [Nro de afiliado], Nombre, Apellido, Documento, [Tipo Doc] order by 6 desc drop view Cantidades";

            con.executeQuery(vistaListado4);

            dataGridViewL1.DataSource = con.executeQuery(listado1);
            dataGridViewL2.DataSource = con.executeQuery(listado2);
            dataGridViewL3.DataSource = con.executeQuery(listado3);
            dataGridViewL4.DataSource = con.executeQuery(listado4);
        }


        private void Listados_Load(object sender, EventArgs e)
        {
            String fechaSistema = ConfigurationManager.AppSettings["fechaSistema"];

            year = fechaSistema.Substring(0, 4);
            month = fechaSistema.Substring(5, 2);
            day = fechaSistema.Substring(8, 2);
            time = fechaSistema.Substring(11, 8);

            numericUpDown2.Maximum = 6;
            numericUpDown2.Minimum = 1;
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
                numericUpDown2.Maximum = 6;
                numericUpDown2.Minimum = 1;
                textBoxSdesde.Text = textBoxAnio.Text.ToString() + "-01-01";
                textBoxSHasta.Text = textBoxAnio.Text.ToString() + "-06-30";
            }
            if (numericUpDown1.Value.ToString() == "2")
            {
                numericUpDown2.Maximum = 12;
                numericUpDown2.Minimum = 7;
                textBoxSdesde.Text = textBoxAnio.Text.ToString() + "-07-01";
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
                String vistaListado4 = "create view Cantidades as select b_nAfiliado as 'Nro de afiliado', pe_nombre as 'Nombre', pe_apellido as 'Apellido', pe_num_doc 'Documento', pe_tipo_doc 'Tipo Doc', COUNT (*) as 'Cantidad' from BUGDEVELOPING.BONO inner join BUGDEVELOPING.COMPRA_BONO on (b_id = cb_bono) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona), BUGDEVELOPING.CONSULTA, BUGDEVELOPING.BONO_CONSULTA where b_nAfiliado is not null and co_afiliado <> b_nAfiliado and b_nAfiliado = pa_nAfiliado and bc_numero_consulta is not null and con_numero = bc_numero_consulta group by b_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc union all select b_nAfiliado as 'Nro de afiliado', pe_nombre as 'Nombre', pe_apellido as 'Apellido', pe_num_doc 'Documento', pe_tipo_doc 'Tipo Doc', COUNT (*) as 'Cantidad' from BUGDEVELOPING.BONO inner join BUGDEVELOPING.COMPRA_BONO on (b_id = cb_bono) inner join BUGDEVELOPING.COMPRA on (cb_numero = co_numero), BUGDEVELOPING.PACIENTE inner join BUGDEVELOPING.PERSONA on (pe_id = pa_persona), BUGDEVELOPING.CONSULTA, BUGDEVELOPING.BONO_FARMACIA, BUGDEVELOPING.RECETA_MEDICA where b_nAfiliado is not null and co_afiliado <> b_nAfiliado and b_nAfiliado = pa_nAfiliado and bf_bono_numero IN (SELECT rm_bono FROM BUGDEVELOPING.RECETA_MEDICA) and con_numero = rm_consulta group by b_nAfiliado, pe_nombre, pe_apellido, pe_num_doc, pe_tipo_doc";
                String listado4 = "select top 10 [Nro de afiliado] as Numero_Afiliado, Nombre, Apellido, Documento, [Tipo Doc], SUM(cantidad) as Cantidad_De_Bonos from Cantidades group by [Nro de afiliado], Nombre, Apellido, Documento, [Tipo Doc] order by 6 desc drop view Cantidades";

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
                   if (textBoxAnio.Text.Length > 4 || textBoxAnio.Text.Length < 4 || Convert.ToInt32(textBoxAnio.Text) < 1800)
                   {
                       textBoxAnio.Text = "";
                       MessageBox.Show("Año invalido");
                   }
                   else
                   {
                       if (numericUpDown1.Value.ToString() == "1")
                       {

                           switch (Convert.ToInt32(numericUpDown2.Value))
                           {
                               case 1:
                                   dias = "31";
                                   listadosPrimerSemestre(numericUpDown2.Value.ToString(), dias);
                                   break;
                               case 2:
                                   dias = "28";
                                   listadosPrimerSemestre(numericUpDown2.Value.ToString(), dias);
                                   break;
                               case 3:
                                   dias = "31";
                                   listadosPrimerSemestre(numericUpDown2.Value.ToString(), dias);
                                   break;
                               case 4:
                                   dias = "30";
                                   listadosPrimerSemestre(numericUpDown2.Value.ToString(), dias);
                                   break;
                               case 5:
                                   dias = "31";
                                   listadosPrimerSemestre(numericUpDown2.Value.ToString(), dias);
                                   break;
                               case 6:
                                   dias = "30";
                                   listadosPrimerSemestre(numericUpDown2.Value.ToString(), dias);
                                   break;
                           }

                       }
                       if (numericUpDown1.Value.ToString() == "2")
                       {
                           switch (Convert.ToInt32(numericUpDown2.Value))
                           {
                               case 7:
                                   dias = "31";
                                   listadosSegundoSemestre(numericUpDown2.Value.ToString(),dias);
                                   break;
                               case 8:
                                   dias = "31";
                                   listadosSegundoSemestre(numericUpDown2.Value.ToString(),dias);
                                   break;
                               case 9:
                                   dias = "30";
                                   listadosSegundoSemestre(numericUpDown2.Value.ToString(),dias);
                                   break;
                               case 10:
                                   dias = "31";
                                   listadosSegundoSemestre(numericUpDown2.Value.ToString(),dias);
                                   break;
                               case 11:
                                   dias = "30";
                                   listadosSegundoSemestre(numericUpDown2.Value.ToString(),dias);
                                   break;
                               case 12:
                                   dias = "31";
                                   listadosSegundoSemestre(numericUpDown2.Value.ToString(), dias);
                                   break;
                           }

                       }

                   }
               }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
