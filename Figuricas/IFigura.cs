using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuricas
{
    public interface IFigura
    {
        int X { get; set; }
        int Y { get; set; }

        double DameSuperficie();
        double DamePerimetro();
    }
}