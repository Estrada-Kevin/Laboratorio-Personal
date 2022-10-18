using System;
using System.Collections.Generic;

namespace PersonaCDRUPruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonaDAO personaDAO = new PersonaDAO();
            Persona personaAGuardar = new Persona("Natalia", "Crespo");
            //personaDAO.Guardar(personaAGuardar);
            //personaDAO.Borrar(6);
            //personaDAO.Modificar(7, "Natalia", "Gimenez");
            //Console.WriteLine(personaDAO.LeerPorID(7).ToString());

            //List<Persona> listaPersona = personaDAO.Leer();

            //foreach (Persona item in listaPersona)
            //{
            //    Console.WriteLine(item.ToString());
            //}



        }
    }
}

