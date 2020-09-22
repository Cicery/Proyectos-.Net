using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DailyTasks.Controlador;

namespace DailyTasks.Vista.Usuarios
{
    public partial class ListarActividades : System.Web.UI.Page
    {
        public ctrlTareas ctrlTarea = new ctrlTareas();
        public int idPersona;
     
        protected void Page_Load(object sender, EventArgs e)
        {
            idPersona = Convert.ToInt32(Session["idPersona"]);

            /// validacion de inicio de sesión
            if (!IsPostBack)
            {
                if (Session["idPersona"] != null)
                {
           
                    txtIdTarea.Value = Request.QueryString["idTarea"];
                    /// llamado de la funcion javascrip listarActividades()
                    string script = @"<script type='text/javascript'>listarActividades();</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "listarActividades", script, false);
                }
                else
                {
                    Response.Redirect("../../Vista/Inicio/frmLogin.aspx?x=1");
                }
            }
        }

        /// <summary>
        /// metodo que al dar click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            ///validacion de campos si no estan llenos devuelve un mensale a la vista
            if ((txtFechaA.Text != string.Empty) && (Convert.ToInt32(txtDuracionA.Text) > 0) 
                && (txtDescripcionA.Text != string.Empty))
            {
                bool registrado = ctrlTarea.agregarActividad(this);
                if (registrado)
                {
                    txtFechaA.Text = "";
                    txtDuracionA.Text = "0";
                    txtDescripcionA.Text = "";
                    lblMensaje.Text = ctrlTarea.Mensaje;

                    /// llamado de la funcion javascrip listarActividades()
                    string script = @"<script type='text/javascript'>listarActividades();</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "listarActividades", script, false);
                }
                else
                {
                    lblMensaje.Text = "Problemas al agregar -->" + ctrlTarea.Mensaje;

                }
               
            }
            else
            {
                lblMensaje.Text = "Debe completar todos los campos para continuar";
            }
        }
    }
}