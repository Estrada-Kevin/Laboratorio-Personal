using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Centralita_VI
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;

        public string RutaDeArchivo
        {
            get;
            set;
        }
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public Local()
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada1, float costo) : this(llamada1.NroOrigen, llamada1.Duracion, llamada1.NroDestino, costo)
        {

        }

        private float CalcularCosto()
        {
            return Duracion * costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada Local.");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {CostoLlamada}\n");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public bool Guardar()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "Local.xml";
            using (StreamWriter sr = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                serializer.Serialize(sr, this); //solo funciona para un archivo
                return true;
            }

        }

        public Local Leer()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "Local.xml";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Local));
                        Local local = serializer.Deserialize(sr) as Local;

                        return local;
                    }
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("error: formato invalido");
            }
            return null;
        }

    }
}
