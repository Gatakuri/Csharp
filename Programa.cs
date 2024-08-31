using System;

namespace Banco {

    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Deseja fazer depósito inicial? (s/n) ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's') {
                Console.Write("Entre o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, deposito);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            

        }
    }

}
