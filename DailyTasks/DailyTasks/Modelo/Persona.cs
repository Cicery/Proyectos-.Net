using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyTasks.Modelo
{
    /// <summary>
    /// clase persona
    /// </summary>
    public class Persona
    {
        private int idPersona;
        private string identificacion;
        private string nombres;
        private string apellidos;
        private string correo;


        /// <summary>
        /// contructor de la clase persona para usar los get y set
        /// </summary>
        public Persona()
        {
        }
        /// <summary>
        /// Contructor con parametros de la clase persona 
        /// </summary>
        /// <param name="identificacion">
        /// parametro identificacion de tipo string
        /// </param>
        /// <param name="nombres">
        /// parametro nombres de tipo string
        /// </param>
        /// <param name="apellidos">
        /// parametro apellidos de tipo string
        /// </param>
        /// <param name="correo">
        /// parametro correo de tipo string
        /// </param>
        public Persona(string identificacion, string nombres, string apellidos, string correo)
        {

            this.Identificacion = identificacion;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Correo = correo;
        }

        /// <summary>
        /// Get y set de la clase persona
        /// </summary>
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}