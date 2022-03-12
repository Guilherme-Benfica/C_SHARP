using System;
using System.Globalization;

namespace Course
{
    class program
    {

        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + ", cujo preco é $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preco é $ " + preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: " + idade + " anos de idade, " + "codigo " + codigo + " e gênero: " + genero);
            Console.WriteLine();
            Console.WriteLine("medida com 8 casas decimais: " + medida);
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3"));


        }

    }
}