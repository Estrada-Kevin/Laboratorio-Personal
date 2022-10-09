using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Centralita_IV
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        protected Franja franjaHoraria;

        public Franja FranjaHoraria
        {
            get { return franjaHoraria; }
            set { franjaHoraria = value; }
        }

        public string RutaDeArchivo
        {
            get;
            set;
        }

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public Provincial()
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public float CalcularCosto()
        {
            if (franjaHoraria == Franja.Franja_1)
            {
                return Duracion * (float)0.99;
            }
            else if (franjaHoraria == Franja.Franja_2)
            {
                return Duracion * (float)1.25;
            }
            else
            {
                return Duracion * (float)0.66;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada Provincial.");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja: {franjaHoraria}");
            sb.AppendLine($"Costo de llamada: {CostoLlamada.ToString("0.##")}\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public bool Guardar()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "Provincial.xml";
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                serializer.Serialize(sw, this);
                return true;
            }
        }

        public Provincial Leer()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "Provincial.xml";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                        Provincial provincial = serializer.Deserialize(sr) as Provincial;

                        return provincial;
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
