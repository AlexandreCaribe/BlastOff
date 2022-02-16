using System;
namespace Interseccao
{
    public class Program
   {
     public static void Main(string[] args)
     {
        var a = new List<int>() {1, 2, 3, 4};
        var b = new List<int>() {1, 2, 5, 8};
        var interseccao = new List<int>();
        for (var i = 0; i < a.Count; i++){
          for (var j = 0; j < b.Count; j++){
            if (a[i] == b[j]){
              interseccao.Add(a[i]);
            }
                          
          }
        }

        foreach(var valor in interseccao){
          Console.WriteLine(valor);
        }      
     }
   }
}