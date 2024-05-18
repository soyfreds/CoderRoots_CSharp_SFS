using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos la instancia a la fachada
            FachadaDeProcesos fachada = new FachadaDeProcesos();

            //Hacemos uso de la opcion para el cliente que contiene todo el proceso
            Console.WriteLine("ADQUIRIENDO VUELOS DISPONILES...\n");
            fachada.AdquirirVuelo();
            Console.ReadLine();
        }
    }
}
