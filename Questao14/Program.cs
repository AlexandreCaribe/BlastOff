using System;
namespace Palindromo
{
    public class Program
   {
     public static void Main(string[] args)
     {
        Console.WriteLine("Digite uma palavra: ");
        String palavra = Console.ReadLine().ToLower();
        String palindromo = new string(palavra.Reverse().ToArray());

        if (palavra == palindromo){
          Console.WriteLine("A palavra é um palíndromo");
        }else{
          Console.WriteLine("A palavra não é um palíndromo");
        }
     }
   }
}

