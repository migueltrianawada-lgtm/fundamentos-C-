 using System;
 using System.Globalization;

 public class Exercio2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o codigo do  produto (1 ou 2 ) : ");
        int codigo = int.Parse(Console.ReadLine()!);

        if (codigo == 1)
        {
            Console.Write("Perecível");
        }
        else if (codigo == 2)
        {
            Console.Write(" Não Perecível");
        }
        else
        {
            Console.Write("Codigo Errado !");
        }
    }
}