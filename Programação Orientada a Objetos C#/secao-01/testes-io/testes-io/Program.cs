using System;
using System.Globalization;

namespace testes_io
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine() -> quebra a linha automaticamente no final da saída.
            // Console.Write() -> não quebra a linha no final da saída

            Console.WriteLine("Olá mundo!");
            Console.WriteLine("Bom dia");

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é: " + x + " reais");
            Console.WriteLine("O valor do troco é: " + x.ToString("f2") + " reais");
            Console.WriteLine();

            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();
        }
    }
}