using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;
using AppSoporteTecnico.Modelo;
using AppSoporteTecnico.Vista.Administrador;

namespace AppSoporteTecnico.Controlador
{
    public class ctrlEmpleado
    {

        DatosEmpleado objDatosEmpleado;
        private string mensaje;


        public ctrlEmpleado()
        {
            this.objDatosEmpleado = new DatosEmpleado();
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public void agregarEmpleado(Empleado unEmpleado,string rol)
        {
            bool agregado = this.objDatosEmpleado.AgregarEmpleado(unEmpleado, rol);
            this.mensaje = this.objDatosEmpleado.Mensaje;
           

        }
    }
}