using System;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Agregar un nuevo idioma implicaria crear una nueva implementacion de esta interfaz,
    /// y simplemente usar una instacia cuando se llama a 'imprimir' del 'reportBuilder'
    /// </summary>
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
