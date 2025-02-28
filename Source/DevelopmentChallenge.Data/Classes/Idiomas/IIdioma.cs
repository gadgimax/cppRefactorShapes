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

        /// <summary>
        /// La idea detras de esta funcion es mantener algo de logica 'custom' 
        /// en cada clase que representa un lenguage. En caso contrario, los diferentes
        /// lenguages podrian ser representados simplemente como datos, sin una logica asociada.
        /// </summary>
        string TraducirFormaSingularPlural(Type tipo, int cantidad);
    }
}
