using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AppSoporteTecnico.Modelo
{
    public class DatosSolicitud
    {
        private SqlConnection miConexion;
        private string mensaje;

        public DatosSolicitud()
        {
            this.miConexion = Conexion.getConexion();

        }
        public string Mensaje { get => mensaje; }

        public bool agregarSolicitud(Solicitud unaSolicitud)
        {
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;
            try
            {
                comando.Transaction = this.miConexion.BeginTransaction();
                comando.CommandText = "insert into Solicitudes values (@ticket, @idEmpleado, @fecha, @estado)";
                comando.Parameters.AddWithValue("@ticket", unaSolicitud.Ticket);
                comando.Parameters.AddWithValue("@idEmpleado", unaSolicitud.Empleado.IdEmpleado);
                comando.Parameters.AddWithValue("@fecha", unaSolicitud.Fecha);
                comando.Parameters.AddWithValue("@estado", unaSolicitud.Estado);
                comando.ExecuteNonQuery();

                comando.CommandText = "select max(idSolicitud) from Solicitudes";

                int idSolicitud = Convert.ToInt32(comando.ExecuteScalar());

                comando.CommandText = "insert into DetalleSolicitudes values(@idSolicitud,@idEquipo,@observaciones)";

                foreach (DetalleSolicitud detalle in unaSolicitud.ListaDetalle)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    comando.Parameters.AddWithValue("@idEquipo", detalle.Equipo.IdEquipo);
                    comando.Parameters.AddWithValue("@observaciones", detalle.Observaciones);
                    comando.ExecuteNonQuery();
                }
                comando.Transaction.Commit();
                agregado = true;
                this.mensaje = "Agregado";
            }
            catch (SqlException ex)
            {
                comando.Transaction.Rollback();
                this.mensaje = "Problemas al Agregar " + ex.Message;
            }



            return agregado;
        }

        public List<DetalleSolicitud> obtenerDetalleSolicitud(int idSolicitud)
        {
            List<DetalleSolicitud> listaDetalle = new List<DetalleSolicitud>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = this.miConexion;
                comando.CommandText = "select detalleSolicitudes.*, equipos.*, Dependencia.depNombre" +
                    " from detalleSolicitudes inner join equipos on detalleSolicitudes.detEquipo=equipos.idEquipo" +
                    "  inner join Dependencia on Equipos.equiDependencia=Dependencia.idDependencia" +
                    "  inner join Solicitudes on detalleSolicitudes.detSolicitud = Solicitudes.idSolicitud" +
                    "   where Solicitudes.idSolicitud=@idSolicitud";
                comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    DetalleSolicitud detalle = new DetalleSolicitud();
                    detalle.IdDetalleSolicitud = Convert.ToInt32(datos["idDetalleSolicitud"]);
                    detalle.Equipo.IdEquipo = Convert.ToInt32(datos["idEquipo"]);
                    detalle.Equipo.Serial = datos["equiSerial"].ToString();
                    detalle.Equipo.Tipo = datos["equiTipo"].ToString();
                    detalle.Equipo.Marca = datos["equiMarca"].ToString();
                    detalle.Equipo.Dependencia.NombreDependencia = datos["depNombre"].ToString();
                    detalle.Observaciones = datos["detObservacion"].ToString();
                    listaDetalle.Add(detalle);

                }
                datos.Close();

            }
            catch (SqlException ex)
            {
                this.mensaje = ex.Message;

            }
            return listaDetalle;

        }

        public List<Solicitud> listarSolicitudesPorAtender()
        {
            List<Solicitud> lista = new List<Solicitud>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = this.miConexion;
                comando.CommandText = "select Solicitudes.*, Dependencia.depNombre, personas.* from Solicitudes " +
                    " inner join Empleado on solicitudes.solEmpleado = Empleado.idEmpleado" +
                    " inner join personas on Empleado.empPersona = Personas.idPersona " +
                    " inner join Dependencia" +
                    " on Empleado.empDependencia = Dependencia.idDependencia" +
                    " where solicitudes.solEstado = 'Solicitada'";

                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    Solicitud unaSolicitud = new Solicitud();
                    unaSolicitud.IdSolicitud = Convert.ToInt32(datos["idSolicitud"]);
                    unaSolicitud.Ticket = Convert.ToInt32(datos["solTicket"]);
                    unaSolicitud.Estado = datos["solEstado"].ToString();
                    unaSolicitud.Fecha = Convert.ToDateTime(datos["solFechaHora"]);
                    unaSolicitud.Empleado.IdPersona = Convert.ToInt32(datos["idPersona"]);
                    unaSolicitud.Empleado.Identificacion = datos["perIdentificacion"].ToString();
                    unaSolicitud.Empleado.Nombres = datos["perNombre"].ToString();
                    unaSolicitud.Empleado.Apellidos = datos["perApellido"].ToString();
                    unaSolicitud.Empleado.Correo = datos["perCorreo"].ToString();
                    unaSolicitud.Empleado.Dependencia.NombreDependencia = datos["depNombre"].ToString();

                    lista.Add(unaSolicitud);

                }
                datos.Close();

            }
            catch (SqlException ex)
            {
                this.mensaje = ex.Message;

            }
            return lista;

        }

    }
}

                       