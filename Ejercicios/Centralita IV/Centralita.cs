using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Centralita_IV
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public string RutaDeArchivo
        {
            get;
            set;
        }

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float auxiliar = 0;
            if (tipo == TipoLlamada.Local || tipo == TipoLlamada.Todas)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Local listaLocal)
                    {
                        auxiliar += listaLocal.CostoLlamada;
                    }
                }
            }
            if (tipo == TipoLlamada.Provincial || tipo == TipoLlamada.Todas)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Provincial listaPronvincial)
                    {
                        auxiliar += listaPronvincial.CostoLlamada;
                    }
                }
            }

            return auxiliar;
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Razon social: {razonSocial}");
            sb.AppendLine($"Ganancias por llamadas locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancias por llamadas provinciales: {GananciasPorProvincial.ToString("0.##")}");
            sb.AppendLine($"Ganancias totales: {GananciasPorTotal}\n");
            foreach (Llamada item in listaDeLlamadas)
            {
                if (item is Local listaLocal)
                {
                    sb.AppendLine(listaLocal.ToString());
                }
                else if (item is Provincial listaProvincial)
                {
                    sb.AppendLine(listaProvincial.ToString());
                }
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (nuevaLlamada is not null)
            {
                listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if (item == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            try
            {
                CentralitaMetodoException(c, nuevaLlamada);
                c.AgregarLlamada(nuevaLlamada);
                c.Guardar();
            }
            catch (CentralitaException)
            {
                Console.WriteLine($"La llamada siguiente llamada ya se encuentra en el sistema: \n{nuevaLlamada.ToString()} ");
            }
            catch (FallaLogException)
            {
                Console.WriteLine("No se pudo agregar a la bitácora");
            }

            return c;
        }

        public static void CentralitaMetodoException(Centralita c, Llamada nuevaLlamada)
        {
            if (c == nuevaLlamada)
            {
                throw new CentralitaException("", "", "");
            }
        }

        public bool Guardar()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Llamadas de centralita.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(DateTime.Now.ToString("F") + " - Se realizó una llamada");
            sw.Close();

            return true;

        }

        public string Leer()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Llamadas de centralita.txt";

            string texto = string.Empty;
            if (File.Exists(path))
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
