using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;
using AppSoporteTecnico.Modelo;
using AppSoporteTecnico.Vista;
using AppSoporteTecnico.Vista.Funcionario;
using AppSoporteTecnico.Vista.Administrador;

namespace AppSoporteTecnico.Controlador
{
    public class ctrlEquipo
    {
        DatosEquipo objDatosEquipos;
        private string mensaje;


        public ctrlEquipo()
        {
            this.objDatosEquipos = new DatosEquipo();
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public void agregarEquipo(Equipo unEquipo)
        {
            bool agregado = this.objDatosEquipos.AgregarEquipo(unEquipo);
            this.mensaje = this.objDatosEquipos.Mensaje;


        }
        public bool agregarEquipos(frmAgregarEquipos Vista)
        {
            bool agregado = false;
            string tipo = ((DropDownList)Vista.Page.Master.FindControl("c1").FindControl("cbTipo")).SelectedItem.ToString();
            string Marca = ((DropDownList)Vista.Page.Master.FindControl("c1").FindControl("cbMarca")).SelectedItem.ToString();
            int idDependencia = Convert.ToInt32(((DropDownList)Vista.Page.Master.FindControl("c1").FindControl("cbDependencia")).SelectedValue);
            string nombreDepe = ((DropDownList)Vista.Page.Master.FindControl("c1").FindControl("cbDependencia")).SelectedItem.ToString();
            string serial = ((TextBox)Vista.Page.Master.FindControl("c1").FindControl("txtSerial")).Text;
            Dependencia unaDependencia = new Dependencia();
            unaDependencia.IdDependencia = idDependencia;
            unaDependencia.NombreDependencia = nombreDepe;
            Equipo unEquipo = new Equipo(tipo, Marca, serial, unaDependencia);
            agregado = objDatosEquipos.AgregarEquipo(unEquipo);
            this.Mensaje = objDatosEquipos.Mensaje;
            return agregado;
        }


        public Equipo obtenerEquipo(string serial)
        {
            Equipo elEquipo = objDatosEquipos.obtenerEquipo(serial);
            this.mensaje = objDatosEquipos.Mensaje;
            return elEquipo;
        }
    }
}