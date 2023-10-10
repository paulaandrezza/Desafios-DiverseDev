using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 12:
// Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
// a partir deles, crie um vetor C, composto pela somados elementos, sendo:

// C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.


class Desafio12 : Desafio
{
    public override void Execute()
    {
        try
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];

            Console.WriteLine("Digite os elementos do vetor A:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"A[{i + 1}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor B:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"B[{i + 1}]: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                C[i] = A[i] + B[9 - i];
            }

            Console.WriteLine("Vetor C (soma de A e B):");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"C[{i + 1}] = {C[i]}");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
