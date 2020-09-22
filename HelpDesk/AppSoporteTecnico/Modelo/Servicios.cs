using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class Servicios
    {
        private int idServicio;
        private Solicitud solicitud;
        private Empleado tecnico;
        private string observaciones;
        private DateTime fecha;

        public Servicios()
        {
            this.tecnico = new Empleado();
            this.solicitud = new Solicitud();
        }

        public Servicios(Solicitud solicitud, Empleado tecnico, string observaciones, DateTime fecha)
        {
            this.Solicitud = solicitud;
            this.Tecnico = tecnico;
            this.Observaciones = observaciones;
            this.Fecha = fecha;
        }

        public int IdServicio { get => idServicio; set => idServicio = value; }
        public Solicitud Solicitud { get => solicitud; set => solicitud = value; }
        public Empleado Tecnico { get => tecnico; set => tecnico = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}