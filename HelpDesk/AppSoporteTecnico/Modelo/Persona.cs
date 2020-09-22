using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class Persona
    {
        private int idPersona;
        private string identificacion;
        private string nombres;
        private string apellidos;
        private string correo;

        public Persona()
        {
        }

        public Persona( string identificacion, string nombres, string apellidos, string correo)
        {
        
            this.Identificacion = identificacion;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Correo = correo;
        }

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}