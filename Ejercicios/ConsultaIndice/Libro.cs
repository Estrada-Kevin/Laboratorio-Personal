using System.Collections.Generic;

namespace ConsultaIndice
{
    public class Libro
    {
        private List<string> paginas;
        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < this.paginas.Count)
                {
                    return paginas[i];
                }
                return string.Empty;
            }

            set
            {
                if (i > this.paginas.Count)
                {
                    paginas.Add(value);
                }
                else if (i >= 0)
                {
                    paginas.Insert(i, value);
                }
            }
        }
    }

}
