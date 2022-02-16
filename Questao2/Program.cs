using System;
namespace Consumo
{
    public class Program
   {
     public static void Main(string[] args)
     {
       float consumoMedio, a, b;

       Console.WriteLine("Digite a distância A: ");
       a = float.Parse(Console.ReadLine());

       Console.WriteLine("Digite o combustível gasto B: ");
       b = float.Parse(Console.ReadLine());

       consumoMedio = a/b;
 
       Console.WriteLine("O consumo médio foi de: " + consumoMedio);
     }
   }
}

