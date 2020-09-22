using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSoporteTecnico.Modelo;
using AppSoporteTecnico.Vista.Administrador;
using AppSoporteTecnico.Vista.InicioSesion;


namespace AppSoporteTecnico.Controlador
{
    public class ctrlNegocio
    {
        private DatosNegocio objDatosNegocio;
        private DatosDependencia objDatosDependencia;
        private string mensaje;


        public ctrlNegocio()
        {
            this.objDatosNegocio = new DatosNegocio();
            this.objDatosDependencia = new DatosDependencia();

        }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public List<Dependencia> obtenerDependencias()
        {
            List<Dependencia> lista = objDatosNegocio.listarDependencia();
            this.Mensaje = objDatosNegocio.Mensaje;
            return lista;
        }
        public bool AgregarDependencia(frmAgregarDependencia Vista)
        {
            bool agregado = false;
            Dependencia unaDependencia = new Dependencia();
            unaDependencia.NombreDependencia = ((TextBox)Vista.Page.Master.FindControl("c1").FindControl("txtNombre")).Text;

            agregado = objDatosDependencia.AgregarDependencia(unaDependencia);
            this.Mensaje = objDatosDependencia.Mensaje;
            return agregado;
        }

        public Usuario iniciarSesion(frmInciarSesion Vista)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Login = ((TextBox)Vista.Page.Master.FindControl("c1").
                FindControl("txtlogin")).Text;
            unUsuario.Password = ((TextBox)Vista.Page.Master.FindControl("c1").
               FindControl("txtPassword")).Text;
            unUsuario = objDatosNegocio.InciarSesion(unUsuario);
            this.mensaje = objDatosNegocio.Mensaje;
            return unUsuario;


        }
    }
    }