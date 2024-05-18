using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string LocacionPizzeria = "Argentina";
            string ProductoVendido = "Pizza";

            switch (ProductoVendido)
            {
                case "Empanada":
                    var empanadaObj = new Empanada(LocacionPizzeria, ProductoVendido);
                    empanadaObj.Vender(LocacionPizzeria);
                    break;
                case "Pizza":
                    var pizzaObj = new Pizza(LocacionPizzeria, ProductoVendido);
                    pizzaObj.Vender(LocacionPizzeria);
                    break;



            }
            Console.ReadLine();
        }
    }
}
