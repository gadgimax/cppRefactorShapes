using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    // Implementación para Triángulo Equilátero
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _lado;
        public TrianguloEquilatero(decimal lado) => _lado = lado;
        public string Nombre => "Triángulo";
        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        public decimal CalcularPerimetro() => _lado * 3;
    }
}
