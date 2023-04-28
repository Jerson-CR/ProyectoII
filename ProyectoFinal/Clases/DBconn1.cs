using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class DBconn1
    {
        int conexion;
        public static SqlConnection conexionEscuela()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Escuelas"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;
        }
    }
}