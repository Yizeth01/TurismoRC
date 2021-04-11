using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_SuperAdministrador_Solicitudes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int rol = (int)Session["rol"];
        if(rol == null)
        {
            Response.Redirect("~/View/Visitante/Login.aspx");
        }
        else if (rol != 1)
        {
            Response.Redirect("~/View/Visitante/Login.aspx");
        }
    }

    protected void GV_Solicitudes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "aceptar")
        {
            EUser solicitud = new EUser();
            ERegistro solicitud2 = new ERegistro();
            DaoSolicitudes solicitudes = new DaoSolicitudes();
            ESolicitudToken token = new ESolicitudToken();


            int index = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = GV_Solicitudes.Rows[index];


            token.Nombre = ((Label)row.FindControl("Label2")).Text;
            token.Correo = ((Label)row.FindControl("Label4")).Text;

            String userToken = encriptar(JsonConvert.SerializeObject(token));
            solicitudes.almacenarToken(userToken, token.Correo);
            CorreoAceptacion correo = new CorreoAceptacion();

            String userToken = "Hola " + token.Nombre + "tu solicitud ha sido aceptada. Ahora puedes " +
                    "ser nuestro cliente. Ya puedes ingresar a tu perfil con el usuario y clave" +
                    "que proporcionaste. TURISMORC";
            correo.enviarCorreo(token.Correo, userToken, mensaje);
        }
    }
    

    
}