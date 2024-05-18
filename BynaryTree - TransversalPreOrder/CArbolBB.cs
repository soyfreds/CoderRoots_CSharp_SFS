using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BynaryTree___TransversalPreorder
{
    class CArbolBB
    {
        private CNodo raiz;
        private CNodo trabajo; //Variable para apoyarnos en diferentes operaciones
        private int i = 0; // Nos ayudará a identar la impresion en consola

        public CArbolBB()
        {
            raiz = null;
        }

        internal CNodo Raiz { get => raiz; set => raiz = value; } // Nos permite obtener la raíz o cambiarla




        //Insertar - Este es un metodo recursivo
        public CNodo Insertar(int pDato, CNodo pNodo)
        {
            CNodo temp = null;

            //Si no hay nadie a quien insertar entonces insertamos el nodo
            if (pNodo==null)
            {
                temp = new CNodo();
                temp.Dato = pDato;
                return temp;
            }

            //Si el dato es menor que el dato que tenemos lo enviamos a la izquierda
            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);// Primera llamada recursiva donde enviamos a tarbajar a la izquierda
            }

            //Si el dato es menor que el dato que tenemos lo enviamos a la derecho
            if (pDato > pNodo.Dato)
            {
                pNodo.Der = Insertar(pDato, pNodo.Der); // Primera llamada recursiva donde enviamos a trabajar a la derecha
            }

            return pNodo;
        }


        //Transversa, donde procesaremos el arbol y haremos algo con el
        public void Transversa(CNodo pNodo)
        {
            //Esta es la base, cuando ya no hay nada mas que procesar
            if (pNodo == null)
                return;

            //Me proceso primero a mí / Acá llevo la identación para comprender en consola
            for (int n=0;n<i;n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            //Si tengo Izquierda entonces proceso a la izquierda
            if (pNodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(pNodo.Izq);
                i--;
            }

            //Si tengo Derecha entonces proceso a la derecha
            if (pNodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(pNodo.Der);
                i--;
            }
        }





    }
}
