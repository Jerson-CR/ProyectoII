using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class DBconn5
    {
        int conexion;
        public static SqlConnection conexionMaestros()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Maestros"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;


        }
    }
}