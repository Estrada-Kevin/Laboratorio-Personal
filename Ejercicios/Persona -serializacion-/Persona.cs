using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace Persona__serializacion_
{
    public class Persona
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "Persona.xml";
        static string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "Persona.json";
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public Persona()
        {

        }

        public Persona(string nombre, string apellido):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void GuardarXML(Persona persona)
        {
            try
            {
                using (StreamWriter streamWrite = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    xmlSerializer.Serialize(streamWrite, persona);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error: Nombre inválido");
            }
            
            
        }

        public static void LeerXML()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    Persona LeerPersona = xmlSerializer.Deserialize(streamReader) as Persona;

                    Console.WriteLine(LeerPersona.ToString());
                }
                
            }
            catch (IOException)
            {
                Console.WriteLine("Error: Nombre inválido");
            }
        }

        public static void GuardarJson(Persona persona)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(persona);
                File.WriteAllText(path2, jsonString);
            }
            catch (JsonException)
            {
                Console.WriteLine("Error: Nombre inválido");
            }
        }

        public static void LeerJson()
        {
            try
            {
                string jsonString = File.ReadAllText(path2);
                Persona leerPersona = JsonSerializer.Deserialize<Persona>(jsonString);
                Console.WriteLine(leerPersona.ToString());
            }
            catch (JsonException)
            {
                Console.WriteLine("Error en el formato del archivo");
            }
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");

            return sb.ToString();
        }
    }
}
