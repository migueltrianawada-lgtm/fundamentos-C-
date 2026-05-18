using System;
using System.Globalization;

public class Exercicios3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Deseja adicionar um produto ao estoque digite 1 - sim / 0 não :");
        int escolha = int.Parse(Console.ReadLine());
        int estoque = 0;
        while(escolha != 0)
        {
            Console.WriteLine("Digite a Quantidade : ");
            int quantidade = int.Parse(Console.ReadLine());
            estoque = estoque + quantidade;
            Console.Write($"Estoque atual é : {estoque} \n");
            Console.WriteLine("Deseja Continuar ? Digite : 1 - sim / 0 não ?");
            escolha = int.Parse(Console.ReadLine());

        }
         Console.WriteLine("Obrigado por usar nosso sistema de estoque!");
    }
}