using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Examen2.CLASES
{
    public class Clsusuario
    {
        private static string clave;
        private static string correo;

        public Clsusuario(string Clave, string Correo)
        {
            clave = Clave;
            correo = Correo;
        }

        public int MyProperty { get; set; }

        private static string nombre;

       


        public static string GetClave()
        {

            return clave;

        }

        public static string Getcorreo()

        {
            return correo;

        }

        public static string Getnombre()
        {
            return nombre;
        }

        public void SetClave(string contrasena)
        {
            clave = contrasena;
        }

        public void Setusuario(string Correo)

        {
            correo = Correo;

        }

        public void Setnombre(string Nombre)
        {
            nombre = Nombre;
        }


        public static int ValidarLogin()
        {
            int retorno = 0;
            int tipo = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("VALIDARUSUARIOLOGIN", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));
                    cmd.Parameters.Add(new SqlParameter("@clave", clave));

                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader lectura = cmd.ExecuteReader())
                    {
                        if (lectura.Read())
                        {
                            retorno = 1;
                            
                            

                        }
                        else
                        {
                            retorno = -1;
                            
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