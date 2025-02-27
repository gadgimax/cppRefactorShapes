using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaResumen
    {
        public Type Tipo { get; }
        public int Cantidad { get; }
        public decimal AreaTotal { get; }
        public decimal PerimetroTotal { get; }

        public FormaResumen(Type tipo, int cantidad, decimal areaTotal, decimal perimetroTotal)
        {
            Tipo = tipo;
            Cantidad = cantidad;
            AreaTotal = areaTotal;
            PerimetroTotal = perimetroTotal;
        }
    }

}
