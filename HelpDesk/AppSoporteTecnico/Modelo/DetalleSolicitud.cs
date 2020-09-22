using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class DetalleSolicitud
    {
        private int idDetalleSolicitud;
        private Equipo equipo;
        private string observaciones;

        public DetalleSolicitud()
        {
            this.equipo = new Equipo();
        }

        public DetalleSolicitud( Equipo equipo, string observaciones)
        {
           
            this.Equipo = equipo;
            this.Observaciones = observaciones;
        }

        public int IdDetalleSolicitud { get => idDetalleSolicitud; set => idDetalleSolicitud = value; }
        public Equipo Equipo { get => equipo; set => equipo = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}