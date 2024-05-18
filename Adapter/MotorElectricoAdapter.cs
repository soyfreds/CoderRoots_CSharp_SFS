using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Este es el vehiculo electrico, usamos el padre "Motor" y sus metodos, pero lo que metemos dentro de sus metodos
    //es el metodo de el vehiculo electrico. Por ejemplo el motor se enciende es algo general para todo, pero el motro
    //se enciende de manera diferente para un motor electrico y uno de gasolina

    public class MotorElectricoAdapter : Motor
    {
        //Se crea un objeto del lugar donde nostraemos los metodos
        MotorElectrico motorElec = new MotorElectrico();

        public override void Acelerar()
        {
            motorElec.Avanzar();
        }

        public override void Apagar()
        {
            motorElec.Desactivar();
        }

        public override void Arrancar()
        {
            motorElec.Encender();
        }

        public override void CargarCombustible()
        {
            motorElec.RecargarBateria();
        }
    }
}
