using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public interface IIdioma
    {
        string Header { get; }
        string Empty { get; }
        string Total { get; }
        string Shapes { get; }
        string Perimeter { get; }
        string Area { get; }
        CultureInfo Cultura { get; }
        string TraducirForma(Type tipo, int cantidad);
    }
}
