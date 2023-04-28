using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Clases
{
    public class Clsclase
    {
        public static int Claselid { get; set; }
        public static int Schoolid { get; set; }
        public static string Clase_Nombre { get; set; }
        public static string Descripcion { get; set; }


        public static int AgregarClase()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn2.conexionClase())
                {
                    SqlCommand cmd = new SqlCommand("SP_IngresarClase", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolId", Schoolid));
                    cmd.Parameters.Add(new SqlParameter("@Clase_Nombre", Clase_Nombre));
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
        public static int BorrarClase()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn2.conexionClase())
                {
                    SqlCommand cmd = new SqlCommand("sp_BorrarClase", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", Claselid));

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

        public static int RefrescarClase()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn2.conexionClase())
                {
                    SqlCommand cmd = new SqlCommand("SP_ListadoClase", Conn)
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