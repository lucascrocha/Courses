using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos;
            Produto produto;
            Console.Write("Digite a quantidade de produtos a serem adicionados: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            double valorTotalEstoque = 0;

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                produtos = new List<Produto>();

                int qtd = i + 1;

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Insira os dados do {0} produto", qtd);
                Console.WriteLine("---------------------------------------");

                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                double valor = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                int posicao = qtd;
                produto = new Produto(nome, valor, quantidade);
                produtos.Add(produto);
                
                produto.AdicionarProduto(produtos);

                valorTotalEstoque = produto.ValorTotalEstoque();
            }
            produto = new Produto();

            Console.WriteLine("Valor total em estoque: {0}", valorTotalEstoque);

            Console.Write("Deseja alterar o estoque de algum produto? S/N: ");
            string alterarEstoque = Console.ReadLine();

            if (alterarEstoque == "s" || alterarEstoque == "S")
            {
                Console.Write("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Digite a nova quantidade do produto {0}: ", nomeProduto);
                int quantidadeProduto = int.Parse(Console.ReadLine());

                produto.AdicionarQuantidadeProduto(produto, nomeProduto, quantidadeProduto);
            }

            produto.ListarProdutos();

            Console.ReadKey();
        }
    }
}