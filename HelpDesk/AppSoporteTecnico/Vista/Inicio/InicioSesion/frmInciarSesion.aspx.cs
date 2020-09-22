using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSoporteTecnico.Modelo;
using AppSoporteTecnico.Controlador;
namespace AppSoporteTecnico.Vista.InicioSesion
{
    public partial class frmInciarSesion : System.Web.UI.Page
    {
        ctrlNegocio ControllerNegocio = new ctrlNegocio();
        Usuario unUsuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["x"]);
            switch (x)
            {
                case 1:
                    lblMensaje.Text = "debe Iniciar sesión para ingresar al sistema";
                    break;
                case 2:
                    lblMensaje.Text = "se ha cerrado sesión";
                    break;

            }

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            unUsuario = null;
            if((txtlogin.Text != string.Empty)&&(txtPassword.Text != string.Empty))
            {
                Usuario unUsuario = ControllerNegocio.iniciarSesion(this);
                if(unUsuario != null)
                {
                    Session["idEmpleado"] = unUsuario.Empleado.IdEmpleado;
                    switch (unUsuario.Rol)
                    {
                        case "Administrador": Response.Redirect("../../Administrador/");
                            break;
                        case "Funcionario":
                            Response.Redirect("../../Funcionario/");
                            break;
                        case "Soporte":
                            Response.Redirect("../../Tecnico/");
                            break;

                    }
                }
            }

        }
    }
}