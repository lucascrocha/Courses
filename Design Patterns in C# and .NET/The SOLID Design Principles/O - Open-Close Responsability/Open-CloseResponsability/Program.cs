using System;
using System.Collections.Generic;
using static System.Console;

namespace Open_CloseResponsability
{
    enum Cor
    {
        Vermelho, Verde, Azul
    }

    enum Tamanho
    {
        Pequeno, Medio, Grande, Gigante
    }

    class Produto
    {
        public string nome;
        public Cor cor;
        public Tamanho tamanho;

        public Produto(string nome, Cor cor, Tamanho tamanho)
        {
            this.nome = nome ?? throw new ArgumentNullException(paramName: nameof(nome));
            this.cor = cor;
            this.tamanho = tamanho;
        }
    }

    interface ISpecification<T>
    {
        bool IsSatified(T t);
    }

    interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    class ColorSpecification : ISpecification<Produto>
    {
        private Cor cor;

        public ColorSpecification(Cor cor)
        {
            this.cor = cor;
        }

        public bool IsSatified(Produto t)
        {
            return t.cor == cor;
        }
    }

    class SizeSpecification : ISpecification<Produto>
    {
        Tamanho tamanho;

        public SizeSpecification(Tamanho tamanho)
        {
            this.tamanho = tamanho;
        }

        public bool IsSatified(Produto t)
        {
            return t.tamanho == tamanho;
        }
    }

    class AndSpecification<T> : ISpecification<T>
    {
        ISpecification<T> primeiro, segundo;

        public AndSpecification(ISpecification<T> primeiro, ISpecification<T> segundo)
        {
            this.primeiro = primeiro ?? throw new ArgumentNullException(paramName: nameof(primeiro));
            this.segundo = segundo ?? throw new ArgumentNullException(paramName: nameof(segundo));
        }

        public bool IsSatified(T t)
        {
            return primeiro.IsSatified(t) && segundo.IsSatified(t);
        }
    }

    class ProdutoFiltro
    {
        public IEnumerable<Produto> FiltrarPorTamanho(IEnumerable<Produto> produtos, Tamanho tamanho)
        {
            foreach (var produto in produtos)
            {
                if (produto.tamanho == tamanho)
                    yield return produto;
            }
        }

        public IEnumerable<Produto> FiltrarPorCor(IEnumerable<Produto> produtos, Cor cor)
        {
            foreach (var produto in produtos)
            {
                if (produto.cor == cor)
                    yield return produto;
            }
        }

        public IEnumerable<Produto> FiltrarPorCorETamanho(IEnumerable<Produto> produtos, Cor cor, Tamanho tamanho)
        {
            foreach (var produto in produtos)
            {
                if (produto.tamanho == tamanho && produto.cor == cor)
                    yield return produto;
            }
        }
    }

    class Filtro : IFilter<Produto>
    {
        public IEnumerable<Produto> Filter(IEnumerable<Produto> items, ISpecification<Produto> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatified(item))
                    yield return item;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var maca = new Produto("Maca", Cor.Verde, Tamanho.Pequeno);
            var arvore = new Produto("Arvore", Cor.Verde, Tamanho.Grande);
            var casa = new Produto("Casa", Cor.Azul, Tamanho.Grande);

            Produto[] produtos = { maca, arvore, casa };

            var pf = new ProdutoFiltro();

            WriteLine("Produtos verdes: (antigo)");
            foreach (var produto in pf.FiltrarPorCor(produtos, Cor.Verde))
            {
                WriteLine($"- {produto.nome} e verde");
            }

            var f = new Filtro();

            WriteLine("Produtos verdes: (novo)");
            foreach (var produto in f.Filter(produtos, new ColorSpecification(Cor.Verde)))
            {
                WriteLine($"- {produto.nome} e verde");
            }

            WriteLine("Produtos azuis e grandes: ");
            foreach (var produto in f.Filter(
                produtos, 
                new AndSpecification<Produto>(
                    new ColorSpecification(Cor.Azul), 
                    new SizeSpecification(Tamanho.Grande))))
            {
                WriteLine($"- {produto.nome} e azul e grande");
            }

            ReadKey();
        }
    }
}