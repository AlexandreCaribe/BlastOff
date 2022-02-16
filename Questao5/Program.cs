using System;
namespace Multiplos
{
    public class Program
   {
     public static void Main(string[] args)
     {
        int num, num2;
        Console.WriteLine("Digite o número: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número: ");
        num2 = int.Parse(Console.ReadLine());
        
        if (num % num2 == 0 || num2 % num == 0){
          Console.WriteLine($"Os números {num} e {num2} são múltiplos.");
        }else{
          Console.WriteLine($"Os números {num} e {num2} não são múltiplos.");
        }
     }
   }
}

