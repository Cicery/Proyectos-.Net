using System;
using System.Collections.Generic;
using System.Text;

namespace EVoteDAL
{
    public class Conexion
    {
        private static SqlConnection objConexion;
        private static string mensaje;

        /// <summary>
        /// metodo para realizar la conexion 
        /// </summary>
        /// <returns>
        /// retorna objConexion de tipo SqlConnection o null
        /// </returns>

        public static SqlConnection getConexion()
        {
            if (objConexion != null)
                return objConexion;
            objConexion = new SqlConnection();
            objConexion.ConnectionString = @"Data Source=Cicery; Initial Catalog=DailyTasks;Integrated Security=True";
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
