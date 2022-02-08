using System;

namespace ThirdListQ5.ConsoleApp
{
    /*
    Escreva um algoritmo que 
    leia um valor inicial A e 
    imprima a sequência de valores 
    do cálculo de A! e o seu resultado.
    Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string outputPrint;
            bool valid = false;
            do
            {
                Console.Write("Informe um número inteiro: ");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("O fatorial de ZERO é 1!");
                    Console.ResetColor();
                }
                else if (a < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não podemos calcular o fatorial de números NEGATIVOS!");
                    Console.ResetColor();
                }
                else
                {
                    valid = true;
                }
            } while (valid == false);

            if (valid == true)
            {
                int result = a;
                outputPrint = a + "! =  " + a;
                for (int i = a - 1; i >= 1; i--)
                {
                    result = result * i;
                    outputPrint += " X " + i;

                }
                Console.ForegroundColor = ConsoleColor.Green;
                outputPrint += " = " + result;
                Console.WriteLine(outputPrint);
                Console.ResetColor();
            }

        }
    }
}
