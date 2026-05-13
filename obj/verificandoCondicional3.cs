using System;
 using System.Globalization;

 public class Exercio3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite Nota do aluno : ");
        int nota = int.Parse(Console.ReadLine()!);

        if (nota >= 9)
        {
            Console.Write("O aluno recebeu a nota A! ");
        }
        else if (nota >= 7 && nota < 9 )
        {
            Console.Write("O aluno recebeu a nota B! ");
        }
        else if (nota >= 5 && nota < 7)
        {
            Console.Write("O aluno recebeu a nota C! ");
        }
        else if (nota >= 0 && nota < 5 )
        {
            Console.Write("O aluno recebeu a nota D! ");
        }
       
        else
        {
            Console.Write("No existe !");
        }

    }
}