using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Centralita_IV;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDAO
{
    public static class ProvincialDAO
    {
        private static string conexionString;
        private static SqlCommand command;
        private static SqlConnection conexion;

        static ProvincialDAO()
        {
            conexionString = @"Data Source=.;Initial Catalog=Centralita;Integrated Security=True";
            command = new SqlCommand();
            conexion = new SqlConnection(conexionString);
            command.Connection = conexion;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Provincial> Leer()
        {
            List<Provincial> lista = new List<Provincial>();
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "SELECT Duracion,Origen,Destino FROM Llamadas WHERE Tipo = 1";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        lista.Add(new Provincial(reader["Origen"].ToString(),Franja.Franja_1,Convert.ToInt32(reader["Duracion"]),reader["Destino"].ToString()));
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error en leer");
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public static void Guardar(Provincial provincial)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "INSERT INTO Llamadas VALUES(@Duracion,@Origen,@Destino,@Costo,@Tipo)";
                command.Parameters.AddWithValue("@Duracion", provincial.Duracion);
                command.Parameters.AddWithValue("@Origen", provincial.NroOrigen);
                command.Parameters.AddWithValue("@Destino", provincial.NroDestino);
                command.Parameters.AddWithValue("@Costo", provincial.CalcularCosto());
                command.Parameters.AddWithValue("@Tipo", 1);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Error en Guardar");
            }
            finally
            {
                conexion.Close();
            }

        }

    }
}
