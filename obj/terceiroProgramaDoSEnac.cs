
using System; // Obrigatório para usar Console
using System.Globalization; // Opcional: para aceitar ponto decimal

public class Programa3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nota do Aluno : ");
        double nota = double.Parse(Console.ReadLine());
        if(nota >= 9.0)
        {
            Console.WriteLine("Desempenho : Exelente !");
        }
        else if(nota >= 7.0)
        {
            Console.WriteLine("Desempenho: Bom!");
        }
        else if (nota >= 5.0)
        {
            Console.WriteLine("Desempenho: Regular!");
        }
        else
        {
            Console.WriteLine("Desempenho: Insuficiente!");
        }
    }

}