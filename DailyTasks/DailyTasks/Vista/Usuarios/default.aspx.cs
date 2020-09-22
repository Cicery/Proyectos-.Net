using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DailyTasks.Vista.Usuarios
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["idPersona"] != null)
                {


                }
                else
                {
                    Response.Redirect("../../Vista/Inicio/frmLogin.aspx?x=1");
                }
            }
        }
    }
}