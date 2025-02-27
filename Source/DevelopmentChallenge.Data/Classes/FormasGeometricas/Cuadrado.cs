namespace DevelopmentChallenge.Data.Classes
{
    // Implementación para Cuadrado
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;
        public Cuadrado(decimal lado) => _lado = lado;
        public decimal CalcularArea() => _lado * _lado;
        public decimal CalcularPerimetro() => _lado * 4;
    }
}
