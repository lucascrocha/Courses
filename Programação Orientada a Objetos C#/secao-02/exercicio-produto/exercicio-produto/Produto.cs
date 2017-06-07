using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_produto
{
    class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;
        private List<Produto> produtos = new List<Produto>();

        public Produto(string nome = "{0}", double valor = 0, int quantidade = 1)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public double ValorTotalEstoque()
        {
            double resultado = 0;

            foreach (var produto in produtos)
            {
                resultado += produto.valor;
            }

            return resultado;
        }

        public void AdicionarProduto(List<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                this.produtos.Add(produto);
            }
        }

        public void AdicionarQuantidadeProduto(Produto produto, string produtoNome, int quantidadeProduto)
        {
            foreach (var item in produtos)
            {
                if (item.nome == produtoNome)
                {
                    item.quantidade = quantidadeProduto;
                }
            }
        }

        public void ListarProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Produto: {0}", produto.nome);
                Console.WriteLine("Quantidade do produto: {0}", produto.quantidade);
                Console.WriteLine("Valor do produto: {0}", produto.valor);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}