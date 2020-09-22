using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSoporteTecnico.Controlador;

namespace AppSoporteTecnico.Vista.Tecnico
{
    public partial class frmDetalleSolicitud : System.Web.UI.Page
    {

        public int idEmpleado;
        private ctrlServicio controladorServicio = new ctrlServicio();

        protected void Page_Load(object sender, EventArgs e)
        {
            idEmpleado = Convert.ToInt32(Session["idEmpleado"]);

            if (!IsPostBack)
            {
                txtIdSolicitud.Value = Request.QueryString["idSolicitud"];
                string script = @"<script type='text/javascript'>listarDetalleSolicitud();</script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "listarDetalleSolicitud", script, false);
            }

        }

        protected void btnAtender_Click(object sender, EventArgs e)
        {
            if(txtObservacionSolucion.Text != string.Empty)
            {
                bool agregada = controladorServicio.agregarServicio(this);
                if (agregada)
                {
                    Response.Redirect("FrmListarSolicitudesPorAtender.aspx?x=1");

                }
                else
                {
                    Response.Redirect("FrmListarSolicitudesPorAtender.aspx?x=2");

                }
            }
            else
            {
                this.lblMensaje.Text = "Falta Ingresar la Observacion";
            }
        }
    }
}