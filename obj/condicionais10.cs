using System;
using System.Globalization;

public class Codicionais5
{
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o Numero: ");
        int numero = int.Parse(Console.ReadLine());

        for(int i = 1;i <= 10; i++)
        {
            int num = numero;
            int resultado = num * i;
            Console.Write($"\n {num} * {i} = {resultado}");
        }
          Console.Write($"\nFim da tabulada do {numero}");
        
    }
}