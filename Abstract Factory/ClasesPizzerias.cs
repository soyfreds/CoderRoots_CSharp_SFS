using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class ClasesPizzerias
    {
    }

    abstract class Pizzeria
    {
        //Atributos con get y set de una
        public string Locacion { get; set; }

        protected Pizzeria(string locacion)
        {
            Locacion = locacion;
        }

        public abstract void Vender(string LocacionPizzeria);

    }

    class Pizza : Pizzeria
    {
        public string TipoPizza { get; set; }

        public Pizza(string locacion, string pizza) : base(locacion)
        {
            TipoPizza = pizza;
        }
        public override void Vender(string LocacionPizzeria)
        {
            if (LocacionPizzeria == "Italiana")
            {
                Console.WriteLine("La pizzería " + this.Locacion + " vende Pizza Napolitana");
            }
            else
            {
                Console.WriteLine("La pizzería " + this.Locacion + " vende Pizza Cancha");
            }
        }
    }

    class Empanada : Pizzeria
    {

        public string Tipoempanada { get; set; }

        public Empanada(string locacion, string empanada) : base(locacion)
        {

            Tipoempanada = empanada;
        }
        public override void Vender(string LocacionPizzeria)
        {
            if(LocacionPizzeria == "Italiana")
            {
                Console.WriteLine("La pizzería " + this.Locacion + " vende Empanada: Capresse");
            }
            else
            {
                Console.WriteLine("La pizzería " + this.Locacion + " vende Empanada de Carne");
            }
            
        }
    }
}
