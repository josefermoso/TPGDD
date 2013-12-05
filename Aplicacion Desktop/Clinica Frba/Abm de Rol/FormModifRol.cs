using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ConnectorSQL;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class FormModifRol : Form
    {
        public static String RolCodigo;
        public static string RolNombre;
        public static string RolActivo;
        int TotFunc;
        private FiltrarRol abm;
        
        public FormModifRol(FiltrarRol abmAnterior)
        {
            abm = abmAnterior;
            InitializeComponent();
        }

        

        private void FormModifRol_Load(object sender, EventArgs e)
        {
            txtbNOMBRE.Text = RolNombre;
            //SETEA PARAMETROS DE ROL ACTIVO O INACTIVO
            if (RolActivo == "True")
            {
                cbActivo.Text = "Activo";
            }
            else
            {
                cbActivo.Text = "Desactivado";
            }

            //MUESTRA EL CONTEXTO ACTUAL DE FUNCIONALIDAD POR ROL

            ConnectorClass con = ConnectorClass.Instance;
            DataTable dt = con.executeQuery("select FUNCIONALIDAD_ID, FUNCIONALIDAD_NOMBRE from BUGDEVELOPING.FUNCIONALIDAD order by FUNCIONALIDAD_NOMBRE");

            clbFuncionalidades.DataSource = dt;
            clbFuncionalidades.DisplayMember = "FUNCIONALIDAD_NOMBRE";
            clbFuncionalidades.ValueMember = "FUNCIONALIDAD_ID";

            bool Existe;
            String CodFun;
            TotFunc = Convert.ToInt16(clbFuncionalidades.Items.Count.ToString());

            for (int i = 0; i < TotFunc; i++)
            {
                CodFun = dt.Rows[i].ItemArray[0].ToString();
                Existe = FuncionesRol.existeFunEnRol(RolCodigo, CodFun);
                if (Existe)
                {
                    //ACTIVA EL CHECKBOX PARA LAS QUE YA ESTAN SETEADAS
                    clbFuncionalidades.SetItemChecked(i, true);
                }
            }
        }

        private void buttonLIMPIAR_Click(object sender, EventArgs e)
        {
            txtbNOMBRE.Text = "";
            for (int i = 0; i < TotFunc; i++)
            {
                clbFuncionalidades.SetItemChecked(i, false);
            }
        }

        private void buttonMODIFICAR_Click(object sender, EventArgs e)
        {

            if (clbFuncionalidades.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una funcionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtbNOMBRE.Text == "")
                {
                    MessageBox.Show("El rol debe tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtbNOMBRE.Text.Contains('%') || txtbNOMBRE.Text.Contains('$')
                    || txtbNOMBRE.Text.Contains('&') || txtbNOMBRE.Text.Contains('!')
                    || txtbNOMBRE.Text.Contains('?') || txtbNOMBRE.Text.Contains('/')
                    || txtbNOMBRE.Text.Contains('¿') || txtbNOMBRE.Text.Contains('&')
                    || txtbNOMBRE.Text.Contains(')') || txtbNOMBRE.Text.Contains('(')
                    || txtbNOMBRE.Text.Contains('¡') || txtbNOMBRE.Text.Contains('#')
                    || txtbNOMBRE.Text.Contains('*') || txtbNOMBRE.Text.Contains('}')
                    || txtbNOMBRE.Text.Contains('{'))
                    {
                        MessageBox.Show("Ha elegido un nombre de rol inválido");
                    }
                    else
                    {
                        //Si no cambió el nombre
                        bool ModificarOk;
                        //Hay que verificar si cambió el nombre del rol
                        if (txtbNOMBRE.Text == RolNombre)
                        {
                            ModificarOk = true;
                        }
                        //Si lo cambió hay que verificar que el nombre no esté repetido en la base
                        //sin contar al que tenía antes de cambiarlo
                        else
                        {
                            if (FuncionesRol.existeNombreRol(txtbNOMBRE.Text) == false)
                                ModificarOk = true;
                            else
                                ModificarOk = false;
                        }

                        //Si es true es porque, o bien, no cambió el nombre, o lo cambió y no estaba en la base
                        if (ModificarOk == true)
                        {
                            if (cbActivo.Text == "Activo")
                            {
                                RolActivo = "1";
                            }
                            else
                            {
                                RolActivo = "0";
                                //Se quita todos el Rol a los Usuarios que lo tengan
                                FuncionesRol.borrarRolXUsuario(RolCodigo);
                            }
                            RolNombre = txtbNOMBRE.Text;

                            FuncionesRol.modificarNombreYHabilitacion(RolCodigo, RolNombre, RolActivo);

                            /**Borra todos las funcionalidades asociadas al rol**/
                            FuncionesRol.borrarFuncionalidades(RolCodigo);

                            /**Inserta todas las funcionalidades clickeadas relacionandalas con el rol **/
                            foreach (DataRowView FilaSeleccionados in clbFuncionalidades.CheckedItems)
                            {
                                String strFunCod = FilaSeleccionados["FUNCIONALIDAD_ID"].ToString();
                                FuncionesRol.InsertarFuncionalidades(RolCodigo, strFunCod);
                            }



                            MessageBox.Show("Rol actualizado con éxito", "Actualización de Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            abm.reRenderAfterMod();
                            this.Close();
                        }
                        //Se le avisa al usuario que el nombre del rol ya existe
                        else
                        {
                            MessageBox.Show("El nombre de rol ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
        }
    }
}
