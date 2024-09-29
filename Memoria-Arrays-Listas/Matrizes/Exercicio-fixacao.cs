//Fazer um programa para ler dois números inteiros M e N, e depois ler
//uma matriz de M linhas por N colunas contendo números inteiros,
//podendo haver repetições. Em seguida, ler um número inteiro X que
//pertence à matriz. Para cada ocorrência de X, mostrar os valores à
//esquerda, acima, à direita e abaixo de X, quando houver, conforme
//exemplo.

using System;

namespace Exercicio_teste_fixacao {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual será o tamanho da matriz? ");
            string[] tamanho = Console.ReadLine().Split(" ");
            Console.WriteLine();
            int n = int.Parse(tamanho[0]);
            int m = int.Parse(tamanho[1]);

            int[,] mat = new int[n, m];
            Console.WriteLine("Digite os valores da matriz:");
            for (int linha = 0; linha < n; linha++) {

                string[] values = Console.ReadLine().Split(" ");

                for (int coluna = 0; coluna < m; coluna++) {
                    mat[linha, coluna] = int.Parse(values[coluna]);
                }
            }

            Console.Write("Digite um número da matriz: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int linha = 0; linha < n; linha++) {

                for (int coluna = 0; coluna < m; coluna++) {
                    if (mat[linha, coluna] == x) {
                        Console.WriteLine("Position: " + linha + ", " + coluna + ":");

                        if (coluna > 0) {
                            Console.WriteLine("Left: " + mat[linha, coluna - 1]);
                        }
                        if (linha > 0) {
                            Console.WriteLine("Up: " + mat[linha - 1, coluna]);
                        }
                        if (coluna < n) {
                            Console.WriteLine("Right: " + mat[linha, coluna + 1]);
                        }
                        if (linha < m) {
                            Console.WriteLine("Down: " + mat[linha + 1, coluna]);
                        }
                    }
                }
            }



        }
    }
}
