using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

public class Execicio6
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Que Momento do dia e hoje ? Digite 1 caso for Manha ,2 caso foi Tarde , 3 Caso for Noite: ");
        int momento = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Qual e seu Nome ? : ");
        string nome = Console.ReadLine()!;

        switch (momento)
        {
            case 1 : Console.Write($"Bom dia, {nome}");
             break;
            case 2 : Console.Write($"Boa Tarde , {nome}");
             break;
            case 3 : Console.Write($"Boa Noite, {nome}");
             break;
            default: Console.Write("Error na Escolha! ");
                break;
                  
        }
    }
}