using System;

namespace area_triangulo
{
    class Triangulo
    {
        public double a, b, c;

        public double  CalcularArea()
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}