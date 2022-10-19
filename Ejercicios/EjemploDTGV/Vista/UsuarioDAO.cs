using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public static class UsuarioDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        static UsuarioDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
                comando = new SqlCommand();
                conexion = new SqlConnection(cadenaConexion);
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT USERNAME,CODIGO_USUARIO FROM USUARIOS";
                
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        listaUsuario.Add(new Usuario(reader["USERNAME"].ToString(), Convert.ToInt32(reader["CODIGO_USUARIO"])));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error en Leer");
            }
            finally
            {
                conexion.Close();
            }
            return listaUsuario;
        }
    }

    
}
