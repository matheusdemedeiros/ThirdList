using System;

namespace ThirdListQ2.ConsoleApp
{
    /*
     Escrever um algoritmo que 
     gera e escreve os números 
     ímpares entre 100 e 200.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 100, value2 = 200;
            int[] numbers = new int[((value2 - value1) / 2) + 1];
            Console.WriteLine("========================================");
            Console.WriteLine("Gerando os números ímpares de {0} a {1};", value1, value2);
            int cont = 0;
            for (int i = value1; i < value2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(": {0}", i);
                    Console.ResetColor();
                    cont++;
                }
            }
            Console.WriteLine("Cont: {0}", cont);
        }
    }
}
