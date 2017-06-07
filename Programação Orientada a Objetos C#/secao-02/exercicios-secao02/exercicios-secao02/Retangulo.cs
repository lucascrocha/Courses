using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios_secao02
{
    class Retangulo
    {
        public double altura, largura;

        public double Area()
        {
            return altura * largura;
        }

        public double Perimetro()
        {
            return largura + altura + largura + altura;
        }

        public double Diagonal()
        {
            double x = 0;
            double resultado = 0;
            resultado = (largura * largura) + (altura * altura);
            x = Math.Sqrt(resultado);

            return x;
        }
    }
}