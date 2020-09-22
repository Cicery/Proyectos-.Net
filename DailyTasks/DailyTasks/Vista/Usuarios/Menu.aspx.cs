using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DailyTasks.Vista.Usuarios
{
    public partial class Menu : System.Web.UI.Page
    {
        int idPersona;
        string nombre;
        string apellido;
        string Nombres;
        protected void Page_Load(object sender, EventArgs e)
        {
            idPersona = Convert.ToInt32(Session["idPersona"]);
            nombre = Convert.ToString(Session["Nombre"]);
            apellido = Convert.ToString(Session["Apellido"]);

            Nombres = nombre + " " + apellido;
            /// validacion de inicio de sesión 
            if (!IsPostBack)
            {
                if (Session["idPersona"] != null)
                {

                    string script = @"<script type='text/javascript'>listarTareas();</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "listarTareas", script, false);
                }
                else
                {
                    Response.Redirect("../../Vista/Inicio/frmLogin.aspx?x=1");
                }
            }
        }
    }
}