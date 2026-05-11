using System;

public static class Programa6
{
    public static void  Main(string[]args)
    {
        Console.Write("Digite o humero para a tabulada:  \n");
        int numero = int.Parse(Console.ReadLine()!);

        for (int tabulada = 1; tabulada <= 10; tabulada ++)
        {
        int resultado = numero * tabulada;
        Console.WriteLine($"\n{numero} * {tabulada } = {resultado}");
        }
      
    }

}