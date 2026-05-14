using System;
using System.Globalization;

public class Exercicio4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o tipo de cliente ( Comun,VIP,Premium) :");
        string tipoCliente = Console.ReadLine()!;

        decimal desconto;

        desconto = tipoCliente switch
        {
            "Comun" => 0.05m,
            "VIP" => 0.10m,
            "Premium" => 0.15m,
            _ => 0.00m
        };
         
         Console.Write($" O desconto foi de : {desconto}");
    }
}