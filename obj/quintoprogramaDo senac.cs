using System;
using System.Globalization;
public class Program5 {
public static void Main(string [] args)
{
   Console.Write("Digite seu Peso : ");
   double peso = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
   Console.Write("Digite sua altura : ");
   double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
   double imc = peso / (altura * altura );

   Console.Write($"Seu IMC é : {imc.ToString("F2",CultureInfo.InvariantCulture)}");

   if ( imc < 20)
      {
         Console.Write("\nAbaixo do Peso");
      }
   else if(imc <= 20 && imc < 25)
      {
         Console.Write("\nPeso Ideal");
      }
   else if (imc >= 25)
      {
         Console.Write("\nAcima do Peso");
      }
      
   
Console.Write("\nFim do Programa!");
     

}
}