using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;
        public string Tamaño { get; set; }
        public Pizza ObtenerPizza() {
            Console.WriteLine("La pizza esta lista!");
            return _pizza; 
        }
        public virtual void PasoPrepararMasa() { }
        public virtual void PasoAñadirSalsa() { }
        public virtual void PasoPrepararRelleno() { }
    }
}
