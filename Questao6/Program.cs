using System;
namespace Tempo
{
    public class Program
   {
     public static void Main(string[] args)
     {  
        Console.WriteLine("Digite a hora que o jogo iniciou: ");
        Console.WriteLine("Exemplo: 18:00 deve ser digitado 18.00");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a hora que o jogo terminou: ");
        Console.WriteLine("Exemplo: 18:00 deve ser digitado 18.00");
        double b = double.Parse(Console.ReadLine());

        double duracaoPartida = b - a;
        String formato = new string(duracaoPartida.ToString());
        Console.WriteLine($"A partida durou um total de {formato[0]}h{formato[1]}{formato[2]}min.");
     }
   }
}

