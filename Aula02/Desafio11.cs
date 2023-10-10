using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// DESAFIO 11:

// As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e
// lhe contraram para desenvolver o programa que calculará os reajustes.
// Faça um programa que recebe o salário de um colaborador e o reajuste segundo o seguinte
// critério, baseado no salário atual:
//     - salários até R$ 280,00 (incluindo) : aumento de 20%
//     - salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
//     - salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
//     - salários de R$ 1500,00 em diante : aumento de 5%

// Após o aumento ser realizado, informe na tela:
//     - o salário antes do reajuste;
//     - o percentual de aumento aplicado;
//     - o valor do aumento;
//     - o novo salário, após o aumento.


class Desafio11 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.Write("Digite o salário do colaborador: ");
            double salario = double.Parse(Console.ReadLine());

            double percentualAumento;
            double valorAumento;
            double novoSalario;

            if (salario <= 280.00)
            {
                percentualAumento = 20;
            }
            else if (salario <= 700.00)
            {
                percentualAumento = 15;
            }
            else if (salario <= 1500.00)
            {
                percentualAumento = 10;
            }
            else
            {
                percentualAumento = 5;
            }

            valorAumento = (percentualAumento / 100) * salario;
            novoSalario = salario + valorAumento;

            Console.WriteLine($"Salário antes do reajuste: R$ {salario:F2}");
            Console.WriteLine($"Percentual de aumento aplicado: {percentualAumento}%");
            Console.WriteLine($"Valor do aumento: R$ {valorAumento:F2}");
            Console.WriteLine($"Novo salário, após o aumento: R$ {novoSalario:F2}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
