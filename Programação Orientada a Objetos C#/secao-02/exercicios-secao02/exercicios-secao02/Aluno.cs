using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios_secao02
{
    class Aluno
    {
        public String nome;
        public Double nota1, nota2, nota3, nota4, media;

        public double CalculoNota()
        {
            return nota1 + nota2 + nota3 + nota4;
        }

        public double CalculoMedia()
        {
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            return media;
        }
    }
}