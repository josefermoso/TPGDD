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

public enum  Operacion{ALTA, ALTA_EXISTENTE, MODIFICACION, BAJA};

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Afiliado : Form
    {
        public string numeroAfiliado;
        public Operacion estado;
        public Afiliado()
        {
            InitializeComponent();
        }
        public bool esConyugue = false;
        public bool esRelativo = false;
        public string titularNAfiliado;
        public string titularPersonaId;
        public AfiliadoPersona titular = null;
        public AfiliadoPersona relativo = null;

        public string viejoPlan;
        public string nuevoPlan;
        public string originalPlan;

        public Afiliado(bool esConyugue)
        {
            InitializeComponent();
            this.esConyugue = esConyugue;
            this.esRelativo = true;
            this.estado = Operacion.ALTA;
            button_AgregarMiembro.Hide();
            comboBox_planMedico.Enabled = false;
        }

        public Afiliado(string nAfiliado, Operacion estadoM)
        {
            InitializeComponent();
            this.numeroAfiliado = nAfiliado;
            this.estado = estadoM; ;
            cargarDatosDeAfiliado();
            alterarCamposParaEstado();
        }

        private void cargarDatosDeAfiliado()
        {
            DataTable Dt;
                
            String query = "SELECT pa_nAfiliado,pl_descripcion,pe_nombre,pe_apellido,pe_tipo_doc,pe_num_doc,pe_direccion,pe_fecha_nac,pe_telefono,pe_sexo,pe_mail,pa_estado_civil from BUGDEVELOPING.PERSONA join BUGDEVELOPING.PACIENTE on(pe_id = pa_persona) join BUGDEVELOPING.PLAN_MEDICO on (pa_plan = pl_codigo) WHERE pa_nAfiliado ="+this.numeroAfiliado;
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);

            label_NumeroAfiliado.Text = Dt.Rows[0].ItemArray[0].ToString();
            comboBox_planMedico.Text = Dt.Rows[0].ItemArray[1].ToString();
            textBox_Nom.Text = Dt.Rows[0].ItemArray[2].ToString();
            textBox_Apellido.Text = Dt.Rows[0].ItemArray[3].ToString();
            comboBox_tipoDocumento.Text = Dt.Rows[0].ItemArray[4].ToString();
            textBox_NumeroDoc.Text =  Dt.Rows[0].ItemArray[5].ToString();
            textBox_Direccion.Text = Dt.Rows[0].ItemArray[6].ToString();
            dateTimePicker1.Text = Dt.Rows[0].ItemArray[7].ToString();
            textBox_Telefono.Text = Dt.Rows[0].ItemArray[8].ToString();
            comboBox_sexo.Text = Dt.Rows[0].ItemArray[9].ToString();
            textBox_Mail.Text = Dt.Rows[0].ItemArray[10].ToString();
            comboBox_EstadoCivil.Text = Dt.Rows[0].ItemArray[11].ToString();
            this.viejoPlan = comboBox_planMedico.Text;
            this.originalPlan = this.viejoPlan;
        }

        private void Afiliado_Load(object sender, EventArgs e)
        {
            comboBox_sexo.Items.Add("Masculino");
            comboBox_sexo.Items.Add("Femenino");

            comboBox_tipoDocumento.Items.Add("DNI");
            comboBox_tipoDocumento.Items.Add("LE");
            comboBox_tipoDocumento.Items.Add("CI");

            comboBox_EstadoCivil.Items.Add("Soltero/a");
            comboBox_EstadoCivil.Items.Add("Casado/a");
            comboBox_EstadoCivil.Items.Add("Viudo/a");
            comboBox_EstadoCivil.Items.Add("Concubinato/a");
            comboBox_EstadoCivil.Items.Add("Divorciado/a");


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = ConnectorClass.getFechaSistema();
            loadComboboxPlanMedico(comboBox_planMedico);
        }

        private void loadComboboxPlanMedico(ComboBox planMedico)
        {
            DataTable DtPlan;
            DtPlan = Clinica_Frba.Abm_de_Afiliado.FuncionesAfiliado.obtenerPlanMedico();
            planMedico.DataSource = DtPlan;
            planMedico.DisplayMember = "DESCRIPCION";
            planMedico.ValueMember = "CODIGO";
        }

        private void textBox_NumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.soloNumeros(e);
        }

        private void textBox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.soloLetras(e);
        }

        private void textBox_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.soloLetras(e);
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.soloNumeros(e);
        }

        private void confirmarAfiliado()
        {
            if (!camposCompletados())return;
            AfiliadoPersona afiliado = crearAfiliadoPersona();                
            
            if(this.esRelativo)
            {
                if (this.esConyugue) afiliado.esConyugue = true;
                this.titular.relativos.Add(afiliado);
                MessageBox.Show("El afiliado relativo o conyugue fue agregado correctamente");
                this.Close();
                return;
            }
            
            if (this.titular == null) this.titular = afiliado;

            if (this.estado != Operacion.ALTA)
            {
                if (this.viejoPlan != this.nuevoPlan)
                {
                    AfiliadoCambioPlan cambioPlan = new AfiliadoCambioPlan(this.titular);
                    this.titular.planMedico = this.nuevoPlan;
                    this.viejoPlan = this.nuevoPlan;
                    cambioPlan.Show();
                    return;
                }
            }

            guardarTitular();
            
            if(this.titular.relativos.Count >0) guardarRelativos();

            this.Close();
            MenuAfiliado menuAfiliado = new MenuAfiliado();
            menuAfiliado.Show();
        }

        private AfiliadoPersona crearAfiliadoPersona()
        {
            AfiliadoPersona afiliado = new AfiliadoPersona();
            afiliado.nombre = textBox_Nom.Text;
            afiliado.apellido = textBox_Apellido.Text;
            afiliado.tipoDoc = comboBox_tipoDocumento.Text;
            afiliado.nroDoc = textBox_NumeroDoc.Text;
            afiliado.fechaNacimiento = dateTimePicker1.Text;
            afiliado.direccion = textBox_Direccion.Text;
            afiliado.estadoCivil = comboBox_EstadoCivil.Text;
            afiliado.planMedico = comboBox_planMedico.SelectedValue.ToString();
            afiliado.mail = textBox_Mail.Text;
            afiliado.sexo = (comboBox_sexo.Text == "Masculino")?"M":"F";
            afiliado.telefono = textBox_Telefono.Text;
            return afiliado;
        }


        private void guardarTitular()
        {
            DataTable Dt;
            String query;
            ConnectorClass conexion = ConnectorClass.Instance;

            if(this.estado == Operacion.MODIFICACION)
            {
                string personaID = obtenerIdDePersonaConNAfiliado(this.numeroAfiliado);
                query = "UPDATE BUGDEVELOPING.PERSONA SET pe_nombre = '" + this.titular.nombre + "'," +
                                                         "pe_apellido ='" + this.titular.apellido + "'," +
                                                         "pe_direccion ='" + this.titular.direccion + "'," +
                                                         "pe_telefono =" + this.titular.telefono + "," +
                                                         "pe_mail ='" + this.titular.mail + "'," +
                                                         "pe_sexo = '" + this.titular.sexo + "'," +
                                                         "pe_fecha_nac = CAST('" + this.titular.fechaNacimiento + "' AS DATE)," + //CAMBIAR FECHA
                                                         "pe_tipo_doc ='" + this.titular.tipoDoc + "'," +
                                                         "pe_num_doc =" + this.titular.nroDoc +
                                                         "WHERE pe_id =" + personaID;
                
                Dt = conexion.executeQuery(query);
                query = "UPDATE BUGDEVELOPING.PACIENTE SET pa_estado_civil = '" + this.titular.estadoCivil+
                                         "' WHERE pa_nAfiliado =" + this.numeroAfiliado;

                Dt = conexion.executeQuery(query);
                

                if ( this.nuevoPlan != null && this.originalPlan != this.nuevoPlan)
                {
                    query = "INSERT INTO BUGDEVELOPING.PLAN_HISTORIAL VALUES("+this.numeroAfiliado+","+
                                                                              comboBox_planMedico.SelectedValue.ToString()+", CONVERT (DATETIME, '" +
                                                                              ConfigurationSettings.AppSettings["fechaSistema"] + "', 120), '" +
                                                                              this.titular.motioCambioPlan+ "')";
                    Dt = conexion.executeQuery(query);
                    query = "UPDATE BUGDEVELOPING.PACIENTE set pa_plan =" + comboBox_planMedico.SelectedValue.ToString() + " WHERE pa_persona =" + personaID;

                }
                MessageBox.Show("El afiliado fue modificado exitosamente");
            }
            else
            {    
                query = "INSERT INTO BUGDEVELOPING.PERSONA (pe_nombre, pe_apellido, pe_direccion, pe_telefono, pe_mail, pe_sexo, pe_fecha_nac, pe_tipo_doc, pe_num_doc) VALUES('"+this.titular.nombre + "','" +
                                                                       this.titular.apellido + "','" +
                                                                       this.titular.direccion + "'," +
                                                                       this.titular.telefono + ",'" +
                                                                       this.titular.mail+"', '" +
                                                                       this.titular.sexo + "', CAST ('" +
                                                                       this.titular.fechaNacimiento + "' AS DATE),'" +
                                                                       this.titular.tipoDoc + "'," +
                                                                       this.titular.nroDoc + ")";
            }
            Dt = conexion.executeQuery(query);
            if(this.estado == Operacion.ALTA)
            {
            titularPersonaId = obtenerIdDePersona(this.titular);
            query = "INSERT INTO BUGDEVELOPING.PACIENTE VALUES(" + titularPersonaId + ",'" +
                                                                   this.titular.estadoCivil + "'," +
                                                                   "(SELECT (COUNT (*) + 1) * 100 from BUGDEVELOPING.PACIENTE),"+       
                                                                   Convert.ToString(titular.relativos.Count) + "," +
                                                                   this.titular.planMedico + 
                                                                   ",1)";
            Dt = conexion.executeQuery(query);
            MessageBox.Show("El afiliado fue dado de alta exitosamente");
            }
        }
        private string obtenerIdDePersonaConNAfiliado(string nAfiliado)
        {
            DataTable Dt;

            String query = "SELECT pe_id from BUGDEVELOPING.PACIENTE JOIN BUGDEVELOPING.PERSONA on (pe_id = pa_persona)WHERE pa_nAfiliado = " + nAfiliado;
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt.Rows[0].ItemArray[0].ToString();

        }
        private string obtenerNAfiliadoDe(string idTitular)
        {

            DataTable Dt;

            String query = "SELECT pa_nAfiliado from BUGDEVELOPING.PACIENTE WHERE pa_persona = "+idTitular;
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt.Rows[0].ItemArray[0].ToString();
        }
        private void guardarRelativos()
        {
            this.titularNAfiliado = obtenerNAfiliadoDe(titularPersonaId);

            int numeroRelativo = 2;
            int numeroSocio = 0;
            int numeroAfiliadoTitular = Convert.ToInt32(this.titularNAfiliado); 
            foreach(AfiliadoPersona relativo in this.titular.relativos)
            {

                string numeroDeSocio;
                if (relativo.esConyugue) numeroDeSocio = Convert.ToString(numeroAfiliadoTitular + 1);
                else 
                {
                    numeroDeSocio = Convert.ToString(numeroAfiliadoTitular + numeroRelativo);
                    numeroRelativo++;
                }

                DataTable Dt;

                String query = "INSERT INTO BUGDEVELOPING.PERSONA (pe_nombre, pe_apellido, pe_direccion, pe_telefono, pe_mail, pe_sexo, pe_fecha_nac, pe_tipo_doc, pe_num_doc) VALUES('" + relativo.nombre + "','" +
                                                                           relativo.apellido + "','" +
                                                                           relativo.direccion + "'," +
                                                                           relativo.telefono + ",'" +
                                                                           relativo.mail + "', '" +
                                                                           relativo.sexo + "', CAST('" +
                                                                           relativo.fechaNacimiento + "' AS DATE),'" +
                                                                           relativo.tipoDoc + "'," +
                                                                           relativo.nroDoc + ")";
                ConnectorClass conexion = ConnectorClass.Instance;
                Dt = conexion.executeQuery(query);
                string relativoPersonaID = obtenerIdDePersona(relativo);

                query = "INSERT INTO BUGDEVELOPING.PACIENTE VALUES(" + relativoPersonaID + ",'" +
                                                       relativo.estadoCivil + "','" +
                                                       numeroDeSocio +"',"+
                                                       "0" + "," +
                                                       this.titular.planMedico +
                                                       ",1)";                
                Dt = conexion.executeQuery(query);                
            }
        }

        private string obtenerIdDePersona(AfiliadoPersona persona)
        {
            DataTable Dt;

            String query = "SELECT pe_id FROM BUGDEVELOPING.PERSONA WHERE '" + persona.nombre + "' = pe_nombre AND '" +
                                                                       persona.apellido + "' = pe_apellido AND '" +
                                                                       persona.direccion + "' = pe_direccion AND " +
                                                                       persona.telefono + " = pe_telefono AND '" +
                                                                       persona.sexo + "' = pe_sexo AND '" +
                                                                       persona.mail + "' = pe_mail AND '" +
                                                                       persona.tipoDoc + "' = pe_tipo_doc AND " +
                                                                       persona.nroDoc + " = pe_num_doc";
            
            //String query = "SELECT pa_nAfiliado FROM BUGDEVELOPING.PERSONA join BUGDEVELOPING.PACIENTE on (pa_persona = pe_id)WHERE " + this.titular.nombre + " = pe_nombre AND " +
              //                                                         persona.apellido + " = pe_apellido AND " +
                //                                                       persona.direccion + " = pe_direccion AND " +
                  //                                                     persona.telefono + " = pe_telefono AND " +
                    //                                                   persona.sexo + " = pe_sexo AND " +
                      //                                                 persona.mail + " = pe_mail AND " +
                        //                                               persona.tipoDoc + " = pe_tipo_doc AND " +
                          //                                             persona.nroDoc + " = pe_numdoc";
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
            return Dt.Rows[0].ItemArray[0].ToString();
        }

        private bool camposCompletados()
        {
            string camposACompletar = "";

            if (comboBox_tipoDocumento.Text.Length.Equals(0)) camposACompletar = camposACompletar +"Tipo Documento, "; 
            if (textBox_NumeroDoc.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Numero Documento, "; 
            if (textBox_Nom.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Nombre, "; 
            if (textBox_Apellido.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Apellido, "; 
            if (comboBox_sexo.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Sexo, "; 
            if (comboBox_EstadoCivil.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Estado Civil, "; 
            if (textBox_Mail.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Mail, "; 
            if (dateTimePicker1.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Fecha Nacimiento, ";
            if (textBox_Direccion.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Direccion";
            if (comboBox_planMedico.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Plan Medico";
            if (textBox_Telefono.Text.Length.Equals(0)) camposACompletar = camposACompletar + "Telefono";

            if (camposACompletar.Length > 0) MessageBox.Show("Debe completar los siguientes campos: " + camposACompletar, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 

            return camposACompletar.Length == 0;
        }
        private void button_AgregarMiembro_Click(object sender, EventArgs e)
        {
            if (!camposCompletados()) return;
            this.titular = crearAfiliadoPersona();
            MenuRelativo relativoFrom = new MenuRelativo(this.titular);
            relativoFrom.Show();
        }

        private void button_accion_Click(object sender, EventArgs e)
        {
            if(this.estado == Operacion.ALTA)    
            {
                confirmarAfiliado();
            }

            if(this.estado == Operacion.BAJA)    
            {
                darDeBajaAAfiliado();
                MessageBox.Show("Se dio de baja exitosamente al usuario");
                this.Close();
                MenuAfiliado menuAfiliado = new MenuAfiliado();
                menuAfiliado.Show();
            }

            if (this.estado == Operacion.MODIFICACION)
            {
                confirmarAfiliado();
            }

            if (this.estado == Operacion.ALTA_EXISTENTE)
            {
                darDeAltaExistente();
                MessageBox.Show("Se dio de alta exitosamente a este usuario");
                this.Close();
                MenuAfiliado menuAfiliado = new MenuAfiliado();
                menuAfiliado.Show();
            }

        }

        private void darDeAltaExistente()
        {
            DataTable Dt;
            String query = "UPDATE BUGDEVELOPING.PACIENTE SET pa_activo = 1 WHERE pa_nAfiliado = "+this.numeroAfiliado;

            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);
        }

        private void darDeBajaAAfiliado()
        {
            DataTable Dt;
            String query = "Execute BUGDEVELOPING.DAR_BAJA_AFILIADO "+this.numeroAfiliado+","+
                                                                      estitular(this.numeroAfiliado)+","+
                                                                      numeroPisoTitular(this.numeroAfiliado)+","+
                                                                      numeroTopeTitular(this.numeroAfiliado);
            ConnectorClass conexion = ConnectorClass.Instance;
            Dt = conexion.executeQuery(query);

        }
        private int numeroPisoTitular(string nAfiliado)
        {
            string numeroString = Convert.ToString(nAfiliado);
            numeroString = numeroString.Substring(0, numeroString.Length - 2)+"00";
            return Convert.ToInt32(numeroString);
        }

        private int numeroTopeTitular(string nAfiliado)
        {
            string numeroString = Convert.ToString(nAfiliado);
            numeroString = numeroString.Substring(0, numeroString.Length - 2) + "99";
            return Convert.ToInt32(numeroString);
 
        }

        private void comboBox_EstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_planMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nuevoPlan = comboBox_planMedico.Text;
        }

        private void alterarCamposParaEstado()
        {
            if(this.estado == Operacion.ALTA_EXISTENTE ||
                this.estado == Operacion.BAJA)    
            {
                button_AgregarMiembro.Hide();
                textBox_NumeroDoc.Enabled = false;
                comboBox_tipoDocumento.Enabled = false;
                textBox_Nom.Enabled = false;
                textBox_Apellido.Enabled = false;
                comboBox_EstadoCivil.Enabled = false;
                textBox_Mail.Enabled = false;
                textBox_Telefono.Enabled = false;
                comboBox_planMedico.Enabled = false;
                comboBox_sexo.Enabled = false;
                textBox_Direccion.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
           if(estado == Operacion.BAJA)
           {
               button_accion.Text = "Dar de Baja";
           }
           if (estado == Operacion.ALTA_EXISTENTE)
           {
               button_accion.Text = "Dar de alta";
           }
           if (estado == Operacion.ALTA)
           {
               button_accion.Text = "Confirmar";
           }
     
           if (estado == Operacion.MODIFICACION)
           {
               //if(!estitular(numeroAfiliado))button_AgregarMiembro.Hide();
               button_AgregarMiembro.Hide();
           }
           
        }

      private bool estitular(string nAfiliad)
      {
          string ultimosDigitos = nAfiliad.Substring(nAfiliad.Length - 2);
          return ultimosDigitos == "00";
      }

      private void button_cancelar_Click(object sender, EventArgs e)
      {
          this.Close();
          MenuAfiliado menuAfiliado = new MenuAfiliado();
          menuAfiliado.Show();
      }
  

    }
}
