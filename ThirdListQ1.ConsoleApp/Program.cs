using System;

namespace ThirdListQ1.ConsoleApp
{
    /*
     Desenvolver um algoritmo que leia a altura de 15 pessoas.
     Este programa deverá calcular e mostrar: 
        a. A menor altura do grupo; 
        b. A maior altura do grupo;
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] heightPeoples = new decimal[15];
            decimal max = 0, min = 0;

            for (int i = 0; i < heightPeoples.Length; i++)
            {
                int cont = i + 1;
                
                Console.Write("Informe a altura da pessoa ({0}): ", cont);
                heightPeoples[i] = decimal.Parse(Console.ReadLine());
                if(heightPeoples[i] >= max)
                {
                    max = heightPeoples[i];
                }
                if(i == 0)
                {
                    min = heightPeoples[i];
                }
                else
                {
                    if(min >= heightPeoples[i])
                    {
                        min = heightPeoples[i];
                    }
                }

            }
            Console.WriteLine("A maior altura da lista é: {0}", max);
            Console.WriteLine("A menor altura da lista é: {0}", min);
        }
    }
}
