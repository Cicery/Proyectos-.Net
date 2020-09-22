using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using DailyTasks.Controlador;
using DailyTasks.Modelo;


namespace DailyTasks.Vista.Usuarios
{
    public partial class frmAgregarTarea : System.Web.UI.Page
    {
        public static int consecutivo;
        public static DataTable dt = new DataTable();
        public ctrlTareas ctrlTarea = new ctrlTareas();
        public int idPersona;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            idPersona = Convert.ToInt32(Session["idPersona"]);

            /// validacion de inicio de sesión y tambien inicializacion de tabla GridView
            if (!IsPostBack)
            {
                if (Session["idPersona"] != null)
                {
                    DataRow fila = dt.NewRow();
                    if (dt.Columns.Count == 0)
                    {
                  

                        dt.Columns.Add("Fecha", typeof(string));
                        dt.Columns.Add("Duracion en horas", typeof(string));
                        dt.Columns.Add("Descripción", typeof(string));
                    }
                    tblActividades.DataSource = dt;
                    tblActividades.DataBind();
                }
                else
                {
                    Response.Redirect("../../Vista/Inicio/frmLogin.aspx?x=1");
                }
            }

        }

        /// <summary>
        /// metodo que al hacer click en el boton, 
        /// agrega mas actividades a una tabla GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnAggActividad_Click(object sender, EventArgs e)
        {
            ///validacion de campos si no estan llenos devuelve un mensale a la vista
            if ((txtFecha.Text != string.Empty) && (Convert.ToInt32(txtDuracion.Text) > 0) && (txtDescripcion.Text != string.Empty))
            {
                DataRow fila = dt.NewRow();
                fila[0] = txtFecha.Text;
                fila[1] = txtDuracion.Text;
                fila[2] = txtDescripcion.Text;
                dt.Rows.Add(fila);
                tblActividades.DataSource = dt;
                tblActividades.DataBind();
                consecutivo++;
                txtFecha.Text = "";
                txtDuracion.Text = "0";
                txtDescripcion.Text = "";
                btnAgregarTarea.Visible = true;
                btnBorrarActividades.Visible = true;
                

            }
            else
            {
                lblMensaje.Text = "Debe completar todos los campos de las actividades";
            }

        }

        /// <summary>
        /// metodo que al hacer click envia la vista al controlado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            ///validacion de campos si no estan llenos devuelve un mensale a la vista
            if ((txtDescripcionTar.Text != string.Empty))
            {
                bool registrado = ctrlTarea.agregarTarea(this);
                if (registrado)
                {
                    txtDescripcionTar.Text = "";
                    lblMensaje.Text = ctrlTarea.Mensaje;
                    dt.Rows.Clear();
                    tblActividades.DataSource = dt;
                    tblActividades.DataBind();
                }
                else
                {
                    lblMensaje.Text = "Problemas al agregar -->" + ctrlTarea.Mensaje;

                }
                btnAgregarTarea.Visible = false;
            }
            else
            {
                lblMensaje.Text = "Debe completar el campo de la descripcion de la tarea";
            }
        }

        protected void tbnBorrarActividades_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            tblActividades.DataSource = dt;
            tblActividades.DataBind();

            btnAgregarTarea.Visible = false;
        }
    }
}