using System;

namespace exercicios_secao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio01();
            Exercicio02();
            Exercicio03();

            Console.ReadKey();
        }

        static void Exercicio01()
        {
            Console.WriteLine("----------------------------- Exercicio 01 -----------------------------");
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite a altura: ");
            retangulo.altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a largura: ");
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nArea do retangulo: {0}", retangulo.Area());
            Console.WriteLine("Perimetro do retangulo: {0}", retangulo.Perimetro());
            Console.WriteLine("Diagonal do retangulo: {0}", retangulo.Diagonal());

            Console.WriteLine("------------------------------------------------------------------------");
        }

        static void Exercicio02()
        {
            Console.WriteLine("----------------------------- Exercicio 02 -----------------------------");
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite o nome do funcionario: ");
            funcionario.nome = Console.ReadLine();

            Console.Write("Digite o salario bruto do funcionario: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o desconto do salario do funcionario: ");
            funcionario.desconto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSalario liquido de {0}: {1}", funcionario.nome, funcionario.SalarioLiquido());
            Console.Write("\nDigite a porcentagem de aumento do salario do funcionario: ");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario.AumentoSalario(porcentagem);

            Console.WriteLine("\nNovo salario de {0}: {1}", funcionario.nome, funcionario.salarioLiquido);


            Console.WriteLine("------------------------------------------------------------------------");
        }

        static void Exercicio03()
        {
            Console.WriteLine("----------------------------- Exercicio 03 -----------------------------");

            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.Write("Digite a primeira nota do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            aluno.nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno: ");
            aluno.nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota do aluno: ");
            aluno.nota4 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nAluno: {0}", aluno.nome);
            Console.WriteLine("Nota: {0}", aluno.CalculoNota());

            aluno.CalculoMedia();

            if (aluno.media > 60)
                Console.WriteLine("Aprovado");
            else
            {
                Console.WriteLine("Reprovado, nota restante: {0}", 60 - aluno.media);
            }

            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}