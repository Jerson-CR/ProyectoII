using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class DBconn2
    {
        int conexion;
        public static SqlConnection conexionClase()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Clase"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;
        }
    }
}