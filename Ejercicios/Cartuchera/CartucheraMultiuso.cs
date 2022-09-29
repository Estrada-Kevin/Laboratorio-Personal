using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (IAcciones item in acciones)
            {
                if(item.UnidadesDeEscritura>0)
                {
                    item.UnidadesDeEscritura -= 1;
                    return true;
                }
                if(item.UnidadesDeEscritura <= 0)
                {
                    return false;
                }
                item.Recargar(20);
            }
            
            return false;
        }
    }
}
