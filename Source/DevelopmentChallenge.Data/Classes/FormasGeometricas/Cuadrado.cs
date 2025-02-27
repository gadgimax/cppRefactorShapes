using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    // Implementación para Cuadrado
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;
        public Cuadrado(decimal lado) => _lado = lado;
        public string Nombre => "Cuadrado";
        public decimal CalcularArea() => _lado * _lado;
        public decimal CalcularPerimetro() => _lado * 4;
    }
}
