using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAduana
{
    public abstract class Paquete:IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        public abstract bool TienePrioridad
        {
            get;
        }

        public decimal Impuestos
        {
            get { return costoEnvio * 0.35M; }
            
        }
        public Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;   
        }

        public virtual decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos;
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Informacion del paquete:");
            sb.AppendLine($"Codigo de seguimiento: {codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {costoEnvio}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Peso: {pesoKg}");
            if(TienePrioridad)
            {
                sb.AppendLine($"Tiene prioridad.");
            }
            else
            {
                sb.AppendLine($"No tiene prioridad.");
            }
            

            return sb.ToString();

        }


    }
}
