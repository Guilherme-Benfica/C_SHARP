using System;

using System.Globalization;

namespace Programa
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros inteiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }

            Console.WriteLine("Soma = " + soma);
        }
    }
} 
  