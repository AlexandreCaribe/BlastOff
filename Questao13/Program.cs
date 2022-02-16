using System;
namespace Matriz
{
    public class Program
   {
     public static void Main(string[] args)
     {
        int[,] matriz = new int[3,3] {{19, 32, 24}, {78, 26, 14}, {60, 98, 5}};
        for(int x = 0; x<matriz.GetLength(0); x++){
          for(int y = 0; y<matriz.GetLength(1); y++){
            Console.WriteLine(matriz[x,y]);
          }
        }
     }
   }
}