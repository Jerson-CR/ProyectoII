using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class DBconn6
    {
        int conexion;
        public static SqlConnection conexionGrade()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Grade"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;


        }
    }
}