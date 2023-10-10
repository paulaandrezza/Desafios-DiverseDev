using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// DESAFIO 07:

// Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
// para a organização de um sistema de gerenciamento de vendas. Elabore um algoritmo que,
// a partir de dados fornecidos pelo usuário, calcule o valor da venda de um produto,
// exibindo uma saída em vídeo contendo o código do produto, o nome, a quantidade
// comprada, o valor unitário e o valor total.



class Desafio07 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.WriteLine("Sistema de Gerenciamento de Vendas");

            Console.Write("Informe o código do produto: ");
            int codigoProduto = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Informe a quantidade comprada: ");
            int quantidadeComprada = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor unitário do produto: R$ ");
            double valorUnitario = double.Parse(Console.ReadLine());

            double valorTotal = quantidadeComprada * valorUnitario;

            Console.WriteLine("\nResumo da Venda:");
            Console.WriteLine($"Código do Produto: {codigoProduto}");
            Console.WriteLine($"Nome do Produto: {nomeProduto}");
            Console.WriteLine($"Quantidade Comprada: {quantidadeComprada}");
            Console.WriteLine($"Valor Unitário: R$ {valorUnitario:F2}");
            Console.WriteLine($"Valor Total: R$ {valorTotal:F2}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
