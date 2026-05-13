 using System;
 using System.Globalization;

 public class Exercio4
{
    public static void Main(string[] args)
    {
        Console.Write("Digite  a Senha : ");
        int senha = int.Parse(Console.ReadLine()!);
        Console.Write("Digite  o nível de acesso : ");
        int nivel = int.Parse(Console.ReadLine()!);

        if (senha == 42 && nivel >= 5)
        {
            Console.Write("Acesso Consedido !");
        }
        else
        {
            Console.Write("Acesso Negado !");
        }

    }

}