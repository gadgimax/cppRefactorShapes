﻿/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReportBuilder
    {
        public static string Imprimir(List<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append("<h1>" + idioma.Empty + "</h1>");
            }
            else
            {
                // HEADER
                sb.Append("<h1>" + idioma.Header + "</h1>");

                var resumen = formas
                    .GroupBy(f => f.GetType())
                    .Select(g => new
                    {
                        Tipo = g.Key,
                        Cantidad = g.Count(),
                        AreaTotal = g.Sum(f => f.CalcularArea()),
                        PerimetroTotal = g.Sum(f => f.CalcularPerimetro())
                    });

                foreach (var item in resumen)
                    sb.Append(ObtenerLinea(item.Cantidad, item.AreaTotal, item.PerimetroTotal, item.Tipo, idioma));

                // FOOTER
                sb.Append(idioma.Total + ":<br/>");
                sb.Append($"{resumen.Sum(item => item.Cantidad)} {idioma.Shapes} ");
                sb.Append(string.Format(idioma.Cultura, "{0} {1:#.##} ", idioma.Perimeter, resumen.Sum(item => item.PerimetroTotal)));
                sb.Append(string.Format(idioma.Cultura, "{0} {1:#.##}", idioma.Area, resumen.Sum(item => item.AreaTotal)));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Type tipo, IIdioma idioma)
        {
            if (cantidad > 0)
            {
                return string.Format(idioma.Cultura,
                    "{0} {1} | {2} {3:#.##} | {4} {5:#.##} <br/>",
                    cantidad,
                    idioma.TraducirForma(tipo, cantidad),
                    idioma.Area, area,
                    idioma.Perimeter, perimetro);
            }
            return string.Empty;
        }
    }
}
