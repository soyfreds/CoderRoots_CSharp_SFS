using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Producto : IHospedador
    {
        //Propiedad "virtual" Permite sobreescribir(override) la variable en donde se herede
        virtual public int Precio { get; set; } = 0;

        public void AceptarVisita(IVisitor AceptarEstaVisita)
        {
            AceptarEstaVisita.Visitar(this);
        }
    }
}
