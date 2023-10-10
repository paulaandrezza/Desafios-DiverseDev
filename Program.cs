using System;
using System.IO;

namespace Desafios_DiverseDev
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChallenge = 0;
            bool validChoice = false;

            Desafio[] desafios = new Desafio[]
            {
                new Desafio01(),
                new Desafio02(),
                new Desafio03(),
                new Desafio04(),
                new Desafio05(),
                new Desafio06(),
                new Desafio07(),
                new Desafio08(),
                new Desafio09(),
                new Desafio10(),
                new Desafio11(),
                new Desafio12(),
                new Desafio13(),
                new Desafio14(),
                new Desafio15(),
                new Desafio16(),
            };

            Console.WriteLine("Desafios DiverseDev");
            printOptions(1, 1, 4);
            printOptions(2, 5, 11);
            printOptions(3, 12, 15);
            printOptions(4, 16, 16);

            while (!validChoice)
            {
                Console.Write("\nEscolha uma opção: ");
                if (
                    int.TryParse(Console.ReadLine(), out numberChallenge)
                    && numberChallenge > 0
                    && numberChallenge <= desafios.Length
                )
                {
                    validChoice = true;
                }
                else
                {
                    Console.Error.WriteLine(
                        "Opção inválida. Insira um número inteiro válido correspondente a um desafio."
                    );
                }
            }

            desafios[numberChallenge - 1].Execute();
        }

        static void printOptions(int classroom, int begin, int end)
        {
            Console.WriteLine($"\n Aula {classroom:D2}");
            for (int i = begin; i <= end; i++)
            {
                Console.WriteLine($"{i} - Desafio {i:D2}");
            }
        }
    }
}

internal class Desafio
{
    public virtual void Execute() { }
}
