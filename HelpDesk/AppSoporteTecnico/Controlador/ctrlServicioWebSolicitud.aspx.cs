using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using AppSoporteTecnico.Modelo;

namespace AppSoporteTecnico.Controlador
{
    public partial class ctrlServicioWebSolicitud : System.Web.UI.Page
    {
        public static DatosSolicitud datosSolicitud = new DatosSolicitud();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<Solicitud> listarSolicitudPendientes()
        {
            return (datosSolicitud.listarSolicitudesPorAtender());
        }

        [WebMethod]
        public static List<DetalleSolicitud> listarDetalleSolicitud(int idSolicitud)
        {
            return (datosSolicitud.obtenerDetalleSolicitud(idSolicitud));
        }

    }
}