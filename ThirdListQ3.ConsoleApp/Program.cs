using System;

namespace ThirdListQ3.ConsoleApp
{
    /*
     Desenvolver um algoritmo que efetue a soma 
     de todos os números ímpares que são múltiplos
     de três e que se encontram no conjunto dos números
     de 1 até 500.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 1, value2 = 500, sum = 0;

            int[] numbers = new int[((value2 - value1) / 2) + 1];
            Console.WriteLine("========================================");
            Console.WriteLine("Gerando e somando os números ímpares\ne múltiplos de 3 de {0} a {1};", value1, value2);
            int cont = 0;
            
            for (int i = value1; i < value2; i++)
            {
                if ((i % 2 != 0) && (i % 3 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(": {0}", i);
                    Console.ResetColor();
                    sum = sum + i;
                    cont++;
                }
            }
            Console.WriteLine("Quantidade de números: {0}", cont);
            Console.WriteLine("Soma: {0}", sum);
        }
    }
}
