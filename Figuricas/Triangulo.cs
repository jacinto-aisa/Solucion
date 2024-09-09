using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuricas
{
    public class Triangulo (int Lado1, int Lado2, int Lado3) : IFigura
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double DamePerimetro()
        {
            return Lado1 * Lado2 + Lado3;
        }

        public double DameSuperficie()
        {
            return Lado2 * 6;
        }

        public double DamePI()
        {
            return Math.PI * Lado1;
        }
    }
}