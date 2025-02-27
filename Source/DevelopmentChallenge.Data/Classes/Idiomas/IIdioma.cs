using System;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public interface IIdioma
    {
        string Header { get; }
        string Empty { get; }
        string Total { get; }
        string Shape { get; }
        string Perimeter { get; }
        string Area { get; }
        CultureInfo Cultura { get; }
        string TraducirFormaSingularPlural(Type tipo, int cantidad);
    }
}
