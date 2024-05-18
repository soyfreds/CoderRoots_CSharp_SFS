using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorGasolina : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Motor de gasolina. Acelerando.");
        }

        public override void Apagar()
        {
            Console.WriteLine("Motor de gasolina. Apagando.");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Motor de gasolina. Arrancando.");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Motor de gasolina. Cargando gasolina.");
        }
    }
}
