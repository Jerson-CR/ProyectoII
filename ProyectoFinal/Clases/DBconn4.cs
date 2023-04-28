using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class DBconn4
    {
        int conexion;
        public static SqlConnection conexionCurso()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Curso"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;


        }
    }
}