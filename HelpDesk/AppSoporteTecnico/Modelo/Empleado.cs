using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class Empleado: Persona
    {
        private int idEmpleado;
        private string cargo;
        private Dependencia dependencia;

        public Empleado()
        {
            this.dependencia = new Dependencia();
        }

        public Empleado(string cargo, Dependencia dependencia, string identificacion, string nombres,string apellidos, string correo)
            :base(identificacion,nombres,apellidos,correo)
        {
            this.Cargo = cargo;
            this.Dependencia = dependencia;
        }

        public string Cargo { get => cargo; set => cargo = value; }
        public Dependencia Dependencia { get => dependencia; set => dependencia = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }
}