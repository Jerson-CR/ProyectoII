using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class DBconn
    {
        int conexion;
        public static SqlConnection conexionUsuario()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Iniciocs"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;
        }

    }
}