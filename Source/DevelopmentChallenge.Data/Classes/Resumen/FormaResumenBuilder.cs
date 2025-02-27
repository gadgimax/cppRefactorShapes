using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.Data.Classes
{
    public static class FormaResumenBuilder
    {
        public static List<FormaResumen> CalcularResumen(List<IFormaGeometrica> formas)
        {
            return formas
                .GroupBy(forma => forma.GetType())
                .Select(grupo => new FormaResumen(
                    grupo.Key,
                    grupo.Count(),
                    grupo.Sum(item => item.CalcularArea()),
                    grupo.Sum(item => item.CalcularPerimetro())))
                .ToList();
        }
    }
}
