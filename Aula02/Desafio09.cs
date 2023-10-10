using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// DESAFIO 09:

// Crie um algoritmo que dê um leque de opções de cursos para o usuário
// escolher e qual turma ele poderá ingressar, usando o conceito
// de "Switch-Case" na linguagem CSharp.


class Desafio09 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.WriteLine("Escolha um curso para se matricular:");

            Console.WriteLine("1 - Curso de Programação");
            Console.WriteLine("2 - Curso de Design Gráfico");
            Console.WriteLine("3 - Curso de Marketing Digital");
            Console.WriteLine("4 - Sair");

            Console.Write("Digite o número do curso desejado: ");
            int escolhaCurso = int.Parse(Console.ReadLine());

            switch (escolhaCurso)
            {
                case 1:
                    Console.WriteLine("Você escolheu o Curso de Programação.");
                    Console.WriteLine("Agora, escolha a turma:");
                    Console.WriteLine("A - Manhã");
                    Console.WriteLine("B - Tarde");
                    Console.WriteLine("C - Noite");
                    Console.Write("Digite a letra da turma desejada: ");
                    char escolhaTurma = Console.ReadLine()[0].ToString().ToUpper()[0];

                    switch (escolhaTurma)
                    {
                        case 'A':
                            Console.WriteLine(
                                "Você está matriculado na turma da manhã do Curso de Programação."
                            );
                            break;
                        case 'B':
                            Console.WriteLine(
                                "Você está matriculado na turma da tarde do Curso de Programação."
                            );
                            break;
                        case 'C':
                            Console.WriteLine(
                                "Você está matriculado na turma da noite do Curso de Programação."
                            );
                            break;
                        default:
                            Console.WriteLine("Opção de turma inválida.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Você escolheu o Curso de Design Gráfico.");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu o Curso de Marketing Digital.");
                    break;
                case 4:
                    Console.WriteLine("Você saiu do programa.");
                    break;
                default:
                    Console.WriteLine("Opção de curso inválida.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
