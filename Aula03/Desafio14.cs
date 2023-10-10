using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 14:

// Some os números de 1 a 100 a imprima o valor.


class Desafio14 : Desafio
{
    public override void Execute()
    {
        try
        {
            int n = 100;
            int soma = (n * (n + 1)) / 2;

            Console.WriteLine($"A soma dos números de 1 a 100 é: {soma}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
