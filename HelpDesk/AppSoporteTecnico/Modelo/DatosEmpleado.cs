using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AppSoporteTecnico.Modelo
{
    public class DatosEmpleado
    {
        private SqlConnection miConexion;
        private string mensaje;

        public DatosEmpleado()
        {
            this.miConexion = Conexion.getConexion();
         
        }
        public string Mensaje { get => mensaje; }

        public bool AgregarEmpleado(Empleado unEmpleado, string rol)
        {
          

            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;

            try
            {
                
                comando.Transaction = this.miConexion.BeginTransaction();
                comando.CommandText = "insert into Personas values(@identificacion,@nombres,@apellidos,@correo)";
                comando.Parameters.AddWithValue("@identificacion", unEmpleado.Identificacion);
                comando.Parameters.AddWithValue("@nombres", unEmpleado.Nombres);
                comando.Parameters.AddWithValue("@apellidos", unEmpleado.Apellidos);
                comando.Parameters.AddWithValue("@correo", unEmpleado.Correo);
                comando.ExecuteNonQuery();
                //obtener idPersona
                comando.CommandText = "select max(idPersona) from Personas";
                int idPersona = Convert.ToInt32(comando.ExecuteScalar());
                //agregar Empleados
                comando.CommandText = "insert into Empleado values(@idPersona,@cargo,@dependencia)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idPersona", idPersona);
                comando.Parameters.AddWithValue("@cargo", unEmpleado.Cargo);
                comando.Parameters.AddWithValue("@dependencia", unEmpleado.Dependencia.IdDependencia);
                comando.ExecuteNonQuery();

                //obtener id del empleado
                comando.CommandText = "select max(idEmpleado) from Empleado";
                int idEmpleado = Convert.ToInt32(comando.ExecuteScalar());
                //agregar a usuarios
                comando.CommandText = "insert into Usuario values(@idEmpleado,@login,@password,@rol,'Activo')";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                comando.Parameters.AddWithValue("@login", unEmpleado.Identificacion);
                comando.Parameters.AddWithValue("@password", unEmpleado.Identificacion);
                comando.Parameters.AddWithValue("@rol", rol);
                comando.ExecuteNonQuery();
                comando.Transaction.Commit();




                agregado = true;
                this.mensaje = "Empleado agregado";

            }
            catch (SqlException ex)
            {
                comando.Transaction.Rollback();
                this.mensaje = "Problemas al al agregar " + ex.Message;
            }


            return agregado;
        }
    }
}