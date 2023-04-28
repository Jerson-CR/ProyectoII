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
    public partial class School : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["Escuelas"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from School"))
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
            Clsescuela.id = int.Parse(TextBox6.Text);
            Clsescuela.Nombre = TextBox1.Text;
            Clsescuela.Descripcion = TextBox3.Text;
            Clsescuela.Direccion = TextBox4.Text;
            Clsescuela.Telefono = TextBox5.Text;

            if (Clsescuela.AgregarEscuela() > 0)
            {
                LlenarGrid();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clsescuela.Schoolid = int.Parse(TextBox2.Text);
            if (Clsescuela.BorrarEscuela() > 0)
            {
                LlenarGrid();
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Clsescuela.RefrescarEscuela() > 0)
            {
                LlenarGrid();
            }
        }
    }
}