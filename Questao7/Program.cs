using System;
namespace Pares
{
    public class Program
   {
     public static void Main(string[] args)
     {
        Console.WriteLine("Digite até quanto vai a lista: ");
        int numero = int.Parse(Console.ReadLine());

        int[] lista;
        lista = new int[numero];
        for (int i = 0; i < numero; i++){ 
            lista[i] = i+1;
        }

        int[] x = Par(lista, numero);
        for(int i=0; i<x.Length;i++){
            Console.WriteLine("Pares: "+x[i]);
        }
     }

     public static int[] Par(int[] lista, int numero){
        int[] pares;
        int contador = 0;
        pares = new int[(numero)/2];
        for (int i = 1; i < numero; i++){
            if((lista[i] % 2 == 0) != false){
                pares[contador] = lista[i];
                contador+=1;
            }
        }
        return pares;
     }
   }
}

