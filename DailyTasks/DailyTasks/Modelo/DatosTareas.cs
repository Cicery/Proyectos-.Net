using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DailyTasks.Modelo
{

    /// <summary>
    /// clase DatosTareas
    /// </summary>
    public class DatosTareas
    {
        private SqlConnection miConexion;
        private string mensaje;

        /// <summary>
        /// constructor de la clase DatosTareas
        /// con la instancia de la conexion 
        /// </summary>
        public DatosTareas()
        {
            this.miConexion = Conexion.getConexion();
        }

        /// <summary>
        /// get y set de la variable mensaje de tipo string
        /// </summary>
        public string Mensaje { get => mensaje; }


        /// <summary>
        /// Metodo que permite registrar las tareas con sus 
        /// respectivas actividades 
        /// </summary>
        /// <param name="unaTarea">
        /// Objeto de de tipo tarea 
        /// </param>
        /// <returns>
        /// true o false
        /// </returns>
        public bool agregarTareas(Tareas unaTarea)
        {
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;
            try
            {
                comando.Transaction = this.miConexion.BeginTransaction();
                ///Agrega la tarea
                comando.CommandText = "insert into Tareas values (@descripcion, @idPersona, @estado)";
                comando.Parameters.AddWithValue("@descripcion", unaTarea.Descripcion);
                comando.Parameters.AddWithValue("@idPersona", unaTarea.Persona.IdPersona);
                comando.Parameters.AddWithValue("@estado", unaTarea.Estado);
                comando.ExecuteNonQuery();

                ///Obtiene el id de la tarea recien agregada
                comando.CommandText = "select max(idTarea) from Tareas";

                int idtarea = Convert.ToInt32(comando.ExecuteScalar());

                /// agrega las actividades 
                comando.CommandText = "insert into  Actividades values(@descripcion,@fecha,@duracion,@idTarea,@estado)";

                foreach (Actividades unaActividad in unaTarea.ListaActividades)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@descripcion", unaActividad.Descripcion);
                    comando.Parameters.AddWithValue("@fecha", unaActividad.Fecha);
                    comando.Parameters.AddWithValue("@duracion", unaActividad.Duracion);
                    comando.Parameters.AddWithValue("@idTarea", idtarea);           
                    comando.Parameters.AddWithValue("@estado", "Realizada");
                    comando.ExecuteNonQuery();
                }
                comando.Transaction.Commit();
                agregado = true;
                this.mensaje = "Tarea agragada correctamente";
            }
            catch (SqlException ex)
            {
                comando.Transaction.Rollback();
                this.mensaje = "Problemas al Agregar " + ex.Message;
            }


            return agregado;
        }

        /// <summary>
        /// metodo para agregar una tarea
        /// </summary>
        /// <param name="unaTarea">
        /// Objeto de de tipo tarea 
        /// </param>
        /// <returns>
        /// true o false
        /// </returns>

        public bool agregarUnaTarea(Tareas unaTarea)
        {
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;

            try
            {
                ///Agrega la tarea
                comando.CommandText = "insert into Tareas values (@descripcion, @idPersona, @estado)";
                comando.Parameters.AddWithValue("@descripcion", unaTarea.Descripcion);
                comando.Parameters.AddWithValue("@idPersona", unaTarea.Persona.IdPersona);
                comando.Parameters.AddWithValue("@estado", unaTarea.Estado);
                comando.ExecuteNonQuery();

                agregado = true;
                this.mensaje = "Tarea Agregada Correctamente";

            }
            catch (SqlException ex)
            {
                this.mensaje = "Problemas al agregar Tarea" + ex.Message;
            }
            return agregado;
        }

        /// <summary>
        /// Metodo que permite Registrar una Activida
        /// </summary>
        /// <param name="unaActividad">
        /// Objeto de Tipo Actividad
        /// </param>
        /// <param name="idtarea">
        /// parametro id tarea de tipo int
        /// </param>
        /// <returns>
        /// true o false
        /// </returns>
        public bool agregarUnaActividad(Actividades unaActividad, int idtarea)
        {
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;

            try
            {
                comando.CommandText = "insert into  Actividades values(@descripcion,@fecha,@duracion,@idTarea,@estado)";
                comando.Parameters.AddWithValue("@descripcion", unaActividad.Descripcion);
                comando.Parameters.AddWithValue("@fecha", unaActividad.Fecha);
                comando.Parameters.AddWithValue("@duracion", unaActividad.Duracion);
                comando.Parameters.AddWithValue("@idTarea", idtarea);
                comando.Parameters.AddWithValue("@estado", unaActividad.Estado);
                comando.ExecuteNonQuery();

                agregado = true;
                this.mensaje = "Actividad Agregada Correctamente";

            }
            catch (SqlException ex)
            {
                this.mensaje = "Problemas al agregar " + ex.Message;
            }

            return agregado;

        }

        /// <summary>
        /// Metodo que obtiene las tareas del usuario
        /// </summary>
        /// <param name="idPersona">
        /// recibe un entero con el id de persona
        /// </param>
        /// <returns>
        /// lista de tareas 
        /// </returns>
        public List<Tareas> listarTareas(int idPersona)
        {
            List<Tareas> lista = new List<Tareas>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = this.miConexion;
                comando.CommandText = "select * from Tareas where Tareas.tarPersona = @idPersona";
                comando.Parameters.AddWithValue("@idPersona", idPersona);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    Tareas unaTarea = new Tareas();
                    unaTarea.IdTarea = Convert.ToInt32(datos["idTarea"]);
                    unaTarea.Descripcion = datos["tarDescripcion"].ToString();
                    unaTarea.Estado = datos["tarEstado"].ToString();

                    lista.Add(unaTarea);

                }
                datos.Close();

            }
            catch (SqlException ex)
            {
                this.mensaje = ex.Message;

            }
            return lista;

        }

        /// <summary>
        /// Metodo que obtiene las Actividades del usuario
        /// por el id de la tarea
        /// </summary>
        /// <param name="idTarea">
        /// recibe un entero con el id de la tarea
        /// </param>
        /// <returns>
        /// Lista de actividades
        /// </returns>
        public List<Tareas> listarActividades(int idTarea)
        {
            List<Tareas> lista = new List<Tareas>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = this.miConexion;
                comando.CommandText = "select Actividades.*, Tareas.tarDescripcion from Actividades " +
                    "inner join Tareas on Tareas.idTarea = Actividades.actTareas " +
                    "where Actividades.actTareas = @idTarea";
                comando.Parameters.AddWithValue("@idTarea", idTarea);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    
                    Tareas unaTarea = new Tareas();
                    unaTarea.Actividades.IdActividad = Convert.ToInt32(datos["idActividad"]);
              
                    unaTarea.Actividades.Descripcion = datos["actDescripcion"].ToString();
               
                    unaTarea.Actividades.Fecha = Convert.ToDateTime(datos["actFecha"]);
              
                    unaTarea.Actividades.Duracion = datos["actDuracion"].ToString();

                    unaTarea.Actividades.Estado = datos["actEstado"].ToString();

                    unaTarea.Descripcion = datos["tarDescripcion"].ToString();


                    lista.Add(unaTarea);

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