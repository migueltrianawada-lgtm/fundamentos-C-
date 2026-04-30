using System;// Obrigatório para usar Console
using System.Globalization;// Opcional: para aceitar ponto decimal

public class Program4
{
    public static void Main(string[] args)
    {
        // Usar CultureInfo.InvariantCulture permite digitar altura com ponto
        Console.Write("Digite sua altura: ");
        double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        Console.Write("Digite M  = masculino ou F  = Femenino ");
        string sexo = Console.ReadLine().ToUpper(); // .ToUpper() converte para maiúsculo;
       
        
        
    
        if(sexo =="M")//Adicionei as aspas duplas para tratar como texto
        {
            double homensPesoIdeal = (altura * 72.7) - 58.0;
            Console.Write($"O peso ideal do Homen e : {homensPesoIdeal.ToString("F2") } kg");//ToString("F2"): Usei isso para mostrar apenas 2 casas decimais no resultado
        }
        else if (sexo == "F")//Adicionei as aspas duplas para tratar como texto
        {
            double mulheresPesoIdeal = (altura * 62.1) - 44.7;
            Console.Write($"O peso ideal da Mulher e : {mulheresPesoIdeal.ToString("F2")} kg");//ToString("F2"): Usei isso para mostrar apenas 2 casas decimais no resultado
        }
        else
        {
            Console.Write("Error  Fim do programa!");
        }
    }
}