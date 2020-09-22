using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

using DailyTasks.Modelo;

namespace DailyTasks.Controlador
{
    public partial class ctrlRESTfulTareas : System.Web.UI.Page
    {
        /// <summary>
        /// instancia de la clase DatosTareas en el modelo
        /// </summary>
        public static DatosTareas objDatosTarea = new DatosTareas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metodo que obtiene la lista de tareas del usuario en el Modelo segun el id de la persona
        /// 
        /// Estos datos son procesados por javaScript
        /// </summary>
        /// <param name="idPersona">
        /// parametro idPersona de tipo int 
        /// </param>
        /// <returns>
        /// List<Tareas> con los datos de las tareas o sin ellos
        /// </returns>
        [WebMethod]
        public static List<Tareas> listarTareas(int idPersona)
        {
            return (objDatosTarea.listarTareas(idPersona));
        }

        /// <summary>
        /// metodo que obtiene la lista de actividades en el Modelo segun el id de tarea 
        /// 
        /// Estos datos son procesados por javaScript
        /// </summary>
        /// <param name="idTarea">
        /// parametro idTarea de tipo int
        /// </param>
        /// <returns>
        /// List<Tareas> con los datos de las actividades o sin ellos 
        /// </returns>
        [WebMethod]
        public static List<Tareas> listarActividades(int idTarea)
        {
            return (objDatosTarea.listarActividades(idTarea));
        }

    }
}
