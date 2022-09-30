using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAduana
{
    public class PaquetePesado:Paquete, IAfip
    {
        
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg):base(codigoSeguimiento,costoEnvio,destino,origen,pesoKg)
        {

        }
        decimal IAfip.Impuestos
        {
            get { return costoEnvio * 0.25M; }
        }

        public override bool TienePrioridad
        {
            get { return false; }
        }

        public override decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos + ((IAfip)this).Impuestos;
        }

    }
}
