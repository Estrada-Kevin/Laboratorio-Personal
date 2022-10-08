using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace IO__notepad_
{
    public class PuntoJson<T>:Archivo,IArchivo<T>
        where T : class
    {
        protected override string Extension
        {
            get { return ".json"; }
        }

        public void Guardar(string path, T contenido)
        {
            if(ValidarSiExisteElArchivo(path) && ValidarExtension(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    string jsonString = JsonSerializer.Serialize(contenido);
                    sw.WriteLine(jsonString);
                }
            }
        }

        public void GuardarComo(string path, T contenido)
        {
            if (ValidarExtension(path))
            {
                string jsonString = JsonSerializer.Serialize(contenido);
                File.WriteAllText(path, jsonString);
            }
        }

        public T Leer(string path)
        {
            if(ValidarSiExisteElArchivo(path) && ValidarExtension(path))
            {
                string jsonString = File.ReadAllText(path);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            return null;
        }
    }
}
