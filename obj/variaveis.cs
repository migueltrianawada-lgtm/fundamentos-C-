using System;
using System.Collections.Generic; // Necessário para Dictionary e List
using System.Threading;
using System.Globalization;// Opcional: para aceitar ponto decimal
using System.Linq;
using System.ComponentModel;

public class Variaveis
{
    public static void Main(string[]args){

        Console.Write("Digite o ano do seu nacimento : ");
        int anoDoNacimento = int.Parse(Console.ReadLine());

        int idadeAtual = 2026 - anoDoNacimento;

        Console.Write($"Sua idade e {idadeAtual} años");

        Console.Write("\nDigite as Milhas : ");

        double milhas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
         
        double quilometros = milhas * 1.60934;

        Console.Write($"{milhas} milhas equivalem a {quilometros.ToString("F2")} quilimetros \n ");

        Console.Write("Digite o valor da hora: ");
        int hora = int.Parse(Console.ReadLine());
        Console.Write("Digite os Minutos: ");
        double minutos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.Write($"Tempo {hora} Horas e {minutos} Minutos \n");

        Console.Write("Digite a Largura : ");
        double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Digite o Comprimento : ");
        double comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double area = largura * comprimento;

        Console.Write($"Area do Terreno e : {area.ToString("F2")} metros quadrados\n");


        Console.Write("Digite as nota 1 do aluno: ");
        float nota1 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Digite as nota 2 do aluno: ");
        float nota2 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Digite as nota 3 do aluno: ");
        float nota3 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double meiaDasNotas = (nota1 + nota2 + nota3)/3;

        Console.Write($"A Méia Das Notas é : {meiaDasNotas.ToString("f1")}\n");


        Console.Write("Digite  a o peso so container ");
        double pesoDoContainer = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        int veiculos = (int)pesoDoContainer;

        Console.Write($"Veículos nesesarios: {veiculos}\n");

        int vidas = 5; 
        vidas--;  
        vidas++; 
        vidas++; 
        int vidasFinais = vidas; 

        Console.WriteLine("Vidas finais: " + vidasFinais); 

        decimal salarioAtual = 1500.0m; 
        decimal percentualAumento = 10.0m; 
        decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100); 

        Console.WriteLine("\nO novo salário é de R$" + novoSalario.ToString("F2")); 

        Console.Write("Digite o valor do raio : ");
        double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);  
        double pi = 3.14159; 

        double area = pi * raio * raio;  
        double perimetro = 2 * pi * raio; 

        Console.WriteLine("\nRaio: " + raio.ToString("F2"));  
        Console.WriteLine("Área do círculo: " + area.ToString("F2"));  
        Console.WriteLine("Perímetro do círculo: " + perimetro.ToString("F2")); 






    }

}