using System.Collections.Generic;

namespace Cartuchera
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> acciones;
        public CartucheraMultiuso()
        {
            acciones = new List<IAcciones>();
        }

        public List<IAcciones> Aciones
        {
            get { return acciones; }
        }

        public bool RecorrerElementos(List<IAcciones> acciones)
        {
            if (acciones is not null)
            {
                int cantidadAcciones = acciones.Count;
                int cantidadDescargas = 0;
                foreach (IAcciones item in acciones)
                {
                    if (item.UnidadesDeEscritura > 0)
                    {
                        item.UnidadesDeEscritura--;
                        cantidadDescargas++;
                    }
                    else if (item.UnidadesDeEscritura == 0)
                    {
                        item.Recargar(20);
                    }
                }
                if(cantidadAcciones==cantidadDescargas)
                {
                    return true;
                }
                
                
            }
            return false;
        }
    }
}
