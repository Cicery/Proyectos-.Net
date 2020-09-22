using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace AppSoporteTecnico.Modelo
{
    public class DatosNegocio
    {


        private SqlConnection miConexion;
        private string mensaje;

        public DatosNegocio()
        {
            this.miConexion = Conexion.getConexion();

        }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public List<Dependencia> listarDependencia()
        {
            List<Dependencia> lista = new List<Dependencia>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;

            try
            {
                comando.CommandText = "select * from Dependencia";
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    Dependencia unaDependencia = new Dependencia();
                    unaDependencia.IdDependencia = datos.GetInt32(0);
                    unaDependencia.NombreDependencia = datos.GetString(1);

                    lista.Add(unaDependencia);
                }
                datos.Close();
                this.Mensaje = "listado de dependencia";
            }

            catch (SqlException ex)
            {
                this.Mensaje = ex.Message;
            }
            return lista;

        }

        public Usuario InciarSesion(Usuario user)
        {

            Usuario unUsuario = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;
            try
            {
                comando.CommandText = "select Usuario.*, Empleado.*, Personas.* from Empleado inner join Personas on Empleado.empPersona=Personas.idPersona"
                + " inner join Usuario on Usuario.usuEmpleado = Empleado.idEmpleado where Usuario.usulogin=@login and Usuario.usuPassword=@password";
                comando.Parameters.AddWithValue("@login", user.Login);
                comando.Parameters.AddWithValue("@password", user.Password);
                SqlDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {
                    unUsuario = new Usuario();
                    unUsuario = user;
                    unUsuario.IdUsuario = datos.GetInt32(0);
                    unUsuario.Rol = datos.GetString(4);
                    unUsuario.Estado = datos.GetString(5);
                    unUsuario.Empleado.IdEmpleado= datos.GetInt32(6);
                    unUsuario.Empleado.Cargo = datos.GetString(8);
                    unUsuario.Empleado.IdPersona = datos.GetInt32(10);
                    unUsuario.Empleado.Identificacion = datos.GetString(11);
                    unUsuario.Empleado.Nombres = datos.GetString(12);
                    unUsuario.Empleado.Apellidos = datos.GetString(13);

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