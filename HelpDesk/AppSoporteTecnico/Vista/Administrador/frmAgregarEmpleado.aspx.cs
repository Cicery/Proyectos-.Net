using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using AppSoporteTecnico.Modelo;
using System.IO;
using AppSoporteTecnico.Controlador;

namespace AppSoporteTecnico.Vista.Administrador
{
    public partial class formAgregarEmpleado : System.Web.UI.Page
    {
        private ctrlEmpleado objControladorEmpleado = new ctrlEmpleado();
        private DatosEmpleado objEmpleados = new DatosEmpleado();
        private ctrlNegocio objNegocio = new ctrlNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cbDependencia.DataSource = this.objNegocio.obtenerDependencias();
                cbDependencia.DataTextField = "nombreDependencia";
                cbDependencia.DataValueField = "idDependencia";
                cbDependencia.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtIdentificacion.Text != string.Empty) &&
              (txtNombres.Text != string.Empty) &&
              (txtApellidos.Text != string.Empty) &&
              (txtCorreo.Text != string.Empty))
            {
                string identificacion = txtIdentificacion.Text;
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string correo = txtCorreo.Text;
                string cargo = cbCargo.SelectedValue.ToString();
                Dependencia unaDependencia = new Dependencia();
                unaDependencia.IdDependencia = Convert.ToInt32(cbDependencia.SelectedValue);
                unaDependencia.NombreDependencia = cbDependencia.SelectedItem.ToString();


                string rol = cbRol.SelectedValue.ToString();

                Empleado unEmpleado = new Empleado(cargo, unaDependencia, identificacion, nombres, apellidos, correo);
                this.objControladorEmpleado.agregarEmpleado(unEmpleado, rol);
                lblMensaje.Text = this.objControladorEmpleado.Mensaje;

                txtIdentificacion.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtCorreo.Text = "";
            }
            else
            {
                lblMensaje.Text = "Faltan Datos";
            }
        }


    }
}