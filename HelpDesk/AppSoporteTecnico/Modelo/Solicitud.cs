using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class Solicitud
    {
        private int idSolicitud;
        private int ticket;
        private Empleado empleado;
        private DateTime fecha;
        private string estado;
        private List<DetalleSolicitud> listaDetalle;

        /// <summary>
        /// constructor sin parametros, internamente instancia 
        /// los objetos lista detalle y empleados 
        /// </summary>

        public Solicitud()
        {
            ListaDetalle = new List<DetalleSolicitud>();
            Empleado = new Empleado();
        }

        public Solicitud(int ticket, Empleado empleado, DateTime fecha, string estado, List<DetalleSolicitud> listaDetalle)
        {
            this.Ticket = ticket;
            this.Empleado = empleado;
            this.Fecha = fecha;
            this.Estado = estado;
            this.ListaDetalle = listaDetalle;
        }

        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public int Ticket { get => ticket; set => ticket = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
        public List<DetalleSolicitud> ListaDetalle { get => listaDetalle; set => listaDetalle = value; }
    }
}