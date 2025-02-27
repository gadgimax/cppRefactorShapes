namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Agregar una nueva forma geometrica implicaria una nueva implementacion de esta interfaz,
    /// y simplemente agregar la nueva forma a la lista de formas que se usa en el 'reportBuilder'
    /// </summary>
    public interface IFormaGeometrica
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
