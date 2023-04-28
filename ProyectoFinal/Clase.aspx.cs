using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinal.Clases;
using System.Security.Cryptography;

namespace ProyectoFinal
{
    public partial class Clase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();

        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["Clase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Clase"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Clsclase.Schoolid = int.Parse(tidescuela.Text);
            Clsclase.Clase_Nombre = tnombreclase.Text;
            Clsclase.Descripcion = tdescripcion.Text;

            if (Clsclase.AgregarClase() > 0)
            {
                LlenarGrid();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clsclase.Claselid = int.Parse(TextBox1.Text);
            if (Clsclase.BorrarClase() > 0)
            {
                LlenarGrid();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Clsclase.RefrescarClase() > 0)
            {
                LlenarGrid();
            }
        }
    }
}