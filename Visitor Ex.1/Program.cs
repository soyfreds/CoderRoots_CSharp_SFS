using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var computadora = new Computadora();
            var zapato = new Zapato();
            var lapiz = new Lapiz();



            var iva = new PrecioConIva(13);
            var iva2 = new PrecioConIva(2);

            Console.WriteLine("**PRECIO NETO DE LA COMPUTADORA: ${0}", computadora.Precio);
            computadora.AceptarVisita(iva);
            Console.WriteLine("El precio de la computadora con el IVA al {0}% es de: ${1}", iva.CantidadIVA, computadora.Precio);
            Console.WriteLine("############################################# \n");


            Console.WriteLine("**PRECIO NETO DE EL PAR DE ZAPATOS ES: ${0}", zapato.Precio);
            zapato.AceptarVisita(iva2);
            Console.WriteLine("El precio de el par de zapatos con el IVA al {0}% es de: ${1}", iva2.CantidadIVA, zapato.Precio);
            Console.WriteLine("############################################# \n");

            Console.WriteLine("**PRECIO NETO DE EL LAPIZ ES: ${0}", lapiz.Precio);
            lapiz.AceptarVisita(iva);
            Console.WriteLine("El precio del lápiz con el IVA al {0}% es de: ${1}", iva.CantidadIVA, lapiz.Precio);
            Console.WriteLine("############################################# \n");
        }
    }
}
