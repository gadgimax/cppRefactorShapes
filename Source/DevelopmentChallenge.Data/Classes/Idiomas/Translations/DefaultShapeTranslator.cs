using DevelopmentChallenge.Data.Classes;
using System;
using System.Collections.Generic;

/// <summary>
/// Cualquier adicion relacionada a nuevas formas o lenguages deberia
/// ser centralizada en esta clase. Idealmente esto podria venir de una DB.
/// </summary>
public class DefaultShapeTranslator : IShapeTranslator
{
    private readonly Dictionary<string, Dictionary<string, string>> _translations;

    public DefaultShapeTranslator(string language)
    {
        _translations = new Dictionary<string, Dictionary<string, string>>
        {
            { "en", new Dictionary<string, string>
                {
                    { nameof(Cuadrado), "Square" },
                    { nameof(Circulo), "Circle" },
                    { nameof(TrianguloEquilatero), "Triangle" },
                    { nameof(Trapecio), "Trapezoid" }
                }
            },
            { "it", new Dictionary<string, string>
                {
                    { nameof(Cuadrado), "Quadrato" },
                    { nameof(Circulo), "Cerchio" },
                    { nameof(TrianguloEquilatero), "Triangolo" },
                    { nameof(Trapecio), "Trapezio" }
                }
            },
            { "es", new Dictionary<string, string>
                {
                    { nameof(Cuadrado), "Cuadrado" },
                    { nameof(Circulo), "Círculo" },
                    { nameof(TrianguloEquilatero), "Triángulo" },
                    { nameof(Trapecio), "Trapecio" }
                }
            }
        };

        _language = language;
    }

    private readonly string _language;

    public string GetShapeName(Type tipo)
    {
        return _translations.ContainsKey(_language) && _translations[_language].ContainsKey(tipo.Name)
            ? _translations[_language][tipo.Name]
            : tipo.Name;
    }
}
