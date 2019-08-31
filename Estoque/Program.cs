using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {   
            Produto p = new Produto();

            Console.WriteLine("Entre os dados da compra");
            Console.WriteLine();
            Console.Write("Nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Qual é o preço da unidade: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Qual é a quantidade que voce vai levar: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dade de compra: " + p);

        }
    }
}
