using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class Dependencia
    {
        private int idDependencia;
        private string nombreDependencia;

        public Dependencia()
        {

        }
        public Dependencia(string nombreDependencia)
        {
            this.NombreDependencia = nombreDependencia;
        }

        public int IdDependencia { get => idDependencia; set => idDependencia = value; }
        public string NombreDependencia { get => nombreDependencia; set => nombreDependencia = value; }
    }
}