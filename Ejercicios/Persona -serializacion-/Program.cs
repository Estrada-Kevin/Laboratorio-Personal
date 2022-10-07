using System;

namespace Persona__serializacion_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Kevin", "Estrada");
            Persona.GuardarXML(persona);
            Persona.LeerXML();
            Console.WriteLine("_____SEPARADOR_____\n");
            Persona.GuardarJson(persona);
            Persona.LeerJson();
        }
    }
}
