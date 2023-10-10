using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// DESAFIO 05:

// Sr. José, pescador, comprou um microcomputador para
// controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
// peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
// (50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. Sr. José, precisa que
// você faça programa que leia o peso de peixes e verifique se há excesso.
// Se houver, gravar o Excesso e o valor da multa que Sr. José
// deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO.
// Apresentar as mensagens no console.


class Desafio05 : Desafio
{
    public override void Execute()
    {
        float peso,
            multa = 0;

        Console.Write("Insira o peso dos peixes: ");
        peso = float.Parse(Console.ReadLine());

        if (peso > 50)
        {
            multa = (peso - 50) * 4;
            Console.WriteLine(
                $"O excesso foi de: {peso - 50} kg valor da multa é de: R$ {multa:F2}"
            );
        }
        else
        {
            Console.WriteLine($"Não houve excesso. O valor da multa é de: R$ 0,00");
        }
    }
}
