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
                string msg = ex.Message;
                while (ex.InnerException is not null)
                {
                    msg += ex.InnerException.Message;
                    ex = ex.InnerException;
                }
                Console.WriteLine(msg);
            }

        }
    }
}
