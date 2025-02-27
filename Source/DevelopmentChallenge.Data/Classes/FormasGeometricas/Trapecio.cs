namespace DevelopmentChallenge.Data.Classes
{
    // Implementación para Trapecio
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMayor, _baseMenor, _altura, _lado1, _lado2;
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _lado1 = lado1;
            _lado2 = lado2;
        }
        public decimal CalcularArea() => ((_baseMayor + _baseMenor) / 2) * _altura;
        public decimal CalcularPerimetro() => _baseMayor + _baseMenor + _lado1 + _lado2;
    }
}
