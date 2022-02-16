using System;
namespace Media
{
    public class Program
   {
     public static void Main(string[] args)
     {
       
       int i,j,k,x,y; 

       Console.WriteLine("Digite a idade I: ");
       i = int.Parse(Console.ReadLine());

       Console.WriteLine("Digite a idade J: ");
       j = int.Parse(Console.ReadLine());

       Console.WriteLine("Digite a idade K: ");
       k = int.Parse(Console.ReadLine());

       Console.WriteLine("Digite a idade X: ");
       x = int.Parse(Console.ReadLine());

       Console.WriteLine("Digite a idade Y: ");
       y = int.Parse(Console.ReadLine());
     
       float media = ((i+j+k+x+y)/5.0f);


       Console.WriteLine("A média das idades é: " + media);
       
     }
   }
}