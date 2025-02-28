using System;
using System.Collections.Generic;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public class Castellano : IIdioma
    {
        private readonly IShapeTranslator _translator;

        public Castellano(IShapeTranslator translator)
        {
            _translator = translator;
        }

        public string Header => "Reporte de Formas";
        public string Empty => "Lista vacía de formas!";
        public string Total => "TOTAL";
        public string Shape => "formas";
        public string Perimeter => "Perímetro";
        public string Area => "Área";
        public CultureInfo Cultura => new CultureInfo("es-AR");

        public string TraducirFormaSingularPlural(Type tipo, int cantidad)
        {
            string nombre = _translator.GetShapeName(tipo);

            if (cantidad == 1)
                return nombre;

            return cantidad == 1 ? nombre : nombre + "s";
        }
    }
}
