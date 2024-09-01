using System;



namespace Nullables {

    class Program {

        static void Main(string[] args) {

            //Nullables podem ser escritos assim:
            Nullable<int> v1 = null;
            //Ou assim
            int? v2 = null;
            //Para indicar que os structs podem ser nulos


            //Métodos com nullables:

            //GetValueOrDefault - Pega o valor existente, em caso de nulo, o valor padrão
            int? x = null;
            int? y = 10;
            Console.WriteLine(x.GetValueOrDefault());// 0
            Console.WriteLine(y.GetValueOrDefault());// 10

            //HasValue - Retorna True se tiver valor e False se for nulo
            Console.WriteLine(x.HasValue);//False
            Console.WriteLine(y.HasValue);//True

            //Value - Retorna o valor de algo (se for nulo, quebra o programa)
            //Para não quebrar, implementei uma lógica que ajuda a fazer um método seguro

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else {
                Console.WriteLine("X is null!");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y is null!");
            }

            //Operador de coalescência nula

            int? n1 = null;
            int n2 = n1 ?? 4;
            //É uma forma de dizer: se n1 tiver valor, n2 recebe o valor dele, se não, recebe 4
            Console.WriteLine(n2);
        }

    }
}
