using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO__notepad_
{
    public class PuntoXml<T>:Archivo,IArchivo<T>
        where T : class
    {
        protected override string Extension
        {
            get { return ".xml"; }
        }

        public void Guardar(string path, T contenido)
        {
            if(ValidarExtension(path) && ValidarSiExisteElArchivo(path))
            {
                SerializarXml(path, contenido);
            }
        }

        public void GuardarComo(string path, T contenido)
        {
            if(ValidarExtension(path))
            {
                SerializarXml(path,contenido);
            }
        }

        public T Leer(string path)
        {
            if(ValidarSiExisteElArchivo(path) && ValidarExtension(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xmlserializer = new XmlSerializer(typeof(T));
                    return xmlserializer.Deserialize(sr) as T;
                }
            }
            return null;
        }

        public void SerializarXml(string path, T contenido)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, contenido);
            }
        }
        
    }
}
