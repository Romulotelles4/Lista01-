using System;

namespace Exercício01.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            float valora = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            float valorb = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            float valorc = float.Parse(Console.ReadLine());

            float somaab;
            
            somaab = valora + valorb;
            
            if (somaab < valorc)
            {
                Console.WriteLine("A soma de A + B é menor que o valor de C. ");

            }
            Console.ReadLine();




        }
    }
}
