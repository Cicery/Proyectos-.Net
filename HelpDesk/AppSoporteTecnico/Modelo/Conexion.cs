using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AppSoporteTecnico.Modelo
{
    public class Conexion
    {
        private static SqlConnection objConexion;
        private static string mensaje;

        public static SqlConnection getConexion()
        {
            if (objConexion != null)
                return objConexion;
            objConexion = new SqlConnection();
            objConexion.ConnectionString = @"Data Source=CICERY;Initial Catalog=HelpDeks;User ID=sa;Password=sa";
            try
            {
                objConexion.Open();
                return objConexion;
            }
            catch (SqlException ex)
            {
                mensaje = ex.Message;
                return null;
            }
        }
    }
}