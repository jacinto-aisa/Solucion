using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuricas
{
    public class TableroDeDibujo : ITableroDeDibujo
    {
        readonly List<IFigura> figuricas = new(1000);
        public void Add(IFigura figura)
        {
            figuricas.Add(figura);
        }
        public double SuperficieTotal()
        {
            double total = 0;
            foreach (var item in figuricas)
            {
                total += item.DameSuperficie();
            }
            return total;
        }
        public int DameNumeroCuadrados()
        {
            int numeroCuadrados = 0;    
            foreach(var item in figuricas)
            {
                if(item is Cuadrado)
                {
                    numeroCuadrados++;
                }
            }
            return numeroCuadrados;
        }

        public double Mezcla()
        {
            double valor = 0;
            foreach (var item in figuricas)
            {
                if(item is Triangulo triangulo)
                {
                    valor += triangulo.DamePI();
                }
            }
            return valor;
        }

    }
}