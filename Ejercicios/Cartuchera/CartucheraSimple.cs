using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public class CartucheraSimple
    {
        List<Boligrafo> boligrafoLista;
        List<Lapiz> lapizLista;
        public CartucheraSimple()
        {
            boligrafoLista = new List<Boligrafo>();
            lapizLista = new List<Lapiz>();
        }

        public List<Boligrafo> BoligrafoLista
        {
            get { return boligrafoLista; }  
        }
        public List<Lapiz> LapizLista
        {
            get { return lapizLista; }
        }

        public bool RecorrerElementos(List<Boligrafo> listaBoligrafo, List<Lapiz> listaLapiz)
        {
            if(RecorrerBoligrafo(listaBoligrafo) == true && RecorrerLapiz(listaLapiz)==true)
            {
                return true;
            }

            return false;
        }

        private bool RecorrerBoligrafo(List<Boligrafo> listaBoligrafo)
        {
            foreach (Boligrafo item in listaBoligrafo)
            {
                if (item.UnidadesDeEscritura > 0)
                {
                    item.UnidadesDeEscritura -= 1;
                    return true;
                }
                if (item.UnidadesDeEscritura <= 0)
                {
                    return false;
                }
                item.Recargar(20);
            }
            return false;
        }

        private bool RecorrerLapiz(List<Lapiz> listaLapiz)
        {
            foreach (Lapiz item in listaLapiz)
            {
                if (item.UnidadesDeEscritura > 0)
                {
                    item.UnidadesDeEscritura -= 1;
                    return true;
                }
                if (item.UnidadesDeEscritura <= 0)
                {
                    return false;
                }
                item.Recargar(20);
            }
            return false;
        }
    }
}
