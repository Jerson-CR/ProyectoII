using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class Clsmaestros
    {
        public static int TeacherId { get; set; }
        public static int Schoolid { get; set; }
        public static string TeacherName { get; set; }
        public static string Descripcion { get; set; }


        public static int AgregarMaestros()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn5.conexionMaestros())
                {
                    SqlCommand cmd = new SqlCommand("SP_IngresarTeacher", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolId", Schoolid));
                    cmd.Parameters.Add(new SqlParameter("@TeacherName", TeacherName));
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
        public static int BorrarMaestros()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn5.conexionMaestros())
                {
                    SqlCommand cmd = new SqlCommand("sp_BorrarTeacher", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", TeacherId));

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
        public static int RefrescarMaestros()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn5.conexionMaestros())
                {
                    SqlCommand cmd = new SqlCommand("SP_ListadoTeacher", Conn)
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