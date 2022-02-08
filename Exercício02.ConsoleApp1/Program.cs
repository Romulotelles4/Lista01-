using System;

namespace Exercício2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            int aux = 0;



            Console.WriteLine("Digite o primeiro valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            v3 = Convert.ToInt32(Console.ReadLine());


            if (v1 < v2)
            {
                aux = v1;
                v1 = v2;
                v2 = aux;
            }

            if (v1 < v3)
            {
                aux = v1;
                v1 = v3;
                v3 = aux;
            }

            if (v2 < v3)
            {
                aux = v2;
                v2 = v3;
                v3 = aux;
            }

            Console.WriteLine("A ordem decrescente dos três valores fica: " + v1 + ", " + v2 + ", " + v3);

            Console.ReadLine();






        }
    }
}
