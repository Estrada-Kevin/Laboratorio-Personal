using System;
using IO;
namespace Lanzar_y_atrapar_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = $"{escritorio}\\{DateTime.Now.ToString("yyyyMMdd-hhmm")}.txt";

            try
            {
                OtraClase.instanciarClase();

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                while (ex.InnerException is not null)
                {
                    msg += ex.InnerException.Message;
                    ex = ex.InnerException;

                }    
                ArchivoTexto.Guardar(path, msg);
            }

            Console.WriteLine(ArchivoTexto.Leer(path));
        }
    }
}
