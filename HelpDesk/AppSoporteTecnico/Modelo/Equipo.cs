using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSoporteTecnico.Modelo
{
    public class Equipo
    {
        private int idEquipo;
        private string tipo;
        private string marca;
        private string serial;
        private Dependencia dependencia;

        public Equipo()
        {
            this.dependencia = new Dependencia();
        }

        public Equipo( string tipo, string marca, string serial, Dependencia dependencia)
        {
         
            this.Tipo = tipo;
            this.Marca = marca;
            this.Serial = serial;
            this.Dependencia = dependencia;
        }

        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Serial { get => serial; set => serial = value; }
        public Dependencia Dependencia { get => dependencia; set => dependencia = value; }
    }
}