using System.Runtime.Intrinsics.X86;

// Desafio 2: Calculadora de Idade

// Objetivo: Escrever um programa que solicite ao usuário o ano atual e o ano de nascimento
// e calcule a idade.

// Instruções:

// Solicite ao usuário que insira o ano atual.
// Solicite ao usuário que insira o ano de nascimento.
// Calcule a idade subtraindo o ano de nascimento do ano atual.
// Exiba a idade no console.

// Dica: Use variáveis para armazenar os valores de entrada e os resultados intermediários.

internal class Desafio02 : Desafio
{
    public override void Execute()
    {
        Console.Write("Qual o ano atual: ");
        int currentYear = int.Parse(Console.ReadLine());
        Console.Write("Qual o ano de nascimento: ");
        int birthYear = int.Parse(Console.ReadLine());

        if (birthYear > currentYear)
        {
            Console.WriteLine(
                "Não é possível calcular a idade, pois o ano de nascimento é maior do que o ano atual."
            );
        }
        else
        {
            Console.WriteLine($"A idade é: {currentYear - birthYear}");
        }
    }
}
