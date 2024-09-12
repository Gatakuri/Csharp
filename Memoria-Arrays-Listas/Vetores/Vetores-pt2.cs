using System;
using Vetores2;

namespace Vetores_parte2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Product[] produto = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                produto[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += produto[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("Preço médio: " + avg);
        }
    }
}
