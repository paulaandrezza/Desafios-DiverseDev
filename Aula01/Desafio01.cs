using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 1: Calculadora

// Objetivo: Escrever um programa que solicite ao usuário dois números e realize operações
// simples de adição, subtração, multiplicação e divisão.

// Instruções:

// Solicite ao usuário que insira dois números.
// Realize as operações de adição, subtração, multiplicação e divisão entre esses números.
// Exiba os resultados das operações no console.

// Dica: Use variáveis para armazenar os números de entrada e os resultados intermediários.


class Desafio01 : Desafio
{
    public override void Execute()
    {
        Console.Write("Insira o primeiro número: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Insira o segundo número: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Adição: {number1} + {number2} = {number1 + number2}");
        Console.WriteLine($"Subtração: {number1} - {number2} = {number1 - number2}");
        Console.WriteLine($"Multiplicação: {number1} * {number2} = {number1 * number2}");
        if (number2 == 0)
        {
            Console.WriteLine("Divisão por 0 não é possível");
        }
        else
        {
            Console.WriteLine($"Divisão: {number1} / {number2} = {number1 / number2}");
        }
    }
}
