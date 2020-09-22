using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DailyTasks.Controlador;

namespace DailyTasks.Vista.Inicio
{
    public partial class frmRegistrarse : System.Web.UI.Page
    {
        private ctrlPersona controllerPersona = new ctrlPersona();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metodo que al hacer click en el boton, 
        /// enviara la vista al controlador para registrarse como nuevo usuaruio de la appp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ///validacion de campos si no estan llenos devuelve un mensale a la vista
            if ((txtIdentificacion.Text !=string.Empty) && (txtNombre.Text != string.Empty) &&
                (txtApellido.Text != string.Empty) && (txtCorreo.Text != string.Empty))
            {
                
                bool agregado = controllerPersona.agregarPersona(this);
                lblMensaje.Text = controllerPersona.Mensaje + " inicie sesion con su identificación";

                txtIdentificacion.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";

            }
            else
            {
                lblMensaje.Text = "Ingrese todos los datos para hacer el registro";
            }
        }
    }
}