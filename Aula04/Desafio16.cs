using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 16

// Escreva um programa em C# que calcule a soma dos números pares em um intervalo de números inteiros especificado pelo usuário.


class Desafio16 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.Write("Informe o valor inicial do intervalo: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor final do intervalo: ");
            int fim = int.Parse(Console.ReadLine());

            int somaPares = 0;

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 2 == 0)
                    somaPares += i;
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
