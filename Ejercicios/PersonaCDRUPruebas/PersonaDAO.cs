using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaCDRUPruebas
{
    public class PersonaDAO
    {
        string connectionString;
        SqlCommand command;
        SqlConnection connection;
        public PersonaDAO()
        {
            connectionString = @"Data Source=.;Database=Persona;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        public void Guardar(Persona persona)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Persona VALUES (@Nombre,@Apellido)";
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Apellido", persona.Apellido);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("Error en guardar");
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Persona> Leer()
        {
            List<Persona> listaPersona = new List<Persona> { };
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Persona";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPersona.Add(new Persona(Convert.ToInt32(reader["ID"]), reader["Nombre"].ToString(), reader["Apellido"].ToString()));
                    }
                }
                return listaPersona;
            }
            catch (Exception)
            {
                Console.WriteLine("Error en leer");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public Persona LeerPorID(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Persona WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Persona(Convert.ToInt32(reader["ID"]), reader["Nombre"].ToString(), reader["Apellido"].ToString());
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error en Leer por ID");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public void Modificar(int idAModificar, string nombreDeseado, string apellidoDeseado)
        {
            try
            {
                connection.Open();
                command.CommandText = "UPDATE dbo.Persona SET Nombre = @Nombre, Apellido = @Apellido WHERE ID = @ID";
                command.Parameters.AddWithValue("@Nombre", nombreDeseado);
                command.Parameters.AddWithValue("@Apellido", apellidoDeseado);
                command.Parameters.AddWithValue("@ID", idAModificar);
                int rows = command.ExecuteNonQuery();
                Console.WriteLine(rows);

            }
            catch (Exception)
            {
                Console.WriteLine("Error en modificar");
            }
            finally
            {
                connection.Close();
            }
        }

        public void Borrar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "DELETE FROM Persona WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Console.WriteLine("Error en borrar");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
