using System;


namespace Lanzar_y_Atrapar
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase.instanciarClase();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.InnerException.Message);
            }

        }
    }
}
