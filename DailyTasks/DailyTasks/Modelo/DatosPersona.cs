using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DailyTasks.Modelo
{

    /// <summary>
    /// clase DatosPersona 
    /// </summary>
    public class DatosPersona
    {
        private SqlConnection miConexion;
        private string mensaje;


        /// <summary>
        /// constructor de la clase DatosPersona
        /// con la instancia de la conexion conexion
        /// </summary>
        public DatosPersona()
        {
            this.miConexion = Conexion.getConexion();
        }

        /// <summary>
        /// get y set de la variable mensaje de tipo string
        /// </summary>
        public string Mensaje { get => mensaje; }

        /// <summary>
        /// metodo que permite agregar una persona
        /// </summary>
        /// <param name="unaPersona">
        /// objeto de tipo Persona 
        /// </param>
        /// <returns>
        /// true o false
        /// </returns>
        public bool agregarPersona(Persona unaPersona)
        {
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;

            try
            {
                comando.Transaction = this.miConexion.BeginTransaction();
                comando.CommandText = "insert into Personas values(@identificacion,@nombres,@apellidos,@correo)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@identificacion", unaPersona.Identificacion);
                comando.Parameters.AddWithValue("@nombres", unaPersona.Nombres);
                comando.Parameters.AddWithValue("@apellidos", unaPersona.Apellidos);
                comando.Parameters.AddWithValue("@correo", unaPersona.Correo);
                comando.ExecuteNonQuery();

                //obtener idPersona
                comando.CommandText = "select max(idPersona) from Personas";
                int idPersona = Convert.ToInt32(comando.ExecuteScalar());

                comando.CommandText = "insert into Usuarios values(@login,@password,@persona,'Activo')";
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@login", unaPersona.Identificacion);
                comando.Parameters.AddWithValue("@password", unaPersona.Identificacion);
                comando.Parameters.AddWithValue("@persona", idPersona);

                comando.ExecuteNonQuery();
                comando.Transaction.Commit();

                agregado = true;
                this.mensaje = "Usuario agregado correctamente";

            }
            catch (SqlException ex)
            {
                comando.Transaction.Rollback();
                this.mensaje = "Problemas al al agregar " + ex.Message;
            }
            finally 
            {
                if (comando != null)
                {
                    comando.Dispose();
                }
            }


            return agregado;

        }

    }
}