using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class DBconn3
    {
        int conexion;
        public static SqlConnection conexionEstudiante()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Estudiantes"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;
             

        }
    }
}