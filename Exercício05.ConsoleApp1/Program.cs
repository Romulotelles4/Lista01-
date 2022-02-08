using System;

namespace Exercício05.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());

            int valorC;

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
                Console.WriteLine("C = " + valorC);

            }
            else
            {
                valorC = valorA * valorB;
                Console.WriteLine("C = " + valorC);

            }
            Console.ReadLine();
        }
    }
}