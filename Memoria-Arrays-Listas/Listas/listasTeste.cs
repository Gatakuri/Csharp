using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace listas {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Paulo");
            list.Add("Pedrin");
            list.Add("Anabele");
            list.Insert(1, "Ana");
            Console.WriteLine(list);

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Para achar um primeiro ou ultimo elemento que retorne true
            //ao predicado
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo 'A': " + s2);
            Console.WriteLine();

            //Para achar o primeiro ou ultimo index que retorne true ao predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Index primeiro 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Index ultimo 'A': " + pos2);
            Console.WriteLine();

            //Retornar uma lista com base em um filtro com base em um predicado
            List<string> list2 = list.FindAll(x => x.Length >= 5);
            Console.WriteLine("Nome com 5 ou mais letras: ");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Remover elementos da lista
            Console.WriteLine(list.Find(x => x == "Pedrin") + " Vai ser removido da lista:");
            list.Remove("Pedrin");
            foreach (string obj in list) {

                Console.WriteLine(obj);
            }

            Console.WriteLine();

            Console.WriteLine("Vão ser removidos da lista todos que começam com 'P': ");
            list.RemoveAll(x => x[0] == 'P');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            Console.WriteLine("O nome na posção 0 vai ser removido: ");
            list.RemoveAt(0);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            Console.WriteLine("Lista renovada");
            list.Add("Paulo");
            list.Add("Pedrin");
            list.Insert(1, "Ana");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            Console.WriteLine("A partir da posição 1, vão ser removidos 2 itens");

            list.RemoveRange(1, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }





        }
    }
}
