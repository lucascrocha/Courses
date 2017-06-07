using System;
using System.Collections.Generic;
using System.Text;

namespace produto
{
    class Produto
    {
        public string nome { get; private set; }
        public double valor { get; private set; }
        public int quantidade { get; private set; }

        //Construtores são exemplo de sobrecarga
        public Produto(string nome, double valor, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public Produto(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public void RealizarEntrada(int quantidade)
        {
            this.quantidade = this.quantidade + quantidade;
        }

        public void RealizarSaida(int quantidade)
        {
            this.quantidade = this.quantidade - quantidade;
        }

        public double ValorTotalEstoque()
        {
            return this.valor * this.quantidade;
        }

        public void ListarEstoque()
        {
            Console.WriteLine("\nNome do produto: {0}", this.nome);
            Console.WriteLine("Valor do produto: {0}", this.valor);
            Console.WriteLine("Quantidade em estoque: {0}", this.quantidade);
            Console.WriteLine("Valor total em estoque: {0}", ValorTotalEstoque());
        }
    }
}