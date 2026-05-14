using System;
using System.Globalization;
using System.Reflection;

public class Execicio5
{
    public static void Main(string[] args)
{
    Console.WriteLine("Digite o primeiro número: ");
    int primeiroNumero = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite o segundo número: ");
    int segundoNumero = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite a operação (+, -, *, /): ");
    string operacao = Console.ReadLine()!;

    // Declaramos a variável para guardar o resultado
    double resultado = 0; 
    bool operacaoValida = true;

    switch (operacao)
    {
        case "+":
            resultado = primeiroNumero + segundoNumero;
            break;
        case "-":
            resultado = primeiroNumero - segundoNumero;
            break;
        case "*":
            resultado = primeiroNumero * segundoNumero;
            break;
        case "/":
            // Verificação simples para evitar erro de divisão por zero
            if (segundoNumero != 0)
            {
                resultado = (double)primeiroNumero / segundoNumero;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero!");
                operacaoValida = false;
            }
            break;
        default:
            Console.WriteLine("Opção inválida!");
            operacaoValida = false;
            break;
    }

    if (operacaoValida)
    {
        Console.WriteLine("O resultado é: " + resultado);
    }
}
}