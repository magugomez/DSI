using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder
{
    public class Pizza
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }   
        public string Relleno { get; set; }
        public string Tamaño { get; set; }
        public Pizza(){}
        public Pizza(string tamaño, string masa, string salsa, string relleno) : this()
        {
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
            Tamaño = tamaño;
        }
    }
}
