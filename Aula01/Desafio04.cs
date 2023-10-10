using System.Runtime.Intrinsics.X86;

// Desafio 4: Conversor de Moedas

// Objetivo: Escrever um programa que converta um valor em reais para outras duas moedas
// estrangeiras (por exemplo, dólar e euro).

// Instruções:

// Solicite ao usuário que insira um valor em reais.
// Defina as taxas de conversão para dólar e euro. Por exemplo, 1 dólar = 5,50 reais e 1 euro = 6,50 reais.
// Calcule o valor equivalente em dólares e euros.
// Exiba os valores convertidos na tela.

// Dica: Use variáveis para armazenar os valores de entrada, as taxas de conversão e os resultados intermediários.



internal class Desafio04 : Desafio
{
    public override void Execute()
    {
        const float dolar = 5.17f;
        const float euro = 5.45f;

        Console.Write("Insira um valor em Reais: R$ ");
        float real = float.Parse(Console.ReadLine());

        Console.WriteLine($"{real:0.00} em dolar é: $ {real / dolar:0.00}");
        Console.WriteLine($"{real:0.00} em euro é: € {real / euro:0.00}");
    }
}
