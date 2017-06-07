using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SingleResponsibilty
{
    class Diario
    {
        private readonly List<string> entradas = new List<string>();

        private static int quantidade = 0;

        public int AddEntrada(string texto)
        {
            entradas.Add($"{++quantidade}: {texto}");
            return quantidade;
        }

        public void RemoverEntrada(int index)
        {
            entradas.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entradas);
        } 
    }

    class Persistence
    {
        public void SalvarArquivo(Diario diario, string nomeArquivo, bool overwrite = false)
        {
            if (overwrite || !File.Exists(nomeArquivo))
                File.WriteAllText(nomeArquivo, diario.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var d = new Diario();
            d.AddEntrada("Feels good man");
            d.AddEntrada("Feels very good man");
            d.AddEntrada("Feels bad man");
            Console.WriteLine(d);

            var p = new Persistence();
            var arquivoNome = @"C:\Users\TREINAMENTO\Desktop\Curso\Design Patterns in C# and .NET\SingleResponsibilty\diarioSRP.txt";

            p.SalvarArquivo(d, arquivoNome, true);

            Console.ReadKey();
        }
    }
}