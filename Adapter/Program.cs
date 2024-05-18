using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			Motor motor1 = new MotorGasolina();
			motor1.Arrancar();
			motor1.Acelerar();
			motor1.Apagar();
			motor1.CargarCombustible();

			Console.WriteLine("\n##################\n");

			Motor motor2 = new MotorDiesel();
			motor2.Arrancar();
			motor2.Acelerar();
			motor2.Apagar();
			motor2.CargarCombustible();

			Console.WriteLine("\n##################\n");

			Motor motorElectric = new MotorElectricoAdapter();
			motorElectric.CargarCombustible();
			motorElectric.Arrancar();
			motorElectric.Acelerar();
			motorElectric.Apagar();

			Console.ReadLine();
		}
	}
}
