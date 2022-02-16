using System;
namespace MenorNumero
{
    public class Program
   {
     public static void Main(string[] args)
     {
        int menorNumero, a, b, c;

        Console.WriteLine("Digite o número A: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número B: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número C: ");
        c = int.Parse(Console.ReadLine());

        menorNumero = a;
        if(menorNumero > b){
          menorNumero = b;
        }
        if(menorNumero > c){
          menorNumero = c;
        }

        Console.WriteLine("O menor número é: " + menorNumero);
      }
   }
}

