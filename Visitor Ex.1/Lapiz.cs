using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Lapiz : Producto
    {
        override public int Precio { get; set; } = 10;
    }

}
