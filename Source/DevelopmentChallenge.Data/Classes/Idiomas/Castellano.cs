using System;
using System.Collections.Generic;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public class Castellano : IIdioma
    {
        public string Header => "Reporte de Formas";
        public string Empty => "Lista vacía de formas!";
        public string Total => "TOTAL";
        public string Shape => "formas";
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

        public string TraducirFormaSingularPlural(Type tipo, int cantidad)
        {
            string nombre = Formas.ContainsKey(tipo.Name) ? Formas[tipo.Name] : tipo.Name;
            return cantidad == 1 ? nombre : nombre + "s";
        }
    }
}
