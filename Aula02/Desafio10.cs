using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// DESAFIO 10:

// Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma
// maneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela
// é palíndroma ou não.


class Desafio10 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine().ToLower();

            if (EhPalindromo(palavra))
            {
                Console.WriteLine("A palavra é um palíndromo.");
            }
            else
            {
                Console.WriteLine("A palavra não é um palíndromo.");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }

    static bool EhPalindromo(string palavra)
    {
        int comprimento = palavra.Length;
        for (int i = 0; i < comprimento / 2; i++)
        {
            if (palavra[i] != palavra[comprimento - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
