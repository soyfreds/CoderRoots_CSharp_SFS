using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Resposability
{
    public class Empleado : IAprobador
    {
        //apro vendria a ser el objeto siguiente
        protected IAprobador apro;

        //Esta función setea al objeto siguiente en jerarquía
        public void SiguienteNivel(IAprobador aprobador)
        {
            apro = aprobador;
        }

        //Esta función hace lo que el programa necesita pero comprueba que este objeto lo pueda hacer.
        public void AprobarCompra(Compra compraRealizada)
        {
            if (compraRealizada.MontoCompra < 100)
            {
                Console.WriteLine("La compra fue aprobada por {0}", this.GetType().Name);
            }
            else
            {
                //si el objeto llamdo no puede entonces apro (el objeto siguiente) va a ejecutar, lo mismo pasa con el siguiente.
                apro.AprobarCompra(compraRealizada);
            }
        }

    }
}
