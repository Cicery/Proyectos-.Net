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
    /// clase DatosApp
    /// </summary>
    public class DatosApp
    {
        private SqlConnection miConexion;
        private string mensaje;


        /// <summary>
        /// constructor de la clase DatosApp
        /// con la instancia de la conexion conexion
        /// </summary>
        public DatosApp()
        {
            this.miConexion = Conexion.getConexion();
        }

        /// <summary>
        /// get y set de la variable mensaje de tipo string
        /// </summary>
        public string Mensaje { get => mensaje; set => mensaje = value; }


        /// <summary>
        /// metodo para iniciar sesión
        /// </summary>
        /// <param name="user">
        /// Objeto de tipo Usiario para obtener 
        /// los parametros necesarios para la consulta
        /// </param>
        /// <returns>
        /// Objeto Usuario con sus Datos o null
        /// </returns>
        public Usuario InciarSesion(Usuario user)
        {

            Usuario unUsuario = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;
            try
            {
                comando.CommandText = "select Usuarios.*, Personas.* from Personas " +
                    "inner join Usuarios on Usuarios.usuPersona = Personas.idPersona " +
                    "where Usuarios.usuLogin = @login and Usuarios.usuPassword = @password";
                comando.Parameters.AddWithValue("@login", user.Login);
                comando.Parameters.AddWithValue("@password", user.Password);
                SqlDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {
                    unUsuario = new Usuario();
                    unUsuario = user;
                    unUsuario.IdUsuario = datos.GetInt32(0);
                    unUsuario.Estado = datos.GetString(4);
                    unUsuario.Persona.IdPersona = datos.GetInt32(5);             
                    unUsuario.Persona.Identificacion = datos.GetString(6);
                    unUsuario.Persona.Nombres = datos.GetString(7);
                    unUsuario.Persona.Apellidos = datos.GetString(8);

                }
                datos.Close();
                this.mensaje = "datos Usuarios";
            }
            catch (SqlException ex)
            {
                this.mensaje = ex.Message;
            }
            return unUsuario;
        }

    }
}