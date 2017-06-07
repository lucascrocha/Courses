using System;

namespace aula_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            double soma = 0, media = 0;

            int N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet.Length; i++)
            {
                soma = soma + vet[i];
            }

            media = soma / vet.Length;

            Console.WriteLine(media);

            Console.ReadKey();
        }
    }
}