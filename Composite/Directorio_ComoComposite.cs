using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class DirectorioComposite : Componente
    {
        //Como un directorio contiene varios archivos entonces hacemos una lista para guardarlos
        private List<Componente> Archivos = new List<Componente>();

        public DirectorioComposite(string nombre, int peso = 0) : base(nombre, peso)
        {

        }

        public void Add(Componente cElemento)
        {
            Archivos.Add(cElemento);
        }

        public void Remove(Componente cElemento)
        {
            Archivos.Remove(cElemento);
        }

        public int PesoTotal
        {
            get
            {
                int valor = 0;
                foreach (var cElemento in Archivos)
                {
                    if (cElemento.GetType().Name == "DirectorioComposite")
                    {
                        valor += ((DirectorioComposite)cElemento).Peso;
                    }
                    else
                    {
                        valor += cElemento.Peso;
                    }

                }
                return valor;
            }


        }

        public void MostrarContenido()
        {
            Console.WriteLine("El directorio contiene: \n");
            foreach (var cElemento in Archivos)
            {
                Console.WriteLine("Un archivo " + cElemento.Nombre + "\n");

            }
        }

    }
}
