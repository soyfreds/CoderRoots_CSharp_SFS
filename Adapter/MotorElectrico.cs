using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Esta clase no hereda de "Motor" porque es electrico y no es lo mismo
    //entonces aquí crearemos los metodos que necesita el motor electrico para
    //luego pasarlos al adapter donde montamos el motor electrico sobre el padre (carcasa de Motor)
    public class MotorElectrico
    {
        private bool CargaElectrica;

        public void Encender()
        {
            if (CargaElectrica)
            {
                Console.WriteLine("Encendiendo Motor Electrico");
            }
            else
            {
                Console.WriteLine("Motor no se puede encender, no hay carga electrica.");
            }

        }

        public void Desactivar()
        {
            Console.WriteLine("Motor electrico ha sido desactivado");
        }

        public void Avanzar()
        {
            if (CargaElectrica)
            {
                Console.WriteLine("Motor electrico avanza");
            }
            else
            {
                Console.WriteLine("Motor electrico con bateria insuficiente, no puede avanzar.");
            }
        }

        public void RecargarBateria()
        {
            if (CargaElectrica)
            {
                Console.WriteLine("La bateria esta actualmente cargada");
            }
            else
            {
                CargaElectrica = true;
                Console.WriteLine("La bateria del motor electrico ha sido cargada.");
            }
        }
    }
}
