using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //Clase padre
    public abstract class Componente
    {
        public string Nombre { get; set; }
        public int Peso { get; set; }

        public Componente(string nombre, int peso)
        {
            Nombre = nombre;
            Peso = peso;
        }

    }
}
