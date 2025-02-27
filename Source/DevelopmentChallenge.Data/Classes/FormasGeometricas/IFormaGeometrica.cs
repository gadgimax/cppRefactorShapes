using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    // Interfaz base que define el comportamiento común de todas las formas geométricas.
    public interface IFormaGeometrica
    {
        string Nombre { get; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
