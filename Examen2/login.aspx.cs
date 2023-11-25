using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CLASES.Clsusuario objusuario = new CLASES.Clsusuario(tclave.Text, tusuario.Text);

            if (CLASES.Clsusuario.ValidarLogin()>0)
            {
                Response.Redirect("USUARIO.ASPX");
            }
            else
            {
                lmensaje.Text = " usuario o contraseña es incorrecto";
            }
            
        }
    }
}