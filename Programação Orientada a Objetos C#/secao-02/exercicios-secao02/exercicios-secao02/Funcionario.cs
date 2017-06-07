using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios_secao02
{
    class Funcionario
    {
        public String nome;
        public Double salarioBruto, desconto, salarioLiquido;

        public double SalarioLiquido()
        {
            salarioLiquido = salarioBruto - desconto;
            return salarioLiquido;
        }

        public double AumentoSalario(Double porcentagem)
        {
            double resultado = salarioLiquido + ((salarioLiquido / 100) * porcentagem);
            salarioLiquido = resultado;
            return resultado;
        }
    }
}