using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyTasks.Modelo
{
    /// <summary>
    /// clase Usuario
    /// </summary>
    public class Usuario
    {
        private int idUsuario;
        private string login;
        private string password;
        private Persona persona;
        private string estado;
   
        /// <summary>
        /// contructor vacio de la clase Usuario 
        /// instanciando la clase persona 
        /// </summary>
        public Usuario()
        {
            this.Persona = new Persona();
        }

        /// <summary>
        /// contructor con parametros de la clase Usuario 
        /// </summary>
        /// <param name="login">
        /// parametro login de tipo string 
        /// </param>
        /// <param name="password">
        /// parametro password de tipo string 
        /// </param>
        /// <param name="persona">
        /// paametro persona con el objeto de tipo Persona
        /// </param>
        /// <param name="estado">
        /// paramero estado de tipo string
        /// </param>

        public Usuario(string login, string password, Persona persona, string estado)
        {
            this.Login = login;
            this.Password = password;
            this.Persona = persona;
            this.Estado = estado;
        }

        /// <summary>
        /// get y set de la clase Usuario
        /// </summary>
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public Persona Persona { get => persona; set => persona = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}