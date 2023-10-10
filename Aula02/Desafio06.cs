using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// DESAFIO 06:

// Elabore um algoritmo que dada a idade de um nadador, classifique-o em uma das
// seguintes categorias:
// Infantil A = 5 a 7 anos.
// Infantil B = 8 a 11 anos.
// Juvenil A = 12 a 13 anos.
// Juvenil B = 14 a 17 anos.
// Adultos = Maiores de 18 anos.
// Apresentar as mensagens no console com a classificação.


class Desafio06 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.Write("Digite a idade do nadador: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                string categoria = ClassificarNadador(idade);
                Console.WriteLine($"O nadador pertence à categoria: {categoria}");
            }
            else
            {
                Console.WriteLine("Idade inserida não é um número válido.");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }

    static string ClassificarNadador(int idade)
    {
        if (idade >= 5 && idade <= 7)
        {
            return "Infantil A";
        }
        else if (idade >= 8 && idade <= 11)
        {
            return "Infantil B";
        }
        else if (idade >= 12 && idade <= 13)
        {
            return "Juvenil A";
        }
        else if (idade >= 14 && idade <= 17)
        {
            return "Juvenil B";
        }
        else if (idade >= 18)
        {
            return "Adultos";
        }
        else
        {
            return "Idade não corresponde a uma categoria válida.";
        }
    }
}
