using System;
using System.Collections.Generic;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : IIdioma
    {
        public string Header => "Shapes report";
        public string Empty => "Empty list of shapes!";
        public string Total => "TOTAL";
        public string Shape => "shapes";
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

        public string TraducirFormaSingularPlural(Type tipo, int cantidad)
        {
            string nombre = Formas.ContainsKey(tipo.Name) ? Formas[tipo.Name] : tipo.Name;
            return cantidad == 1 ? nombre : nombre + "s";
        }
    }
}
