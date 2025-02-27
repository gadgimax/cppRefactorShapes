using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : IIdioma
    {
        public string Header => "Shapes report";
        public string Empty => "Empty list of shapes!";
        public string Total => "TOTAL";
        public string Shapes => "shapes";
        public string Perimeter => "Perimeter";
        public string Area => "Area";
        public CultureInfo Cultura => new CultureInfo("en-US");

        private static readonly Dictionary<string, string> Formas = new Dictionary<string, string>
        {
            { nameof(Cuadrado), "Square" },
            { nameof(Circulo), "Circle" },
            { nameof(TrianguloEquilatero), "Triangle" },
            { nameof(Trapecio), "Trapezoid" }
        };

        public string TraducirForma(Type tipo, int cantidad)
        {
            string nombre = Formas.ContainsKey(tipo.Name) ? Formas[tipo.Name] : tipo.Name;
            return cantidad == 1 ? nombre : nombre + "s";
        }
    }
}
