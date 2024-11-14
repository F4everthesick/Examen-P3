using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_P3.Controller;

namespace Examen_P3.Views
{
    public partial class Login : System.Web.UI.Page
    {
        ValidarLogin validar = new ValidarLogin();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserTxtbx.Text;
            string password = PasswordTxtbx.Text;

            // Agregar validacion de base de datos
            if (validar.Logeo(username, password))
            {
                //Atrapar la sesion
                Session["klopez"] = username;
                Response.Redirect("Index.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario o contraseña incorrectos');</script>");
            }
        }
    }
}