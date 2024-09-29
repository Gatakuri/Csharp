//Fazer um programa para ler um número inteiro N e uma matriz de
//ordem N contendo números inteiros. Em seguida, mostrar a diagonal
//principal e a quantidade de valores negativos da matriz.

using System;

namespace Exercicio_matrizes_teste {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual o tamanho da matriz?");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            Console.WriteLine("Escreva os valores da matriz:");
            for (int linha = 0; linha < n; linha++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int coluna = 0; coluna < n; coluna++) {

                    mat[linha, coluna] = int.Parse(values[coluna]);

                }

            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();
            int count = 0;
            for (int linha = 0; linha < n; linha++) {
                for (int coluna = 0; coluna < n; coluna++) {
                    if (mat[linha, coluna] < 0) {
                        count++;
                    }
                }
            }
            Console.Write("Números negativos: " + count);
        }
    }
}
