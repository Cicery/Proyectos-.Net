using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AppSoporteTecnico.Modelo
{
    public class DatosEquipo
    {
        private SqlConnection miConexion;
        private string mensaje;

        public DatosEquipo()
        {
            this.miConexion = Conexion.getConexion();

        }
        public string Mensaje { get => mensaje; }

        public Equipo obtenerEquipo(string serial)
        {
            Equipo elEquipo = null;
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = this.miConexion;
                comando.CommandText = "select	Equipos.*, Dependencia.depNombre from Equipos inner join" +
                    "   Dependencia on equipos.equiDependencia=Dependencia.idDependencia where equiSerial=@serial";
                comando.Parameters.AddWithValue("@serial", serial);
                SqlDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {
                    elEquipo = new Equipo();
                    elEquipo.IdEquipo = datos.GetInt32(0);
                    elEquipo.Tipo = datos.GetString(1);
                    elEquipo.Marca = datos.GetString(2);
                    elEquipo.Serial = datos.GetString(3);
                    elEquipo.Dependencia.IdDependencia = datos.GetInt32(4);
                    elEquipo.Dependencia.NombreDependencia = datos.GetString(5);
                }
                datos.Close();
                this.mensaje = "Datos Del Equipo";
            }
            catch (Exception ex)
            {
                this.mensaje = "Problemas al consultar " + ex.Message;

            }
            return elEquipo;
        }
        public bool AgregarEquipo(Equipo unEquipo)
        {


            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.miConexion;

            try
            {
                comando.CommandText = "insert into Equipos values(@Tipo,@Marca,@Serial,@Dependencia)";
                comando.Parameters.AddWithValue("@Tipo", unEquipo.Tipo);
                comando.Parameters.AddWithValue("@Marca", unEquipo.Marca);
                comando.Parameters.AddWithValue("@Serial", unEquipo.Serial);
                comando.Parameters.AddWithValue("@Dependencia", unEquipo.Dependencia.IdDependencia);
                comando.ExecuteNonQuery();

                agregado = true;
                this.mensaje = "Equipo agregado";

            }
            catch (SqlException ex)
            {

                this.mensaje = "Problemas al agregar " + ex.Message;
            }


            return agregado;
        }
    }
}