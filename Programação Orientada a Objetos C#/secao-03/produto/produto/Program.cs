using System;

namespace produto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto();
            ProdutoAula26();
            Console.ReadKey();
        }

        static void Produto()
        {
            Produto produto;

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            produto = new Produto(nome, valor, quantidade);

            produto.ListarEstoque();

            Console.Write("\nDeseja realizar entrada de quantidade? S/N: ");
            string adicionarQuantidade = Console.ReadLine();

            if (adicionarQuantidade == "S" || adicionarQuantidade == "s")
            {
                Console.Write("Digite a quantidade de entrada: ");
                int entradaQuantidade = int.Parse(Console.ReadLine());

                produto.RealizarEntrada(entradaQuantidade);
                produto.ListarEstoque();
            }

            Console.Write("\nDeseja realizar saida de quantidade? S/N: ");
            string removerQuantidade = Console.ReadLine();

            if (adicionarQuantidade == "S" || adicionarQuantidade == "s")
            {
                Console.Write("Digite a quantidade de saida: ");
                int saidaQuantidade = int.Parse(Console.ReadLine());

                produto.RealizarSaida(saidaQuantidade);
                produto.ListarEstoque();
            }
        }

        static void ProdutoAula26()
        {
            Produto[] produtos;

            int N = int.Parse(Console.ReadLine());
            produtos = new Produto[N];

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                double valor = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                produtos[i] = new Produto(nome, valor, quantidade);

                produtos[i].ListarEstoque();
            }
        }
    }
}