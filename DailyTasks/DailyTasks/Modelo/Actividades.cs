using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyTasks.Modelo
{

    /// <summary>
    /// clase actividades
    /// </summary>
    public class Actividades
    {
        private int idActividad;
        private string descripcion;
        private DateTime fecha;
        private string duracion;
        private string estado;


        /// <summary>
        /// contructor vacio de la clase Actividades para hacer uso de get y set
        /// </summary>
        public Actividades()
        {

        }


        /// <summary>
        /// contructor de la clase actividades 
        /// </summary>
        /// <param name="descripcion">
        /// parametro descripcion de tipo string 
        /// </param>
        /// <param name="fecha">
        /// parametro fecha de tipo dateTime
        /// </param>
        /// <param name="duracion">
        /// parametro duracion de tipo string
        /// </param>
        /// <param name="estado">
        /// parametro estado de tipo string
        /// </param>
        public Actividades(string descripcion, DateTime fecha, string duracion, string estado)
        {
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Duracion = duracion;
            this.Estado = estado;
        }


        /// <summary>
        /// get y set de la clase actividades 
        /// </summary>
        public int IdActividad { get => idActividad; set => idActividad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}