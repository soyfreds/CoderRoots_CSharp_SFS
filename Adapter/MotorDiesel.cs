using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Motor de diesel. Acelerando.");
        }

        public override void Apagar()
        {
            Console.WriteLine("Motor de diesel. Apagando.");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Motor de diesel. Arrancando.");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Motor de diesel. Cargando diesel.");
        }
    }
}
