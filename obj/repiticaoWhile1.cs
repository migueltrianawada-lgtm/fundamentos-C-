using System;
using System.Globalization;

public class Execicios1
{
    public static void Main(string[] args)
    {
        int contador = 10 ;
        while (contador >= 1)
        {
            Console.Write($" numero do contador e igual a : {contador}\n");
            contador--;
        }
        Console.Write("A contagem chego a seu fim! ");
    }
}