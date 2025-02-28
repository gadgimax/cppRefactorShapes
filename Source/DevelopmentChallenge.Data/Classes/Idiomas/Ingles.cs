using System;
using System.Collections.Generic;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : IIdioma
    {
        private readonly IShapeTranslator _translator;

        public Ingles(IShapeTranslator translator)
        {
            _translator = translator;
        }

        public string Header => "Shapes report";
        public string Empty => "Empty list of shapes!";
        public string Total => "TOTAL";
        public string Shape => "shapes";
        public string Perimeter => "Perimeter";
        public string Area => "Area";
        public CultureInfo Cultura => new CultureInfo("en-US");

        public string TraducirFormaSingularPlural(Type tipo, int cantidad)
        {
            string nombre = _translator.GetShapeName(tipo);

            if (cantidad == 1)
                return nombre;

            return cantidad == 1 ? nombre : nombre + "s";
        }
    }
}
