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
    public partial class Estudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["Estudiantes"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Student"))
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
            Clsestudiante.Claseid = int.Parse(TextBox4.Text);
            Clsestudiante.Student_Name = TextBox1.Text;
            Clsestudiante.Student_Number = TextBox5.Text;
            Clsestudiante.Total_Grade = float.Parse(TextBox6.Text);
            Clsestudiante.Direccion = TextBox7.Text;
            Clsestudiante.Telefono = TextBox8.Text;
            Clsestudiante.EMail = TextBox9.Text;

            if (Clsestudiante.AgregarEstudiante() > 0)
            {
                LlenarGrid();
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Clsestudiante.StudentId = int.Parse(TextBox3.Text);

            if (Clsestudiante.BorrarEstudiante() > 0)
            {
                LlenarGrid();
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            if (Clsestudiante.RefrescarEstudiante() > 0)
            {
                LlenarGrid();
            }

        }
    }
}