using System.Collections.Generic;

namespace ControlDeAduana
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }
        public void RegistrarImpuestos(Paquete paquete)
        {
            if (paquete is not null)
            {
                impuestosAduana.Add(paquete);
                if (paquete is IAfip)
                {
                    IAfip paqueteAfip = (IAfip)paquete;
                    impuestosAfip.Add(paqueteAfip);
                }
            }
        }
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                RegistrarImpuestos(item);
            }
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal auxiliar = 0;
            foreach (IAduana item in impuestosAduana)
            {
                auxiliar += item.Impuestos;
            }
            return auxiliar;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal auxiliar = 0;
            foreach (IAfip item in impuestosAfip)
            {
                auxiliar += item.Impuestos;
            }
            return auxiliar;
        }


    }
}
