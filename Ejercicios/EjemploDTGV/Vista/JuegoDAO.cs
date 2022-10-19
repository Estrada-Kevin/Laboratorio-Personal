using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public static class JuegoDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static JuegoDAO()
        {
            cadenaConexion = @"Data Source=.;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> listaBiblioteca = new List<Biblioteca>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT USUARIOS.USERNAME,JUEGOS.NOMBRE,JUEGOS.GENERO,JUEGOS.CODIGO_JUEGO FROM JUEGOS INNER JOIN USUARIOS on JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaBiblioteca.Add(new Biblioteca(reader["USERNAME"].ToString(), reader["GENERO"].ToString(), reader["NOMBRE"].ToString(), Convert.ToInt32(reader["CODIGO_JUEGO"])));
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
            return listaBiblioteca;
        }

        public static Juego LeerPorId(int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = @ID";
                comando.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        return new Juego(reader["NOMBRE"].ToString(), Convert.ToDouble(reader["PRECIO"]), reader["GENERO"].ToString(), Convert.ToInt32(reader["CODIGO_JUEGO"]), Convert.ToInt32(reader["CODIGO_USUARIO"]));
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error en LeerPorId");
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO JUEGOS VALUES (@CODIGO_USUARIO,@NOMBRE,@PRECIO,@GENERO)";
                comando.Parameters.AddWithValue("@CODIGO_USUARIO", juego.CodigoUsuario);
                comando.Parameters.AddWithValue("@NOMBRE", juego.Nombre);
                comando.Parameters.AddWithValue("@PRECIO", juego.Precio);
                comando.Parameters.AddWithValue("@GENERO", juego.Genero);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Error en guardar");
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "DELETE FROM JUEGOS WHERE CODIGO_JUEGO = @ID";
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Error en Eliminar");
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "UPDATE JUEGOS SET PRECIO = @PRECIO, NOMBRE = @NOMBRE, GENERO = @GENERO WHERE CODIGO_JUEGO = @CODIGO";
                comando.Parameters.AddWithValue("@PRECIO", juego.Precio);
                comando.Parameters.AddWithValue("@NOMBRE", juego.Nombre);
                comando.Parameters.AddWithValue("@GENERO", juego.Genero);
                comando.Parameters.AddWithValue("@CODIGO", juego.CodigoJuego);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Error en Modificar");
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
