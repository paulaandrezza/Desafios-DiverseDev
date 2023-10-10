﻿using System.Runtime.Intrinsics.X86;

// Desafio 3: Calculadora de Gorjeta

// Objetivo: Escrever um programa que calcule o valor da gorjeta a ser deixada em um
// restaurante com base no valor da conta e na porcentagem de gorjeta.

// Instruções:

// Solicite ao usuário que insira o valor total da conta do restaurante.
// Solicite ao usuário que insira a porcentagem de gorjeta desejada
// (por exemplo, 15% ou 20%).
// Calcule o valor da gorjeta multiplicando o valor da conta pela porcentagem de gorjeta
// e dividindo por 100.
// Exiba o valor da gorjeta e o total a ser pago (conta + gorjeta) na tela.

// Dica: Use variáveis para armazenar os valores de entrada e os resultados intermediários.


internal class Desafio03 : Desafio
{
    public override void Execute()
    {
        Console.Write("Qual o valor total da conta do restaurante: R$ ");
        float amount = float.Parse(Console.ReadLine());
        Console.Write("Qual a porcentagem da gorjea (por exemplo, 15% ou 20%): ");
        float tip = float.Parse(Console.ReadLine());

        Console.WriteLine(
            $"O valor da gorjeta é: R$ {amount * tip / 100:0.00}\nO valor a ser pago é: R$ {amount * (1 + tip / 100):0.00}"
        );
    }
}
