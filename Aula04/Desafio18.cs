using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 18

// Escreva um programa em C# que solicite ao usuário que adivinhe um número secreto entre 1 e 100.
// O programa deve gerar aleatoriamente o número secreto e fornecer dicas sobre se o palpite do
// usuário é maior ou menor do que o número secreto. O programa deve continuar pedindo
// palpites até que o usuário adivinhe corretamente o número secreto.


class Desafio18 : Desafio
{
    public override void Execute()
    {
        try
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            int palpite;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

            while (true)
            {
                Console.Write("Digite seu palpite: ");
                if (int.TryParse(Console.ReadLine(), out palpite))
                {
                    tentativas++;

                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine(
                            $"Parabéns! Você acertou o número secreto ({numeroSecreto}) em {tentativas} tentativas."
                        );
                        break;
                    }
                    else if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("Tente um número maior.");
                    }
                    else
                    {
                        Console.WriteLine("Tente um número menor.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
