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

        for (int i = 0 ;i<=funcionarios.Count ;i++)
        {
           var nome = funcionarios[i].Split("-")[0];//metodo Split Divide  a string
            if (nome.Equals("Fernanda"))//metodo Equals verifica si o valor da variavel e igual
            {
                Console.WriteLine($"Dados dos funcionario buscado : {funcionarios[i]}");
                break;//sai do lop
            }
        }
        for (int i = 0 ;i<=funcionarios.Count ;i++)
        {
           var salario = funcionarios[i].Split("-")[2];//metodo Split Divide  a string
           var salarioInt = int.Parse(salario);
            if (salarioInt > 5000)
            {
                continue;//retorna na linha principal
            }
           Console.WriteLine($"Dados dos funcionario buscado : {funcionarios[i]}");
        }
    }
}