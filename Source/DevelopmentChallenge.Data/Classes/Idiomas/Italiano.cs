using System;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : IIdioma
    {
        private readonly IShapeTranslator _translator;

        public Italiano(IShapeTranslator translator)
        {
            _translator = translator;
        }

        public string Header => "Report delle Forme";
        public string Empty => "Lista vuota di forme!";
        public string Total => "TOTALE";
        public string Shape => "forme";
        public string Perimeter => "Perimetro";
        public string Area => "Area";
        public CultureInfo Cultura => new CultureInfo("it-IT");

        public string TraducirFormaSingularPlural(Type tipo, int cantidad)
        {
            string nombre = _translator.GetShapeName(tipo);

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
