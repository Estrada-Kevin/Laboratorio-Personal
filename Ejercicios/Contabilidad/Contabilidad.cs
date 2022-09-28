using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class Contabilidad <T, U>
        where T:Documento
        where U:Documento, new()
    {
        public List<T> egresos;
        public List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T t)
        {
            if(t is not null)
            {
                c.egresos.Add(t);
            }
            return c;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, U u)
        {
            if(u is not null)
            {
                c.ingresos.Add(u);
            }
            return c;
        }
    }
}
