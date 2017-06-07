using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicios_secao01
{
    class Program
    {
        static void Main(string[] args)
        {
//            Exercicio01();
//            Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
//            Exercicio06();
 //           Exercicio07();
            Exercicio08();
            //Exercicio09();

            Console.ReadKey();
        }

        static void Exercicio01()
        {
            #region Enunciado
            /*
              Um agricultor precisa aplicar veneno em suas plantacões. Para isso ele precisa escolher um frasco e uma bomba para             
              aplicacão.O frasco de veneno possui um volume de veneno líquido medido em ml(mililitro).Já a bomba de aplicacão
              possui uma vazão* medida em ml/ s(mililitro por segundo).O agricultor deseja saber: dado o volume inicial de um frasco
              de veneno(em ml), a vazão da bomba(em ml/ s), e um tempo(em s), qual volume de veneno restará no frasco após o uso
              da bomba durante este tempo?
              * Vazão, neste contexto, significa o quanto a bomba consegue bombear em um certo intervalo de tempo.
              Entrada:
              A entrada possui três numeros inteiros representando respectivamente: o volume inicial de um frasco de veneno(em ml),
              a vazão da bomba(em ml/ s), e um tempo(em s).
              Saída:
              A saída contem um numero inteiro representando o volume de veneno(em ml) restante no frasco depois o uso da bomba
              durante o tempo informado. Se o volume do frasco não for suficiente, mostre a mensagem "nao eh possivel"
              */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 01 --------------------------");

            Console.Write("Digite o volume do frasco de veneno: ");
            int volumeVeneno = int.Parse(Console.ReadLine());

            if (volumeVeneno <= 0)
            {
                Console.WriteLine("Valor invalido, digite um numero maior que zero");
                volumeVeneno = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o tempo de uso: ");
            int tempoUso = int.Parse(Console.ReadLine());

            if (tempoUso <= 0)
            {
                Console.WriteLine("Valor invalido, digite um numero maior que zero");
                tempoUso = int.Parse(Console.ReadLine());
            }

            int vazao = volumeVeneno / tempoUso;

            int volumeRestante = volumeVeneno - vazao;

            if (volumeRestante < 1)
                Console.WriteLine("Nao e possivel, volume restante e menor que 0");
            else
                Console.WriteLine(volumeRestante);

            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Exercicio02()
        {
            #region Enunciado
            /*
             * Deseja - se fazer um programa para calcular a nota final de um estudante, considerando as três notas que ele tirou nos
               três trimestres de seu curso. Caso a nota final do estudante seja menor que 60.00, deve - se mostrar uma mensagem
               "DEPENDENCIA" tambem.
               Entrada:
               A entrada possui as três notas do estudante, com duas casas decimais.
               Saída:
               A saída possui a nota final do estudante com duas casas decimais. Caso a nota seja menor que 60.00, a saída tambem
               possui a mensagem "DEPENDENCIA"
            */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 02 --------------------------");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media < 6)
                Console.WriteLine("Dependencia");
            else
                Console.WriteLine("Aprovado, media: {0}", media);

            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Exercicio03()
        {
            #region Enunciado
            /*
             Dadas as dimensões de uma foto e de um porta retrato, você deve verificar se uma foto cabe em um porta retrato. Você
             pode girar a foto 90° para adequá-la à dimensão do porta retrato.
             Entrada:
             A primeira linha da entrada contem a largura e altura da foto, e a segunda linha contem a largura e altura do porta retrato.
             Saída:
             A saída contem a palavra "SIM" se a foto couber no porta retrato, ou a palavra "NAO" caso contrário.
             */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 03 --------------------------");

            Console.Write("Digite a largura da foto: ");
            int larguraFoto = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura da foto: ");
            int alturaFoto = int.Parse(Console.ReadLine());

            Console.Write("Digite a largura do porta retrato: ");
            int larguraPortaRetrato = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do porta retrato: ");
            int alturaPortaRetrato = int.Parse(Console.ReadLine());

            if (larguraFoto > larguraPortaRetrato)
                Console.WriteLine("Nao e possivel utilizar este porta retrato, largura da foto e maior que do porta retrato.");
            else if (alturaFoto > alturaPortaRetrato)
                Console.WriteLine("Nao e possivel utilizar este porta retrato, altura da foto e maior que do porta retrato.");
            else
                Console.WriteLine("E possivel utilizar este porta retrato");

            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Exercicio04()
        {
            #region Enunciado
            /*
             Fazer um programa para ler a quantidade de glicose no sangue
             de uma pessoa e depois mostrar na tela a classificacão desta
             glicose de acordo com a tabela de referência ao lado.
             Classificacão Glicose
             Normal Ate 100 mg/dl
             Elevado Maior que 100 ate 140 mg/dl
             Diabetes Maior de 140 mg/dl
             Entrada
             A entrada contem o valor de glicose com uma casa decimal.
             Saída
             A saída contem a classificacão da glicose.
             */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 04 --------------------------");

            Console.Write("Digite a glicose: ");
            int quantidadeGlicose = int.Parse(Console.ReadLine());

            if (quantidadeGlicose < 100)
                Console.WriteLine("Normal");
            else if (quantidadeGlicose > 100 && quantidadeGlicose < 140)
                Console.WriteLine("Elevado");
            else
                Console.WriteLine("Diabetes");

            Console.WriteLine("------------------- ------------------------------------------------");
        }

        static void Exercicio05()
        {
            #region Enunciado
            /*
             No arremesso de dardo, o atleta tem três chances para lancar o dardo à maior distância que conseguir. Você deve criar             
             um programa para, dadas as medidas das três tentativas de lancamento, informar qual foi a maior.
             Entrada
             A entrada contem os valores das medidas em metros das três distâncias às quais o dardo foi arremessado, com duas casas
             decimais.
             Saída
             A saída contem a maior das distâncias, com duas casas decimais.
             */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 05 --------------------------");

            Console.Write("Digite o valor do primeiro lancamento: ");
            double primeiroLancamento = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lancamento: ");
            double segundoLancamento = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lancamento: ");
            double terceiroLancamento = double.Parse(Console.ReadLine());

            if (primeiroLancamento > segundoLancamento && primeiroLancamento > terceiroLancamento)
                Console.WriteLine("Primeiro lancamento foi o maior, valor: {0}", primeiroLancamento);
            else if (segundoLancamento > primeiroLancamento && segundoLancamento > terceiroLancamento)
                Console.WriteLine("Segundo lancamento foi o maior, valor: {0}", segundoLancamento);
            else
                Console.WriteLine("Terceiro lancamento foi o maior, valor: {0}", terceiroLancamento);

            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Exercicio06()
        {
            #region Enunciado
            /*
             Fazer um programa para ler dois numeros inteiros e mostrar a soma de todos os numeros ímpares entre eles, inclusive
             eles próprios.
             Entrada:
             A entrada consiste de dois numeros inteiros, sendo o primeiro menor ou igual ao segundo (ou seja: não precisa se
             preocupar em verificar qual dos dois numeros é o menor ou o maior).
             Saída:
             A saída consiste de um numero inteiro representando a soma.
             */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 06 --------------------------");

            Console.Write("Digite o primeiro numero: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            int maiorNumero = 0;

            if (primeiroNumero > segundoNumero)
                maiorNumero = primeiroNumero;
            else
                maiorNumero = segundoNumero;

            List<int> listaPrimeiroNumero = new List<int>();
            List<int> listaSegundoNumero = new List<int>();

            for (int i = 1; i < maiorNumero; i++)
            {
                if (primeiroNumero == i)
                    listaPrimeiroNumero.Add(primeiroNumero + i);
                else if (segundoNumero == i)
                    listaSegundoNumero.Add(segundoNumero + i);

                i = i + 1;
            }

            int resultado = 0;

            foreach (int primeiro in listaPrimeiroNumero)
            {
                foreach (int segundo in listaSegundoNumero)
                {
                    if (primeiro != 0 && segundo != 0)
                        resultado += (primeiro + segundo);
                    else if (primeiro > 0 && segundo == 0)
                        resultado += primeiro;
                    else if (segundo > 0 && primeiro == 0)
                        resultado += segundo;
                }
            }

            Console.WriteLine(resultado);

            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Exercicio07()
        {
            #region Enunciado
            /*
            Leia numeros inteiros até que um 0 (zero) seja lido. Para cada valor lido, o programa deve mostrar o quadrado do
            valor.
            Lembrete: você não precisa ler todos dados para só depois começar a mostrar a saída. Você pode ir lendo um numero e
            mostrando a saída referente a ele, um de cada vez.
            Entrada:
            Cada linha contém um numero inteiro.
            Saída:
            Cada linha contém um numero inteiro correspondente ao quadrado do numero lido. Não se deve mostrar o quadrado para
            o numero 0.
             */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 07 --------------------------");
            List<int> numeros = new List<int>();
            List<int> resultados = new List<int>();

            while (!numeros.Any(e => e == 0))
            {
                Console.Write("Digite o numero: ");
                numeros.Add(int.Parse(Console.ReadLine()));

                if (numeros.Any(e => e == 0))
                    continue;
            }

            foreach (var numero in numeros)
            {
                if (numero != 0)
                    resultados.Add(numero * numero);
            }

            foreach (var resultado in resultados)
            {
                Console.WriteLine("Resultado: " + resultado);
            }

            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Exercicio08()
        {
            #region Enunciado
            /*
              Leia três valores inteiros N, A e B. Em seguida, mostrar todos os múltiplos de N contidos no intervalo A e B (inclusive
              os próprios valores A e B).
              Entrada:
              A entrada é composta de três números inteiros N, A e B, respectivamente, sendo A < B (não precisa se preocupar em
              verificar se A é menor que B).
              Saída:
              A saída contém os múltiplos de N entre A e B, sendo um valor por linha. Se não houver nenhum, não se deve imprimir
              nada.
             */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 08 --------------------------");

            Console.Write("Digite o primeiro valor: ");
            int primeiroValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int segundoValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int terceiroValor = int.Parse(Console.ReadLine());

            int resultado = 0;

            while(resultado < terceiroValor)
            {
                resultado += primeiroValor;
                Console.WriteLine(resultado);
            }

            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Exercicio09()
        {
            #region Enunciado
            /*
             Alexandre está se mordendo de vontade de jogar muito vídeo game depois das provas finais do primeiro trimestre.
             Entretanto, ele quer se prevenir de ficar sem bateria para o controle do vídeo game. Para isso, ele deseja se planejar,
             recarregando completamente a bateria do controle do vídeo game, e fazendo um acompanhamento de tempo a cada vez 
             que for jogar. Assim, ele deseja informar quantas vezes pretende jogar, e quanto tempo vai jogar em cada vez. Você deve
             construir um programa que informa o tempo restante de cada vez que ele for jogar.
             Entrada:
             A entrada consiste do tempo total de duração da bateria completamente recarregada (em horas - ponto flutuante com uma
             casa decimal), seguido de um número inteiro N indicando quantas vezes Alexandre pretende jogar, seguido dos tempos
             que ele vai jogar em cada vez (em horas - ponto flutuante com uma casa decimal).
             Saída:
             A saída é composta do tempo restante de duração da bateria a cada vez que Alexandre for jogar (em horas - ponto
             flutuante com uma casa decimal). Se o tempo restante da bateria não for suficiente para uma determinada vez que
             Alexandre for jogar, mostrar a palavra "recarregar".
             */
            #endregion

            Console.WriteLine("-------------------------- Exercicio 09 --------------------------");
            
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}