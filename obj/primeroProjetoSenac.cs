
        public class Program{

                public static void Main() {
        
        string mensagem = "celsius";
        
        Console.Write("Celsiu : ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 /5) + 32;

        Console.WriteLine($"Fahrenheit = {fahrenheit}" );

      }
    }