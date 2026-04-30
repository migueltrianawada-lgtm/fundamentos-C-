public class Program2
{
    public static void Main()
    {
         Console.Write("Digite o valor da Compra = ");
         double valorDaCompra = double.Parse(Console.ReadLine());
         
         double valorComDesconto = valorDaCompra * 0.90;
         double valorComAcrescimo = valorDaCompra * 1.05;
         double valorPorParcela = valorComAcrescimo / 3;

         Console.Write($"Valor com desconto : R$ {valorComDesconto}");
         Console.Write($"\nValor com acresimo : R$ {valorComAcrescimo}");
         Console.Write($"\nValor com parcela : R$ {valorPorParcela}");
         
         
    }
}