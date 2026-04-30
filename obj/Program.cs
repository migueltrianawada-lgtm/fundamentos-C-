// Screen Sound
using System;
using System.Globalization;
public class ProgramAluraCurso 
{
    public static void Main(string[]args){
      
      string mensajenDeBoasVindas = "Boas vindas ao Sreen Sound";//Variveis Camel  Cases

        void ExibirMensagemDeBoasVindas()//Função Pascal Cases
        {
            Console.WriteLine(@"\r\n
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
            Console.WriteLine("Registo de bandas ");
            Console.Write("Digite o nome da banda que deseja registar :  ");

        }


            void ExibirOpcoesDoMenu()
            {
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
                case 2:Console.WriteLine($"Você digito a opção {OpcaoEscolida} ");
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

        
     
     ExibirMensagemDeBoasVindas();
     ExibirOpcoesDoMenu();
     //HarumiTeAmo();
      
 }
}
 
