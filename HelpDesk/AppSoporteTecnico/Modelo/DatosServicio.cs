using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AppSoporteTecnico.Modelo
{
    public class DatosServicio
    {
        private SqlConnection miConexion;
        private string mensaje;

        public DatosServicio()
        {
            this.miConexion = Conexion.getConexion();
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public bool agregarServicio(Servicios unServicio)
        {
            bool agregado = false;
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = this.miConexion;
                comando.Transaction = this.miConexion.BeginTransaction();
                comando.CommandText = "insert into Servicios values (@solicitud,@empleado,@descripcion,@fecha)";
                comando.Parameters.AddWithValue("@solicitud", unServicio.Solicitud.IdSolicitud);
                comando.Parameters.AddWithValue("@empleado", unServicio.Tecnico.IdEmpleado);
                comando.Parameters.AddWithValue("@descripcion", unServicio.Observaciones);
                comando.Parameters.AddWithValue("@fecha", unServicio.Fecha);
                comando.ExecuteNonQuery();
                
                comando.CommandText = "update Solicitudes set solEstado='Atendida' where idSolicitud =@idSolicitud";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idSolicitud", unServicio.Solicitud.IdSolicitud);
                comando.ExecuteNonQuery();
                comando.Transaction.Commit();
                agregado = true;
                this.Mensaje = "Servicio Registrado";
            }
            catch (SqlException ex)
            {
                comando.Transaction.Rollback();
                this.Mensaje = "Problemas al Atender el Servicio " + ex.Message;
            }

            return agregado;

        }

        public List<DetalleSolicitud> obtenerDetalleSolicitud()
        {
            List<DetalleSolicitud> listaDetalleSolicitud = new List<DetalleSolicitud>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = this.miConexion;
                comando.CommandText = "select detalleSolicitud.*, equipos.*,dependencias.depNombre" +
                    " from detalleSolicitud inner join equipos on detalleSolicitud.depEquipo= equipo.idEquipo" +
                    "innert join dependencias on Equipos.equiDependencia= dependencia.idDependencia ";
            }catch(SqlException ex)
            {
                this.mensaje = ex.Message;
            }
            return listaDetalleSolicitud;
        }


    }
}