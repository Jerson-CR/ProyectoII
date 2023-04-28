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
    public partial class Grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["Grade"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Grade"))
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
            Clsgrade.StudentId = int.Parse(TextBox2.Text);
            Clsgrade.CourseId = int.Parse(TextBox3.Text);
            Clsgrade.Grade = float.Parse(TextBox4.Text);
            Clsgrade.Comment = TextBox5.Text;


            if (Clsgrade.AgregarGrade() > 0)
            {
                LlenarGrid();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clsgrade.GradeId= int.Parse(TextBox1.Text);

            if (Clsgrade.BorrarGrade() > 0)
            {
                LlenarGrid();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Clsgrade.RefrescarGrade() > 0)
            {
                LlenarGrid();
            }
        }
    }
}