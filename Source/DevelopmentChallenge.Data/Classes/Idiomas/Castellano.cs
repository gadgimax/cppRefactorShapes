using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Castellano : IIdioma
    {
        public string Header => "Reporte de Formas";
        public string Empty => "Lista vacía de formas!";
        public string Total => "TOTAL";
        public string Shapes => "formas";
        public string Perimeter => "Perímetro";
        public string Area => "Área";
        public CultureInfo Cultura => new CultureInfo("es-AR");

        private static readonly Dictionary<string, string> Formas = new Dictionary<string, string>
        {
            { nameof(Cuadrado), "Cuadrado" },
            { nameof(Circulo), "Círculo" },
            { nameof(TrianguloEquilatero), "Triángulo" },
            { nameof(Trapecio), "Trapecio" }
        };

        public string TraducirForma(Type tipo, int cantidad)
        {
            string nombre = Formas.ContainsKey(tipo.Name) ? Formas[tipo.Name] : tipo.Name;
            return cantidad == 1 ? nombre : nombre + "s";
        }
    }
}
