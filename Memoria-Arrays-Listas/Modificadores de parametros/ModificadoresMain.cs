using Modificares_de_parametros;
using System;


namespace Modificadores {
    class Program {
        static void Main(string[] args) {

            int result = Calculator.sum(1, 2, 3, 4 );
            Console.WriteLine(result);

            int a = 10;
            Calculator.triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int _double;
            Calculator.duplicate(b, out _double);
            Console.WriteLine(_double);
        }
    }
}
