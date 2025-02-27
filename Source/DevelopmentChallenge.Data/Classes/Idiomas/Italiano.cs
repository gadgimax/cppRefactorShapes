using System;
using System.Collections.Generic;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : IIdioma
    {
        public string Header => "Report delle Forme";
        public string Empty => "Lista vuota di forme!";
        public string Total => "TOTALE";
        public string Shape => "forme";
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

        public string TraducirFormaSingularPlural(Type tipo, int cantidad)
        {
            string nombre = Formas.ContainsKey(tipo.Name) ? Formas[tipo.Name] : tipo.Name;

            if (cantidad == 1)
                return nombre;

            if (nombre.EndsWith("io"))
                return nombre.Substring(0, nombre.Length - 1); // Remove last 'o'

            if (nombre.EndsWith("o"))
                return nombre.Substring(0, nombre.Length - 1) + "i"; // Replace 'o' with 'i'

            return nombre;
        }
    }
}
