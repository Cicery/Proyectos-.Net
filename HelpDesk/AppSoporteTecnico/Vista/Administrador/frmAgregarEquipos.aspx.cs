using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSoporteTecnico.Modelo;
using AppSoporteTecnico.Controlador;

namespace AppSoporteTecnico.Vista.Administrador
{
    public partial class frmAgregarEquipos : System.Web.UI.Page
    {
        private ctrlNegocio controllerNegocio = new ctrlNegocio();
        private ctrlEquipo controllerEquipo = new ctrlEquipo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cbDependencia.DataSource = controllerNegocio.obtenerDependencias();
                cbDependencia.DataTextField = "nombreDependencia";
                cbDependencia.DataValueField = "idDependencia";
                cbDependencia.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
           

        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            if (txtSerial.Text != string.Empty)
            {
                bool agregado = controllerEquipo.agregarEquipos(this);
                lblMensaje.Text = "Equipo Agregado Correctamente";
            }
            else
            {
                lblMensaje.Text = " debe ingresar el serial";
            }

        }
    }
}