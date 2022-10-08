using System;
using System.IO;
namespace IO__notepad_
{
    public abstract class Archivo
    {
        protected abstract string Extension
        {
            get;
        }

        public bool ValidarSiExisteElArchivo(string path)
        {
            if(File.Exists(path))
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoException("El archivo no se encontró");
            }
        }

        public bool ValidarExtension(string path)
        {
            if(Path.GetExtension(path) == Extension)
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoException($"El archivo no tiene la extension {Extension}");
            }
        }
    }
}
