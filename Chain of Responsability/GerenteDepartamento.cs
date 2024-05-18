using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Resposability
{
    public class GerenteDepartamento : IAprobador
    {
        protected IAprobador apro;
        public void SiguienteNivel(IAprobador aprobador)
        {
            apro = aprobador;
        }

        public void AprobarCompra(Compra compraRealizada)
        {
            if (compraRealizada.MontoCompra < 200)
            {
                Console.WriteLine("La compra fue aprobada por {0}", this.GetType().Name);
            }
            else
            {
                apro.AprobarCompra(compraRealizada);
            }
        }

    }
}
