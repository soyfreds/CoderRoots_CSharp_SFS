using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Archivos : Componente
    {
        public string Extension { get; set; }
        public Archivos(string nombre, int peso, string extension) : base(nombre, peso)
        {
            this.Extension = extension;
        }
    }
}
