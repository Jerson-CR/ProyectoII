using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class Clsescuela
    {
        public static int Schoolid { get; set; }
        public static int id  { get; set; }
        public static string Nombre { get; set; }
        public static string Descripcion  { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }

        public static int AgregarEscuela()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn1.conexionEscuela())
                {
                    SqlCommand cmd = new SqlCommand("SP_IngresarSchool", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@SchoolName", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", Telefono));


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
        public static int BorrarEscuela()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn1.conexionEscuela())
                {
                    SqlCommand cmd = new SqlCommand("sp_borrarSchool", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", Schoolid));

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
        public static int RefrescarEscuela()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn1.conexionEscuela())
                {
                    SqlCommand cmd = new SqlCommand("SP_ListadoSchool", Conn)
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