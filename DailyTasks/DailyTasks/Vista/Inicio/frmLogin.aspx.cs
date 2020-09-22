using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DailyTasks.Controlador;
using DailyTasks.Modelo;

namespace DailyTasks.Vista.Inicio
{
    public partial class frmLogin : System.Web.UI.Page
    {
        ctrlApp controllerApp = new ctrlApp();
        Usuario unUsuario;

        /// <summary>
        /// creacion de variable x y switch que utilizara la misma
        /// 
        /// realizado  para validacion de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["x"]);
            switch (x)
            {
                case 1:
                    lblMensaje.Text = "Debe iniciar sesión para ingresar";
                    break;
                case 2:
                    lblMensaje.Text = "Se ha cerrado Sesión";
                    break;
            }
        }

        /// <summary>
        /// Boton que al hacer click, enviara al controlador para el inicio de sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            
            unUsuario = null;

            ///validacion de campos si no estan llenos devuelve un mensale a la vista
            if ((txtlogin.Text != string.Empty) && (txtPassword.Text != string.Empty))
            {
                Usuario unUsuario = controllerApp.iniciarSesion(this);
                if (unUsuario != null)
                {
                    Session["idPersona"] = unUsuario.Persona.IdPersona;
                    Session["Nombre"] = unUsuario.Persona.Nombres;
                    Session["Apellido"] = unUsuario.Persona.Apellidos;
                  
                    Response.Redirect("../Usuarios/");

                }
                else
                {
                    lblMensaje.Text = "Algun Dato no es valido";
                }
            }
            else
            {
                lblMensaje.Text = "debe completar todos los campos";
            }
            }
        }
    }

