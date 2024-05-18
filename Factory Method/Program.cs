using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ya no llamaríamos así
            //Pizzeria PizzeriaActual = new PizzeriaArgentina();
            //Si no así
            Console.WriteLine("    *****\n   *     *\n   *******\n   *     *\n   *  #  *\n   *******");
            Pizzeria PizzeriaActual = CreadoraPizzerias.CrearPizzeria(2);
            PizzeriaActual.VenderEmpanada();
            PizzeriaActual.VenderPizza();
            Console.ReadLine();
        }
    }
}
