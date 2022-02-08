using System;

namespace ThirdListQ4.ConsoleApp
{
    internal class Program
    {
        /*
         Escrever um algoritmo que leia 
         um valor para uma variável N de 
         1 a 10 e calcule a tabuada de N.
        
         */
        static void Main(string[] args)
        {
            int n;
            bool proceed = false;
            do
            {
                Console.Write("Informe um número de 1 a 10: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 10)
                {
                    proceed = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("DESCULPE AMIGO(A), O NÚMERO INFORMADO DEVE \nPERTENCER AO INTERVALO DE 1 A 10;");
                    Console.ResetColor();
                    continue;
                }

            } while (proceed == false);

            if (proceed)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== TABUADA DE {0} ===", n);
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", n, i, (n * i));
                }
                Console.ResetColor();
            }

        }
    }

}
