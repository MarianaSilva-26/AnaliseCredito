using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
        int  parcelas;
        decimal valor; 
        decimal valorParcela; 
        decimal valorMaximoParcela; 
        decimal rendaMensal;
        bool  valorValido , parcelasValido , rendaMensalValido;

        Console.Write("Digite o Valor Desejado: ");
        valorValido = Decimal.TryParse(Console.ReadLine(), out valor);
            
        if (!valorValido)
        {
        Console.WriteLine();
        Console.WriteLine("Você digitou um valor invalido");
        Console.WriteLine("Pressione ENTER para sair, e execute novamente");
        Console.ReadKey();
        Environment.Exit(-1);
        }

        Console.Write("Digite a Quantidade de Parcelas Desejada: ");
        parcelasValido = int.TryParse(Console.ReadLine(), out parcelas);

        if (!parcelasValido)
        {
        Console.WriteLine();
        Console.WriteLine("Você digitou um valor invalido");
        Console.WriteLine("Pressione ENTER para sair, e execute novamente");
        Console.ReadKey();
        Environment.Exit(-1);
        }

        Console.Write("Digite a Sua Renda Mensal: ");
        rendaMensalValido = Decimal.TryParse(Console.ReadLine(), out rendaMensal);
        Console.WriteLine();

        if (!rendaMensalValido)
        {
        Console.WriteLine("Você digitou um valor invalido");
        Console.WriteLine("Pressione ENTER para sair, e execute novamente");
        Console.ReadKey();
        Environment.Exit(-1);
        }

        valorParcela = valor / parcelas;
        valorMaximoParcela = rendaMensal * 0.3m;

        Console.WriteLine($"Sua Quantidade de Parcelas: {valorParcela:C}");
        Console.WriteLine($"Parcela Maxima: {valorMaximoParcela:C}");

        if (valorParcela <= valorMaximoParcela)
        {
        Console.WriteLine();
        Console.WriteLine("Seu credito foi aprovado!");
        }
        else
        {
        Console.WriteLine();
        Console.WriteLine("Seu credito não foi aprovado!");
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para sair!");
        Console.ReadKey();

        }
    }
}
