using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_IV
{
    public interface IGuardar<T>
    {
        public string RutaDeArchivo { get; set; }
        public bool Guardar();
        public T Leer();
        
    }
}
