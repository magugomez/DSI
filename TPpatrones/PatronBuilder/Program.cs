using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cocina = new Cocina();

            Console.WriteLine("\n1_ Un cliente pide una Pizza de palmitos familiar");
            cocina.RecepcionarProximaPizza(new PalmitosBuilder("Familiar"));
            cocina.CocinarPizzaPasoAPaso();
            var pizzaPalmitos = cocina.PizzaPreparada;

            Console.WriteLine("\n2_ Otro cliente pide una especial mediana");
            cocina.RecepcionarProximaPizza(new EspecialBuilder("Mediana"));
            cocina.CocinarPizzaPasoAPaso();
            var pizzaEspecial = cocina.PizzaPreparada;

            Console.WriteLine("\n3_ Pizza personalizada con fluent builder");
            var pizzaPersonalizada = PizzaFluentBuilder.Crear()
                                       .ConMasaSuave()
                                       .ConSalsaRoquefort()
                                       .AñadirMozzarela()
                                       .AñadirParmesano()
                                       .Cocinar();
        }   
    }
}
