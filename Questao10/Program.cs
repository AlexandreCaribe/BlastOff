using System;
namespace Fatorial
{
    public class Program
   {
     public static void Main(string[] args)
     {
        Console.WriteLine("Informe um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(Fatorial(numero));
     }

    public static double Fatorial(int numero){
            if (numero == 1)
                return 1;
            else
                return numero * Fatorial(numero - 1);
        }
   }
}

