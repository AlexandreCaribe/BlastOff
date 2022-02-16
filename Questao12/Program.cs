using System;
namespace Concatenacao
{
    public class Program
   {
     public static void Main(string[] args)
     {
        var a = new List<int>() {1,2,3,4};
        var b = new List<int>() {1,2,5,8};
        var conc = a.Concat(b);
        foreach(int valor in conc)
          Console.WriteLine(valor);
     }
   }
}