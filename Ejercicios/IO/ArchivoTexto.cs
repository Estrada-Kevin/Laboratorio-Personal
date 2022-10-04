using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path, string txtAGuardar)
        {
            
            if (!File.Exists(path))
            {
                File.WriteAllText(path, txtAGuardar);
            }
            else
            {
                StreamWriter stream = new StreamWriter(path, true);
                stream.WriteLine(txtAGuardar);
                stream.Close();

            }
        }

        public static string Leer(string path)
        {
            string texto=string.Empty;
            if(File.Exists(path))
            {
                texto = File.ReadAllText(path);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return texto;
        }
    }
}
