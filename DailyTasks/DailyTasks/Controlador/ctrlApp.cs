using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DailyTasks.Modelo;
using DailyTasks.Vista.Inicio;

namespace DailyTasks.Controlador
{
    /// <summary>
    /// clase ctrlApp
    /// </summary>
    public class ctrlApp
    {
        private DatosApp objDatosApp;
        private string mensaje;

        /// <summary>
        /// constructor de la ctrlApp con istancia de la clase 
        /// DatosApp 
        /// </summary>
        public ctrlApp()
        {
            this.objDatosApp = new DatosApp();
        }


        /// <summary>
        /// get y set de la variable mensaje de tipo string
        /// </summary>
        public string Mensaje { get => mensaje; set => mensaje = value; }

        /// <summary>
        /// metodo para iniciar Sesión que recibe los datos ingresados en la vista,
        /// los envia al metodo respectivo InciarSesion(unUsuario) de la clase DatosApp(),
        /// en el Modelo para realizar el inicio de sesión
        /// </summary>
        /// <param name="Vista">
        /// contiene los datos de los ingresados en la vista
        /// </param>
        /// <returns>
        /// objeto unUsuario o null
        /// </returns>

        public Usuario iniciarSesion(frmLogin Vista)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Login = ((TextBox)Vista.Page.Master.FindControl("c1").
                FindControl("txtlogin")).Text;
            unUsuario.Password = ((TextBox)Vista.Page.Master.FindControl("c1").
               FindControl("txtPassword")).Text;
            unUsuario = objDatosApp.InciarSesion(unUsuario);
            this.mensaje = objDatosApp.Mensaje;

            return unUsuario;


        }

    }
}