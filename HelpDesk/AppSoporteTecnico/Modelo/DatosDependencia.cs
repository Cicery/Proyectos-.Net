using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AppSoporteTecnico.Modelo
{
    public class DatosDependencia
    {
        private SqlConnection miConexion;
        private string mensaje;

       
        public DatosDependencia()
        {
            this.miConexion = Conexion.getConexion();

        }
        public string Mensaje { get => mensaje; }

        public bool AgregarDependencia(Dependencia unaDependencia)
        {


            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;

            try
            {
                comando.CommandText = "insert into Dependencia values(@Nombre)";
                comando.Parameters.AddWithValue("@Nombre", unaDependencia.NombreDependencia);
               
                comando.ExecuteNonQuery();

                agregado = true;
                this.mensaje = "Dependencia  agregada";

            }
            catch (SqlException ex)
            {

                this.mensaje = "Problemas al agregar " + ex.Message;
            }


            return agregado;
        }
    }
}