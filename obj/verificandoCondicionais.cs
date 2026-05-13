 using System;
 using System.Globalization;
 public class VerificandoCondicionais
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o saldo : ");
        double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        if (saldo <= -1)
        {
            Console.Write("O saldo esta negativo !");
        }
        else if(saldo == 0)
        {
            Console.Write("Saldo e igual a zero !");

        }
        else
        {
            Console.Write("Saldo Positivo!");
        }
    }

}