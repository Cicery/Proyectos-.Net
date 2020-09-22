using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSoporteTecnico.Controlador;
using AppSoporteTecnico.Modelo;

namespace AppSoporteTecnico.Vista.Funcionario
{
    public partial class FrmSolicitud : System.Web.UI.Page
    {
        public static int consecutivo;
        public static int Ticket;
        public static DataTable dt = new DataTable();
        public static int idEquipo;
        public ctrlSolicitudes ctrlSolicitud = new ctrlSolicitudes();
        public static ctrlEquipo ctrlEquip = new ctrlEquipo();
        public int idEmpleado;

        protected void Page_Load(object sender, EventArgs e)
        {
            idEmpleado = Convert.ToInt32(Session["idEmpleado"]);
            if (!IsPostBack)
            {
                DataRow fila = dt.NewRow();
                if (dt.Columns.Count == 0)
                {
                    dt.Columns.Add("id", typeof(string));
                    dt.Columns.Add("Serial", typeof(string));
                    dt.Columns.Add("Observacion", typeof(string));
                }
                tblSolicitud.DataSource = dt;
                tblSolicitud.DataBind();
            }

        }

        public void generarTiket()
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(1000, 9999);
            Ticket = numero;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if((txtSerial.Text !=string.Empty) && (txtObservaciones.Text != string.Empty))
            {
                DataRow fila = dt.NewRow();

                int idEquipo = obtenerEquipo(txtSerial.Text).IdEquipo;
                fila[0] = idEquipo;
                fila[1] = txtSerial.Text;
                fila[2] = txtObservaciones.Text;
                dt.Rows.Add(fila);
                tblSolicitud.DataSource = dt;
                tblSolicitud.DataBind();
                consecutivo++;
                txtObservaciones.Text = "";
                txtSerial.Text = "";
                btnRegistrar.Visible = true;

            }
            else
            {
                lblMensaje.Text = "Debe Ingresar Datos";
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            generarTiket();
            bool registrado = ctrlSolicitud.agregarSolicitud(this);
            if (registrado)
            {
                lblMensaje.Text = ctrlSolicitud.Mensaje + "Con el Ticket: " + Ticket;
                dt.Rows.Clear();
                tblSolicitud.DataSource = dt;
                tblSolicitud.DataBind();
            }
            else
            {
                lblMensaje.Text = "Problemas al Agregar-------> " + ctrlSolicitud.Mensaje;
            }
            btnRegistrar.Visible = false;
        }
      
[WebMethod]
public static Equipo obtenerEquipo(string serial)
{
   Equipo elEquipo = ctrlEquip.obtenerEquipo(serial);
   return elEquipo;
}

    }
}