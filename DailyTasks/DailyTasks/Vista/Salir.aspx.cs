using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DailyTasks.Vista
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("idPersona");
            Response.Redirect("Inicio/frmLogin.aspx?x=2");

        }
    }
}