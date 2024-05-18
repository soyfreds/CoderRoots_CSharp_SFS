using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class PizzeriaArgentina : Pizzeria
    {
        public override void VenderEmpanada()
        {
            Console.WriteLine("La pizzeria Argentina vende empanada de Carne");
        }

        public override void VenderPizza()
        {
            Console.WriteLine("La pizzeria Argentina vende Pizza Cancha");
        }
    }
}
