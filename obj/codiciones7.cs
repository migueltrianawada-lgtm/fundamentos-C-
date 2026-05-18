using System;
using System.Globalization;

public class Codicionais5
{
    
    public static void Main(string[] args)
    {
        List<string>funcionarios = new List<string>
        {
            "João-Gerente-8500",
            "Maria-Analista de Sistemas-6200",
            "Calos-Desemvolvedor-5500",
            "Ana-Desinger-4800",
            "Pedro-Suporte Tecnico-3900",
            "Fernanda-Coordenadora de Projetos-7300",
            "Ricardo-Contador-6000",
            "Juliana-Rh-4500"
        };

        foreach (string funcionario in funcionarios)
        {
            var nome = funcionario.Split("-")[0];
            if (nome.Equals("Fernanda"))
            {
                Console.WriteLine($"Dados do Funcionario buscando:  {funcionario}");
            }
        }
    }
}