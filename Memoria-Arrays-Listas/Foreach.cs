using System;

namespace Laco_foreach {
    class Program {
        static void Main(string[] args) {

            string[] nomes = { "Rafael", "Giovana", "Marcelo" };

            //SEM FOREACH:

            for (int i = 0; i < nomes.Length; i++) {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine("-------------------");

            //COM FOREACH:

            foreach (string obj in nomes) {
                Console.WriteLine(obj);
            }
        }
    }
}
