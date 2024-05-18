using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Resposability
{
    public interface IAprobador
    {
        void SiguienteNivel(IAprobador aprobador);

        void AprobarCompra(Compra compraRealizada);
    }
}
