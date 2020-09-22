using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class Usuario
    {
        private int idUsuario;
        private string login;
        private string password;
        private string rol;
        private string estado;
        private Empleado empleado;

        public Usuario()
        {
            this.Empleado = new Empleado();
        }

        public Usuario(string login, string password, string rol, Empleado empleado, string estado)
        {
            this.Login = login;
            this.Password = password;
            this.Rol = rol;
            this.Empleado = empleado;
            this.Estado = estado;

        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Estado { get => estado; set => estado = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
    }
}