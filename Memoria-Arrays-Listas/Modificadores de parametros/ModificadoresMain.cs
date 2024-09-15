using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificares_de_parametros {
    internal class Calculator {

        public static int sum(params int[] numbers) {

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            return sum;
        }

        public static void triple(ref int x) {
            x *= 3;
        }

        public static void duplicate(int origin, out int result) {
            result = origin * 2;
        }

    }
}
