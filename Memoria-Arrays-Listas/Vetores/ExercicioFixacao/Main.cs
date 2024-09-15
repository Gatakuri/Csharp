using Exercicio_Vetores;
using System;


namespace Pensionato {
    class Program {
        static void Main(string[] args) {


            Estudantes[] vect = new Estudantes[10];

            Console.WriteLine("Quantos quartos serão alugados?");

            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i < n; i++) {
                Console.WriteLine();

                Console.WriteLine("Aluguel #" + i);

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Estudantes(nome, email);

            }

            Console.WriteLine();

            for (int i = 0; i < vect.Length; i++) {

                if (vect[i] != null) {

                    Console.WriteLine("Quartos Ocupados:");
                    Console.WriteLine(i + ": " + vect[i]);

                }

            }

        }
    }
}
