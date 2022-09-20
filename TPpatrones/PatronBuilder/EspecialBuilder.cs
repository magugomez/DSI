using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder
{
    internal class EspecialBuilder : PizzaBuilder
    {
        public EspecialBuilder(string tamaño)
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
            Console.WriteLine("Se añade la masa");
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "Queso, jamón, morron, aceitunas";
            Console.WriteLine("Se añade el relleno");
        }
    }
}
