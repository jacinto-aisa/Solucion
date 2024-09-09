using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuricas
{
    public class Circulo : IFigura
    {
        public int Radio { set; get; }
        public int X { get; set; }
        public int Y { get; set; }

        public double DamePerimetro()
        {
            return 78;
        }

        public double DameSuperficie()
        {
            return Radio * 2;
        }
    }
}