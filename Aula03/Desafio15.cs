using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 15:

// Faça um algoritmo que leia números até o usuário digitar 0, após
// finalizar, mostre quantos números lidos, a soma e quantos são pares.


class Desafio15 : Desafio
{
    public override void Execute()
    {
        try
        {
            int numero;
            int soma = 0;
            int totalNumeros = 0;
            int numerosPares = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para sair):");

            do
            {
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    totalNumeros++;
                    soma += numero;
                    if (numero % 2 == 0)
                    {
                        numerosPares++;
                    }
                }
            } while (numero != 0);

            Console.WriteLine($"Total de números lidos: {totalNumeros}");
            Console.WriteLine($"Soma dos números lidos: {soma}");
            Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
