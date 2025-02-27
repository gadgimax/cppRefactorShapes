using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    // Implementación para Círculo
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _radio;
        public Circulo(decimal radio) => _radio = radio;
        public string Nombre => "Círculo";
        public decimal CalcularArea() => (decimal)Math.PI * (_radio / 2) * (_radio / 2);
        public decimal CalcularPerimetro() => (decimal)Math.PI * _radio;
    }
}
