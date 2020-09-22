using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyTasks.Modelo
{

    /// <summary>
    /// clase tareas 
    /// </summary>
    public class Tareas
    {
        private int idTarea;
        private string descripcion;
        private Persona persona;
        private string estado;
        private Actividades actividades;
        private List<Actividades> listaActividades;
       
        /// <summary>
        /// contructor de la clase Tareas con sus instacias de las clases
        /// Persona, Actividades e instancia de la lista de actividades 
        /// </summary>
        public Tareas()
        {
            Persona = new Persona();
            Actividades = new Actividades();
            ListaActividades = new List<Actividades>();
        }
        /// <summary>
        /// constructor de la clase Tareas con sus parametros
        /// </summary>
        /// <param name="descripcion">
        ///parametro descripcion de tipo string
        /// </param>
        /// <param name="persona">
        /// parametro persona con el objeto de tipo Persona
        /// </param>
        /// <param name="estado">
        /// parametro estado de tipo string
        /// </param>
        /// <param name="actividades">
        /// parametro actividades con el objeto de tipo Actividades
        /// </param>
        /// <param name="listaActividades">
        /// parametro listaActividades que contiene un list de tipo Actividades
        /// </param>
        public Tareas(string descripcion, Persona persona, string estado, Actividades actividades, List<Actividades> listaActividades)
        {
            this.Descripcion = descripcion;
            this.Persona = persona;
            this.Estado = estado;
            this.Actividades = actividades;
            this.ListaActividades = listaActividades;
        }


        /// <summary>
        /// get y set de la case Tareas
        /// </summary>
        public int IdTarea { get => idTarea; set => idTarea = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Persona Persona { get => persona; set => persona = value; }
        public string Estado { get => estado; set => estado = value; }
        public Actividades Actividades { get => actividades; set => actividades = value; }
        public List<Actividades> ListaActividades { get => listaActividades; set => listaActividades = value; }
    }
}