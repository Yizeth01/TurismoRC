using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Visitante_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        EUser eUser = new EUser();
        ClientScriptManager cm = this.ClientScript;
        eUser.UserName = LN_Usuario.UserName.ToString();
        eUser.Clave = LN_Usuario.Password.ToString();

        eUser = new DaoUser().login2(eUser);

        if (eUser == null)
        {
            ((Label)LN_Usuario.FindControl("L_Mensaje")).Text = "USUARIO O CLAVE INCORRECTA";
        }
        else if (eUser.EstadoId == 2)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('SU CUENTA ESTÁ EN PROCESO DE RECUPERACION DE CONTRASEÑA');</script>");
            return;
        }
        else
        {
            Session["userValido"] = eUser;
            Session["user"] = eUser.UserName;
            Session["user_id"] = eUser.Id;
            Session["rol"] = eUser.RolId;
            Session["estado"] = eUser.EstadoId;

            if (Session["userValido"] != null && ((EUser)Session["userValido"]).RolId == 1)

                Response.Redirect("~/View/SuperAdministrador/SuperAdministrador.aspx");

        }

    }
}