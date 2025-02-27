using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : IIdioma
    {
        public string Header => "Report delle Forme";
        public string Empty => "Lista vuota di forme!";
        public string Total => "TOTALE";
        public string Shapes => "forme";
        public string Perimeter => "Perimetro";
        public string Area => "Area";
        public CultureInfo Cultura => new CultureInfo("it-IT");

        private static readonly Dictionary<string, string> Formas = new Dictionary<string, string>
        {
            { nameof(Cuadrado), "Quadrato" },
            { nameof(Circulo), "Cerchio" },
            { nameof(TrianguloEquilatero), "Triangolo" },
            { nameof(Trapecio), "Trapezio" }
        };

        public string TraducirForma(Type tipo, int cantidad)
        {
            string nombre = Formas.ContainsKey(tipo.Name) ? Formas[tipo.Name] : tipo.Name;
            return cantidad == 1 ? nombre : nombre + "i";
        }
    }
}
