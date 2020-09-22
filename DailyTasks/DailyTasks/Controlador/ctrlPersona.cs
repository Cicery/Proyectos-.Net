using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;

using DailyTasks.Modelo;
using DailyTasks.Vista.Inicio;


namespace DailyTasks.Controlador
{
    /// <summary>
    /// clase ctrlPersona
    /// </summary>
    public class ctrlPersona
    {
        DatosPersona objDatosPersona;
        private string mensaje;

        /// <summary>
        /// constructor de la ctrlPersona con istancia de la clase 
        /// DatosPersona 
        /// </summary>
        public ctrlPersona()
        {
            this.objDatosPersona = new DatosPersona();
        }

        /// <summary>
        /// get y set de la variable mensaje de tipo string
        /// </summary>
        public string Mensaje { get => mensaje; set => mensaje = value; }

        /// <summary>
        /// metodo que recibe y procesa los datos ingresados en la vista,
        /// los envia a su respectivo metodo en el Modelo, para el registro de un nuevo usuario
        /// </summary>
        /// <param name="Vista">
        /// parametro con con los datos ingresados en la vista
        /// </param>
        /// <returns>
        /// true o false
        /// </returns>
        public bool agregarPersona (frmRegistrarse Vista)
        {
            bool agregado = false;
            string identificacion = ((TextBox)Vista.Page.Master.FindControl("c1").FindControl("txtIdentificacion")).Text;
            string nombre = ((TextBox)Vista.Page.Master.FindControl("c1").FindControl("txtNombre")).Text;
            string apellido = ((TextBox)Vista.Page.Master.FindControl("c1").FindControl("txtApellido")).Text;
            string correo = ((TextBox)Vista.Page.Master.FindControl("c1").FindControl("txtCorreo")).Text;

            Persona unaPersona = new  Persona(identificacion,nombre,apellido,correo);
            agregado = objDatosPersona.agregarPersona(unaPersona);
            this.mensaje = objDatosPersona.Mensaje;
            return agregado;
        }
    }
}