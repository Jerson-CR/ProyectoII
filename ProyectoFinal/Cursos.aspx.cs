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
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["Curso"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Course"))
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
            Clscourse.Schoolid = int.Parse(TextBox3.Text);
            Clscourse.CourseName = TextBox2.Text;
            Clscourse.Descripcion = TextBox4.Text;

            if (Clscourse.AgregarCurso() > 0)
            {
                LlenarGrid();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clscourse.CourseId = int.Parse(TextBox1.Text);
            if (Clscourse.BorrarCurso() > 0)
            {
                LlenarGrid();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Clscourse.RefrescarCurso() > 0)
            {
                LlenarGrid();
            }

        }
    }
}