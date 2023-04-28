using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class Clsgrade
    {
        public static int GradeId { get; set; }
        public static int StudentId { get; set; }
        public static int CourseId { get; set; }
        public static float Grade { get; set; }
        public static string Comment { get; set; }

        public static int AgregarGrade()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn6.conexionGrade())
                {
                    SqlCommand cmd = new SqlCommand("SP_IngresarGrade", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@StudentId", StudentId));
                    cmd.Parameters.Add(new SqlParameter("@CourseId", CourseId));
                    cmd.Parameters.Add(new SqlParameter("@Grade", Grade));
                    cmd.Parameters.Add(new SqlParameter("@Comment", Comment));



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
        public static int BorrarGrade()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn6.conexionGrade())
                {
                    SqlCommand cmd = new SqlCommand("sp_BorrarGrade", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", GradeId));

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
        public static int RefrescarGrade()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn6.conexionGrade())
                {
                    SqlCommand cmd = new SqlCommand("SP_IngresarGrade", Conn)
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