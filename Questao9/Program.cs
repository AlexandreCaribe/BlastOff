using System;
namespace Tabuada
{
    public class Program
   {
     public static void Main(string[] args)
     {
        Console.WriteLine("Informe um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 10; i++){
            Console.WriteLine(numero + " * " + i + " = " + numero * i);
        }
     }
   }
}
