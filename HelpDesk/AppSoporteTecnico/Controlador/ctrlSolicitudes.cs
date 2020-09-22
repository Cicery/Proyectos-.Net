using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;
using AppSoporteTecnico.Modelo;
using AppSoporteTecnico.Vista;
using AppSoporteTecnico.Vista.Funcionario;

namespace AppSoporteTecnico.Controlador
{
    public class ctrlSolicitudes
    {
        private DatosSolicitud datosSolicittud;
        private string mensaje;


        public ctrlSolicitudes()
        {
            datosSolicittud = new DatosSolicitud();
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public bool agregarSolicitud(Solicitud unaSolicitud)
        {
            bool agregado = datosSolicittud.agregarSolicitud(unaSolicitud);
            this.mensaje = datosSolicittud.Mensaje;       
            return agregado;
        }

        public bool agregarSolicitud(FrmSolicitud vista)
        {
            bool agregada = false;

            try
            {
                GridView tabla = (GridView)vista.Page.Master.FindControl("c1").FindControl("tblSolicitud");
                List<DetalleSolicitud> listaDetalle = new List<DetalleSolicitud>();
                for(int i = 0; i <tabla.Rows.Count; i++)
                {
                    DetalleSolicitud detalle = new DetalleSolicitud();
                    detalle.Equipo.Serial = tabla.Rows[i].Cells[1].Text;
                    detalle.Equipo.IdEquipo = Convert.ToInt32(tabla.Rows[i].Cells[0].Text);
                    detalle.Observaciones = tabla.Rows[i].Cells[2].Text;
                    listaDetalle.Add(detalle);
                }
                Solicitud unaSolicitud = new Solicitud();
                unaSolicitud.Empleado.IdEmpleado = vista.idEmpleado; //quemado
                unaSolicitud.Fecha = DateTime.Now;
                unaSolicitud.Ticket = FrmSolicitud.Ticket;
                unaSolicitud.Estado = "Solicitada";
                unaSolicitud.ListaDetalle = listaDetalle;
                bool registrado = datosSolicittud.agregarSolicitud(unaSolicitud);
                agregada = true;
                this.mensaje = datosSolicittud.Mensaje;
            }catch(Exception ex)
            {
                this.mensaje = ex.Message;
            }
            return agregada;

        }

    }
}