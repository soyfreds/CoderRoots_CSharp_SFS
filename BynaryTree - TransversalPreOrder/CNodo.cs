using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BynaryTree___TransversalPreorder
{
    class CNodo
    {
        private int dato;
        private CNodo izq; //Recursivo se llama a sí mismo para generar nodo hijo
        private CNodo der; //Recursivo se llama a sí mismo para generar nodo hijo

        public int Dato { get => dato; set => dato = value; }
        internal CNodo Izq { get => izq; set => izq = value; }
        internal CNodo Der { get => der; set => der = value; }

        public CNodo()
        {
            dato = 0;
            izq = null;
            der = null;

        }

    }
}
