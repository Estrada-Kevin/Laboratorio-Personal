using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO__notepad_
{
    public class PuntoTxt:Archivo,IArchivo<string>
    {
        protected override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string path, string contenido)
        {
            if(ValidarExtension(path) && ValidarSiExisteElArchivo(path))
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(contenido);
                sw.Close();
            }
        }

        public void GuardarComo(string path, string contenido)
        {
            if(ValidarExtension(path))
            {
                File.WriteAllText(path, contenido);
            }
        }

        public string Leer(string path)
        {
            if(ValidarSiExisteElArchivo(path) && ValidarExtension(path))
            {
                StreamReader sr = new StreamReader(path);
                string texto = sr.ReadToEnd();
                sr.Close();
                return texto;
            }
            return null;
        }
    }
}
