using System;
namespace Primo
{
    public class Program
   {
     public static void Main(string[] args)
     {
        bool primo = true;

        Console.WriteLine("Informe um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());
    
        if (numero < 0) {
            Console.WriteLine("Número inválido.");
        }else if ((numero == 0) || (numero == 1)) {
            Console.WriteLine("Número não é primo.");
        }else {
            for (int i = 2; i <= (numero / 2); i++) {
                if (numero % i == 0) {
                    primo = false;
                    break;
                }
            }
    
            if (primo) {
                Console.WriteLine("O número é primo");
            }
            else {
                Console.WriteLine("O número não é primo");
            }
        }
     }
   }
}
