using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DailyTasks.Controlador;

namespace DailyTasks.Vista.Usuarios
{
    public partial class frmListarTareas : System.Web.UI.Page
    {
        public ctrlTareas ctrlTarea = new ctrlTareas();
        public int idPersona;
        protected void Page_Load(object sender, EventArgs e)
        {
           idPersona = Convert.ToInt32(Session["idPersona"]);
            txtIdPersona.Value = Convert.ToString(idPersona);
            /// validacion de inicio de sesión
            if (!IsPostBack)
            {
                if (Session["idPersona"] != null)
                {
                    ///llamado de la funcion javascript listarTareas()
                    string script = @"<script type='text/javascript'>listarTareas();</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "listarTareas", script, false);
                }
                else
                {
                    Response.Redirect("../../Vista/Inicio/frmLogin.aspx?x=1");
                }
            }
           
        }

        protected void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            ///validacion de campos si no estan llenos devuelve un mensale a la vista
            if ((txtDescripcionT.Text != string.Empty) )
            {
                bool registrado = ctrlTarea.agregarTarea(this);
                if (registrado)
                {
                    txtDescripcionT.Text = "";
                   
                    lblMensaje.Text = ctrlTarea.Mensaje;

                    ///llamado de la funcion javascript listarTareas()
                    string script = @"<script type='text/javascript'>listarTareas();</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "listarTareas", script, false);
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