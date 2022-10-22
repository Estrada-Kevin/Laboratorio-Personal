using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Centralita_IV;
using System.Threading.Tasks;

namespace EntidadesDAO
{
    public static class LocalDAO
    {
        private static string conexionString;
        private static SqlCommand command;
        private static SqlConnection conexion;

        static LocalDAO()
        {
            conexionString = @"Data Source=.;Initial Catalog=Centralita;Integrated Security=True";
            conexion = new SqlConnection(conexionString);
            command = new SqlCommand();
            command.Connection = conexion;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Local> Leer()
        {
            List<Local> lista = new List<Local>();
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "SELECT Origen,Duracion,Destino,Costo FROM Llamadas WHERE Tipo = 0";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        double d = (double)reader["Costo"];
                        lista.Add(new Local(reader["Origen"].ToString(), Convert.ToInt32(reader["Duracion"]), reader["Destino"].ToString(), (float)d));
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

            return lista;
        }

        public static void Guardar(Local local)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "INSERT INTO Llamadas VALUES(@Duracion,@Origen,@Destino,@Costo,@Tipo)";
                command.Parameters.AddWithValue("@Duracion", local.Duracion);
                command.Parameters.AddWithValue("@Origen", local.NroOrigen);
                command.Parameters.AddWithValue("@Destino", local.NroDestino);
                command.Parameters.AddWithValue("@Costo", local.Costo);
                command.Parameters.AddWithValue("@Tipo", 0);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
