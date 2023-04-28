using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class Clscourse
    {
        public static int CourseId { get; set; }
        public static int Schoolid { get; set; }
        public static string CourseName { get; set; }
        public static string Descripcion { get; set; }


        public static int AgregarCurso()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn4.conexionCurso())
                {
                    SqlCommand cmd = new SqlCommand("SP_IngresarCourse", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolId", Schoolid));
                    cmd.Parameters.Add(new SqlParameter("@CourseName", CourseName));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));



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
        public static int BorrarCurso()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn4.conexionCurso())
                {
                    SqlCommand cmd = new SqlCommand("sp_BorrarCourse", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", CourseId));

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
        public static int RefrescarCurso()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn4.conexionCurso())
                {
                    SqlCommand cmd = new SqlCommand("SP_Listadocourse", Conn)
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