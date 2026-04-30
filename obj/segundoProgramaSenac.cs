public class Progra {
  
    
     public static void Main()
      {
        //
        Console.Write("Velocidade:  " );
        int velocidade = int.Parse(Console.ReadLine());

        if(velocidade > 60)
        {
            Console.WriteLine("Voce exedeu o limite de velocidade .");
            Console.WriteLine("\nMultado!");
        }
        else
        {
            Console.WriteLine("Velocidade não exedeu o limite");   
        }
    
    }
}