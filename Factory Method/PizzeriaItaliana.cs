using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class PizzeriaItaliana : Pizzeria
    {
        public override void VenderEmpanada()
        {
            Console.WriteLine("La pizzeria Italiana vende empanada Caprisse");
        }

        public override void VenderPizza()
        {
            Console.WriteLine("La pizzeria Italiana vende Pizza Napolitana");
        }
    }
}
