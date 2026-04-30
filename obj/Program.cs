// Screen Sound
using System;
using System.Globalization;
public class ProgramAluraCurso 
{
    public static void Main(string[]args){
      
      string mensajenDeBoasVindas = "\nBoas vindas ao Sreen Sound";//Variveis Camel  Cases
      List<string>ListaDasBandas = new List<string>{"U2","The Beatles,","Calipso"};//criando lista das bandas
        void Exibirlogo()//Função Pascal Cases
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
            Console.Write(mensajenDeBoasVindas);
            
        }
            void HarumiTeAmo()
            {
               Console.Write(@"\r\n
██╗░░██╗░█████╗░██████╗░██╗░░░██╗███╗░░░███╗██╗  ████████╗██████╗░██╗░█████╗░███╗░░██╗░█████╗░
██║░░██║██╔══██╗██╔══██╗██║░░░██║████╗░████║██║  ╚══██╔══╝██╔══██╗██║██╔══██╗████╗░██║██╔══██╗
███████║███████║██████╔╝██║░░░██║██╔████╔██║██║  ░░░██║░░░██████╔╝██║███████║██╔██╗██║███████║
██╔══██║██╔══██║██╔══██╗██║░░░██║██║╚██╔╝██║██║  ░░░██║░░░██╔══██╗██║██╔══██║██║╚████║██╔══██║
██║░░██║██║░░██║██║░░██║╚██████╔╝██║░╚═╝░██║██║  ░░░██║░░░██║░░██║██║██║░░██║██║░╚███║██║░░██║
╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░╚═╝░░░░░╚═╝╚═╝  ░░░╚═╝░░░╚═╝░░╚═╝╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝

████████╗███████╗  ░█████╗░███╗░░░███╗░█████╗░
╚══██╔══╝██╔════╝  ██╔══██╗████╗░████║██╔══██╗
░░░██║░░░█████╗░░  ███████║██╔████╔██║██║░░██║
░░░██║░░░██╔══╝░░  ██╔══██║██║╚██╔╝██║██║░░██║
░░░██║░░░███████╗  ██║░░██║██║░╚═╝░██║╚█████╔╝
░░░╚═╝░░░╚══════╝  ╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            }

           void RegistrarBandas()
        {
            Console.Clear();
            Console.WriteLine("************** ");
            Console.WriteLine("Registo de bandas ");
            Console.WriteLine("************** ");
            Console.Write("Digite o nome da banda que deseja registar :  ");
            string nomeDaBanda = Console.ReadLine()!;
            ListaDasBandas.Add(nomeDaBanda);
            Console.WriteLine($"A banda registrada foi a {nomeDaBanda} foi registrada com succeso\n");
            Thread.Sleep(2000);//espera em mini segundos
            ExibirOpcoesDoMenu();//chamando a função para retornar no menu


        }
        void MostrarBandasRegistradas()
        {
            Console.Clear();
            Console.WriteLine("************** ");
            Console.WriteLine("\nExibindo todas as Bandas ");
            Console.WriteLine("\n************** ");
            for(int i = 0; i < ListaDasBandas.Count; i++)
            {
                Console.Write($"Banda:\n {ListaDasBandas[i]}\n");
            }
            Console.Write("Digite Uma tecla para retornar no menu ");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();//chamando a função para retornar no menu


        }


            void ExibirOpcoesDoMenu()
            {
                Exibirlogo();
                Console.WriteLine("\n\nDigite 1 para registar uma banda: ");
                Console.WriteLine("Digite 2 para registar todas as bandas: ");
                Console.WriteLine("Digite 3 para avaliar uma  banda: ");
                Console.WriteLine("Digite 4 para exibir a media de uma banda : ");
                Console.WriteLine("Digite -1 para sair: ");

                Console.Write("Digite a sua opção: ");
                int OpcaoEscolida = int.Parse(Console.ReadLine()!);




            switch (OpcaoEscolida)
            {
                case 1: RegistrarBandas();
                   break;
                case 2:MostrarBandasRegistradas();
                   break;
                case 3:Console.WriteLine($"Você digito a opção {OpcaoEscolida} ");
                   break;
                case 4:Console.WriteLine($"Você digito a opção {OpcaoEscolida} ");
                   break;
                case -1:Console.WriteLine($"Você digito a opção {OpcaoEscolida} ");
                   break;
                default: Console.WriteLine("Você digito a opção Invalida! ");
                break;
            }

            
            }

        
     
     Exibirlogo();
     ExibirOpcoesDoMenu();
     //HarumiTeAmo();
      
 }
}
 
