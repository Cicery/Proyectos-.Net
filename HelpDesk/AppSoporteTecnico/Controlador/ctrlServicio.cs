using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;
using AppSoporteTecnico.Modelo;
using AppSoporteTecnico.Vista.Tecnico;

namespace AppSoporteTecnico.Controlador
{
    public class ctrlServicio
    {
        DatosServicio datosServicio;
        private string mensaje;

        public ctrlServicio()
        {
            this.datosServicio = new DatosServicio();
        }

        public bool agregarServicio(frmDetalleSolicitud vista)
        {
            int idSolicitud = Convert.ToInt32(((HiddenField)vista.Page.Master.FindControl("c1").FindControl("txtIdSolicitud")).Value);
            string observaciones = ((TextBox)vista.Page.Master.FindControl("c1").FindControl("txtObservacionSolucion")).Text;
            Solicitud unaSolicitud = new Solicitud();
            unaSolicitud.IdSolicitud = idSolicitud;
            Empleado empleado = new Empleado();
            empleado.IdEmpleado = vista.idEmpleado;
            DateTime fecha = DateTime.Now;
            Servicios unServicio = new Servicios(unaSolicitud, empleado, observaciones, fecha);
            bool agregada = datosServicio.agregarServicio(unServicio);
            this.mensaje = datosServicio.Mensaje;
            return agregada;
        }
    }
}