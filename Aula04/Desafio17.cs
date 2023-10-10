using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 17

// Escreva um programa em C# que gere e exiba os primeiros N termos da sequência de Fibonacci, onde N é especificado pelo usuário.


class Desafio17 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.Write("Digite o número de termos da sequência de Fibonacci a serem exibidos: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonacci:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
