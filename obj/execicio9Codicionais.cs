using System;
using System.Globalization;

public class Codicionais5
{
    
    public static void Main(string[] args)
    {
        for(int i = 1 ; i <= 20; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            int numero = i;
            Console.Write($"\n os numeros são : {numero}");
        }

        
    }
}