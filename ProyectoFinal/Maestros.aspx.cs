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

namespace ProyectoFinal
{
    public partial class Maestros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }


        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["Maestros"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Teacher"))
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            Clsmaestros.Schoolid = int.Parse(TextBox2.Text);
            Clsmaestros.TeacherName = TextBox3.Text;
            Clsmaestros.Descripcion = TextBox4.Text;


            if (Clsmaestros.AgregarMaestros() > 0)
            {
                LlenarGrid();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clsmaestros.TeacherId = int.Parse(TextBox1.Text);
            if (Clsmaestros.BorrarMaestros() > 0)
            {
                LlenarGrid();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Clsmaestros.RefrescarMaestros() > 0)
            {
                LlenarGrid();
            }
        }
    }
}