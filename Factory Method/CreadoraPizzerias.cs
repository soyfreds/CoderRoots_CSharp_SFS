using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class CreadoraPizzerias
    {
        public const int PA = 1;
        public const int PI = 2;

        public static Pizzeria CrearPizzeria(int TipoPizzeria)
        {
            try
            {
                switch (TipoPizzeria)
                {
                    case PA:
                        return new PizzeriaArgentina();

                    case PI:
                        return new PizzeriaItaliana();
                    default: return null;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
