using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class Clsestudiante
    {
        public static int StudentId { get; set; }
        public static int Claseid { get; set; }
        public static string Student_Name { get; set; }
        public static string Student_Number { get; set; }
        public static float Total_Grade { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static string EMail { get; set; }




        public static int AgregarEstudiante()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn3.conexionEstudiante())
                {
                    SqlCommand cmd = new SqlCommand("SP_IngresarStudent", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ClaseId", Claseid));
                    cmd.Parameters.Add(new SqlParameter("@Student_Name", Student_Name));
                    cmd.Parameters.Add(new SqlParameter("@Student_Number", Student_Number));
                    cmd.Parameters.Add(new SqlParameter("@Total_Grade", Total_Grade));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", Telefono));
                    cmd.Parameters.Add(new SqlParameter("@Email", EMail));



                    // retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;

                        }

                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return retorno;

        }
        public static int BorrarEstudiante()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn3.conexionEstudiante())
                {
                    SqlCommand cmd = new SqlCommand("sp_BorrarStudent", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", StudentId));

                    // retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;

                        }

                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return retorno;

        }
        public static int RefrescarEstudiante()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn3.conexionEstudiante())
                {
                    SqlCommand cmd = new SqlCommand("SP_ListadoStudent", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;

                        }

                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return retorno;

        }
    }
}