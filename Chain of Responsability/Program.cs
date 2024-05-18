using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Resposability
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra Compra1 = new Compra();
            Compra1.MontoCompra = 400;
            var empleado1 = new Empleado();
            var empleado2 = new GerenteDepartamento();
            var empleado3 = new GerenteGeneral();
            empleado1.SiguienteNivel(empleado2);
            empleado2.SiguienteNivel(empleado3);

            empleado1.AprobarCompra(Compra1);
        }
    }
}
