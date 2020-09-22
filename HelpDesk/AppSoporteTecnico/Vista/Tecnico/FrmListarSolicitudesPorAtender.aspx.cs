using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using iTextSharp.tool.xml;
using itextsharp.pdfa;



namespace AppSoporteTecnico.Vista.Tecnico
{
    public partial class FrmListarSolicitudesPorAtender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string javascript = "listarSolicitudesPorAtender();";
            Page.ClientScript.RegisterStartupScript(Page.GetType(),"myKey", javascript, true);

            int x = Convert.ToInt32(Request.QueryString["x"]);
            switch (x)
            {
                case 1:
                    lblMensaje.Text = "Solicitud Atendida Correctamente";
                    break;
                case 2:
                    lblMensaje.Text = "Problemas al atender la solicitud";
                    break;

            }
        }

        protected void butonExportarPdf_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}