using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSoporteTecnico.Modelo;
using System.IO;
using AppSoporteTecnico.Controlador;

namespace AppSoporteTecnico.Vista.Administrador
{
    public partial class frmAgregarDependencia : System.Web.UI.Page
    {
        private ctrlNegocio controllerNegocio = new ctrlNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty)
            {
                bool agregado = controllerNegocio.AgregarDependencia(this);
                lblMensaje.Text = "Dependencia Agregada Correctamente";
            }
            else
            {
                lblMensaje.Text = " debe ingresar el serial";
            }

        }
    }
}