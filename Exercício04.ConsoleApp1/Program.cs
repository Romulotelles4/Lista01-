﻿using System;

namespace Exercício04.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Esse número é par.");
            }
            else
            {
                Console.WriteLine("Esse número é ímpar.");
            }
            Console.ReadLine();
        }
    }
}
