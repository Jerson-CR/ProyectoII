using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            if (Clsusuario.ValidarUsuario(tusuario.Text, tclave.Text) > 0)
            {
                Response.Redirect("Inicio.aspx");
            }
            else 
            {
                lmensaje.Text = "Usuario no existe";


            }

        } 

        

    }
}