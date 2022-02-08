using System;

namespace Exercício03.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu peso? ");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura? ");
            float altura = float.Parse(Console.ReadLine());

            float imc;

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {

                Console.WriteLine("Seu IMC é: " + imc + " (Abaixo do peso) ");

            }

            if (imc > 18.5 & imc < 25)
            {

                Console.WriteLine("Seu IMC é: " + imc + " (Peso normal) ");

            }

            if (imc > 25 & imc < 30)
            {

                Console.WriteLine("Seu IMC é: " + imc + " (Acima do peso) ");

            }

            if (imc > 30)
            {

                Console.WriteLine("Seu IMC é: " + imc + " (Obeso) ");

            }


            Console.ReadLine();

        }
    }
}
