using System;
using System.Globalization;
using Microsoft.VisualBasic;

public class Exercicios2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o Valor da venda (ou 0 para encerrar ) : ");
        double valorDaVenda = double.Parse(Console.ReadLine(),CultureInfo.CurrentCulture);

        while(valorDaVenda > 0)

        {

            Console.WriteLine($"Digite o Valor da venda (ou 0 para encerrar ) : {valorDaVenda} ");
            double novoValor = double.Parse(Console.ReadLine(),CultureInfo.CurrentCulture);
             valorDaVenda = valorDaVenda + novoValor;
        }
         Console.Write($"Total vendas do dia :{valorDaVenda} ");
    }
}