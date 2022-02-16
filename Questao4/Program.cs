using System;
namespace Conversao
{
    public class Program
   {
     public static void Main(string[] args)
     {
        float c, f;
        Console.WriteLine("Digite o valor da temperatura em graus Celsius: ");
        c = float.Parse(Console.ReadLine());

        f = (c * 9 / 5) + 32;
        Console.WriteLine($"A conversão da temperatura de Celsius para Fahrenheit é: {f}º");
     }
   }
}

