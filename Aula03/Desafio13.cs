using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 13:

// Crie um programa que peça 10 números inteiros
// e apresente a média, a soma e o menor.


class Desafio13 : Desafio
{
    public override void Execute()
    {
        try
        {
            int[] numeros = new int[10];
            int soma = 0;
            int menor = int.MaxValue;

            Console.WriteLine("Digite 10 números inteiros:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());

                soma += numeros[i];

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            double media = (double)soma / 10;

            Console.WriteLine($"A média dos números é: {media}");
            Console.WriteLine($"A soma dos números é: {soma}");
            Console.WriteLine($"O menor número é: {menor}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
