using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// DESAFIO 08:

// Um aluno realizou três provas de uma determinada disciplina. Levando em consideração o
// critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
// e caso positivo, que nota o aluno precisará obter para passar de ano.

// "Média = (Prova 1 + Prova 2 + Prova 3) / 3"

// A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:

// "Final = (Média + Exame) / 2"

// A média final para a aprovação deve ser igual ou maior que 5,0.



class Desafio08 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.WriteLine("Verificação de Aprovação em Disciplina");

            Console.Write("Informe a nota da Prova 1: ");
            double prova1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota da Prova 2: ");
            double prova2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota da Prova 3: ");
            double prova3 = double.Parse(Console.ReadLine());

            double media = (prova1 + prova2 + prova3) / 3;

            if (media >= 7.0)
            {
                Console.WriteLine($"Média final: {media:F2}");
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine($"Média: {media:F2}");
                Console.WriteLine("Aluno em exame final.");

                Console.Write("Informe a nota do Exame Final: ");
                double exame = double.Parse(Console.ReadLine());

                double mediaFinal = (media + exame) / 2;

                Console.WriteLine($"Média final após o Exame Final: {mediaFinal:F2}");

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado após o Exame Final!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado após o Exame Final.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
