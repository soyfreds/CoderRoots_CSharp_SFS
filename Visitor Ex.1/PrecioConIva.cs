using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class PrecioConIva : IVisitor
    {
        public int CantidadIVA { get; set; }

        public PrecioConIva(int cantidadDescuento)
        {
            CantidadIVA = cantidadDescuento;
        }

        public void Visitar(Producto Visitador)
        {
            Visitador.Precio = (int)(Visitador.Precio + ((CantidadIVA * Visitador.Precio) / 100));
        }
    }

}
