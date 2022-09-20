using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder
{
    public class PalmitosBuilder : PizzaBuilder
    {
        public PalmitosBuilder(string tamaño)
        {
            _pizza = new Pizza {Tamaño = tamaño};
        }
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Cocido";
            Console.WriteLine("Se prepara la masa");
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Dulce";
            Console.WriteLine("Se añade la salsa");
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "Queso, palmitos, salsa golf";
            Console.WriteLine("Se añade el relleno");
        }
    }
}
