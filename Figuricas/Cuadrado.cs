using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuricas
{
    public class Cuadrado(int Lado) : IFigura
    {
        public required int X { get; set; }
        public int Y { get; set; }

        public double DamePerimetro()
        {
            return Lado * 4;
        }

        public double DameSuperficie()
        {
            return Lado * Lado;
        }
    }
}