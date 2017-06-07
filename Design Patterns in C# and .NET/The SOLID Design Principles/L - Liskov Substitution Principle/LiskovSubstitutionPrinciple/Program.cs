using System;

namespace LiskovSubstitutionPrinciple
{
    class Retangulo
    {
        public virtual int Altura { get; set; }
        public virtual int Largura { get; set; }

        public Retangulo()
        {

        }

        public Retangulo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public override string ToString()
        {
            return $"{nameof(Largura)}: {Largura}, {nameof(Altura)}: {Altura}";
        }
    }

    class Quadrado : Retangulo
    {
        public override int Largura
        {
            set { base.Largura = base.Altura = value; }
        }

        public override int Altura
        {
            set { base.Largura = base.Altura = value; }
        }
    }

    class Program
    {
        static public int Area(Retangulo retangulo) => retangulo.Altura * retangulo.Largura;

        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(2, 3);
            Console.WriteLine($"{retangulo} tem area de {Area(retangulo)}");

            Quadrado quadrado = new Quadrado();
            quadrado.Largura = 4;
            Console.WriteLine($"{quadrado} tem area de {Area(quadrado)}");

            Console.ReadKey();
        }
    }
}