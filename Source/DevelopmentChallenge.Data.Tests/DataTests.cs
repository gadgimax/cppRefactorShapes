using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            ClassicAssert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(new List<IFormaGeometrica>()), new Castellano(new DefaultShapeTranslator("es"))));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            ClassicAssert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(new List<IFormaGeometrica>()), new Ingles(new DefaultShapeTranslator("en"))));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            ClassicAssert.AreEqual("<h1>Lista vuota di forme!</h1>",
                ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(new List<IFormaGeometrica>()), new Italiano(new DefaultShapeTranslator("it"))));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(cuadrados), new Castellano(new DefaultShapeTranslator("es")));

            ClassicAssert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulos = new List<IFormaGeometrica> { new Circulo(5) };

            var resumen = ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(circulos), new Castellano(new DefaultShapeTranslator("es")));

            ClassicAssert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Área 78,54 | Perímetro 31,42 <br/>TOTAL:<br/>1 formas Perímetro 31,42 Área 78,54", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecio = new List<IFormaGeometrica> { new Trapecio(4, 2, 3, 3.5m, 3.5m) };

            var resumen = ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(trapecio), new Castellano(new DefaultShapeTranslator("es")));

            ClassicAssert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Área 9 | Perímetro 13 <br/>TOTAL:<br/>1 formas Perímetro 13 Área 9", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(cuadrados), new Ingles(new DefaultShapeTranslator("en")));

            ClassicAssert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(formas), new Ingles(new DefaultShapeTranslator("en")));

            ClassicAssert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 52.03 | Perimeter 36.13 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 115.73 Area 130.67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado( 5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(formas), new Castellano(new DefaultShapeTranslator("es")));

            ClassicAssert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 52,03 | Perímetro 36,13 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 115,73 Área 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado( 5),
                new Circulo(3),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Trapecio(4,2,3,3.5m,3.5m)
            };

            var resumen = ReportBuilder.Imprimir(FormaResumenBuilder.CalcularResumen(formas), new Italiano(new DefaultShapeTranslator("it")));

            ClassicAssert.AreEqual(
                "<h1>Report delle Forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>2 Cerchi | Area 56,55 | Perimetro 37,7 <br/>1 Triangolo | Area 6,93 | Perimetro 12 <br/>1 Trapezio | Area 9 | Perimetro 13 <br/>TOTALE:<br/>5 forme Perimetro 82,7 Area 97,48",
                resumen);
        }
    }
}
