using System.Collections.Generic;

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

            if (RecorrerBoligrafo(listaBoligrafo) && RecorrerLapiz(listaLapiz))
            {
                return true;
            }



            return false;

        }

        private bool RecorrerBoligrafo(List<Boligrafo> listaBoligrafo)
        {
            if (listaBoligrafo is not null)
            {
                int cantidadAcciones = listaBoligrafo.Count;
                int cantidadDescargas = 0;
                foreach (Boligrafo item in listaBoligrafo)
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
                    if(cantidadAcciones==cantidadDescargas)
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        private bool RecorrerLapiz(List<Lapiz> listaLapiz)
        {
            if (listaLapiz is not null)
            {
                int cantidadAcciones = listaLapiz.Count;
                int cantidadDescargas = 0;
                foreach (Lapiz item in listaLapiz)
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
                    if(cantidadDescargas==cantidadAcciones)
                    {
                        return true;
                    }

                }
            }

            return false;
        }
    }
}
