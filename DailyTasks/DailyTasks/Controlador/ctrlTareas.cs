using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;
using DailyTasks.Modelo;
using DailyTasks.Vista;
using DailyTasks.Vista.Usuarios;

namespace DailyTasks.Controlador
{
    /// <summary>
    /// clase ctrl Tareas
    /// </summary>
    public class ctrlTareas
    {
        private DatosTareas datosTareas;
        private string mensaje;

        /// <summary>
        /// constructor de la ctrlTareas con istancia de la clase 
        /// DatosTareas 
        /// </summary>
        public ctrlTareas()
        {
            datosTareas = new DatosTareas();

        }

        /// <summary>
        /// get y set de la variable mensaje de tipo string
        /// </summary>
        public string Mensaje { get => mensaje; set => mensaje = value; }


        /// <summary>
        /// metodo que recibe y procesa los datos ingresados en la vista,
        /// los envia a su respectivo metodo en el Modelo, para el registro de una nueva tarea y las actividades realizadas
        /// </summary>
        /// <param name="vista">
        /// parametro con con los datos ingresados en la vista
        /// </param>
        /// <returns>true o false</returns>
        public bool agregarTarea(frmAgregarTarea vista)
        {
            bool agregada = false;
            try
            {
                GridView tabla = (GridView)vista.Page.Master.FindControl("c1").FindControl("tblActividades");
                List<Actividades> listaActividades = new List<Actividades>();
                /// ciclo for para agregar varias actividades a la misma tarea
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Actividades actividad = new Actividades();
                    actividad.Fecha = Convert.ToDateTime(tabla.Rows[i].Cells[0].Text);
                    actividad.Duracion = tabla.Rows[i].Cells[1].Text;
                    actividad.Descripcion = tabla.Rows[i].Cells[2].Text;


                    listaActividades.Add(actividad);
                }

                Tareas unaTarea = new Tareas();
                unaTarea.Descripcion = ((TextBox)vista.Page.Master.FindControl("c1").FindControl("txtDescripcionTar")).Text;
                int idPersona = vista.idPersona;
                unaTarea.Persona.IdPersona = idPersona;
                unaTarea.Estado = "Realizada";
                unaTarea.ListaActividades = listaActividades;

                bool registrado = datosTareas.agregarTareas(unaTarea);
                agregada = true;

                this.mensaje = datosTareas.Mensaje;
            }
            catch (Exception ex)
            {
                this.mensaje = ex.Message;
            }

            return agregada;
        }

        /// <summary>
        /// metodo que recibe y procesa los datos ingresados en la vista,
        /// los envia a su respectivo metodo en el Modelo, para agregar mas tareas
        /// </summary>
        /// <param name="vista">
        /// parametro con con los datos ingresados en la vista
        /// </param>
        /// <returns>
        /// true o false
        /// </returns>

        public bool agregarTarea(frmListarTareas vista)
        {
            bool agregada = false;
            try
            {

                Tareas unaTarea = new Tareas();
                unaTarea.Descripcion = ((TextBox)vista.Page.Master.FindControl("c1").FindControl("txtDescripcionT")).Text;
          
                unaTarea.Estado = "Realizada";
                int idPersona = vista.idPersona;
                unaTarea.Persona.IdPersona = idPersona;

                bool registrada = datosTareas.agregarUnaTarea(unaTarea);
                agregada = true;

                this.mensaje = datosTareas.Mensaje;
            }
            catch (Exception ex)
            {
                this.mensaje = ex.Message;
            }
            return agregada;
        }
        /// <summary>
        /// metodo que recibe y procesa los datos ingresados en la vista,
        /// los envia a su respectivo metodo en el Modelo, para agregar mas actividades realizadas a una tarea
        /// </summary>
        /// <param name="vista">
        /// parametro con con los datos ingresados en la vista
        /// </param>
        /// <returns>true o false</returns>
        public bool agregarActividad(ListarActividades vista)
        {
            bool agregada = false;
            try
            {

                int idTarea = Convert.ToInt32(((HiddenField)vista.Page.Master.FindControl("c1").FindControl("txtIdTarea")).Value);

                string descripcion = ((TextBox)vista.Page.Master.FindControl("c1").FindControl("txtDescripcionA")).Text;
                DateTime fecha = Convert.ToDateTime(((TextBox)vista.Page.Master.FindControl("c1").FindControl("txtFechaA")).Text);
                string duracion = ((TextBox)vista.Page.Master.FindControl("c1").FindControl("txtDuracionA")).Text;
                string estado = "Realizada";
                Actividades unaActividad = new Actividades(descripcion, fecha, duracion, estado);

                bool registrada = datosTareas.agregarUnaActividad(unaActividad, idTarea);
                agregada = true;

                this.mensaje = datosTareas.Mensaje;
            }
            catch (Exception ex)
            {
                this.mensaje = ex.Message;
            }
            return agregada;
        }
    }
}