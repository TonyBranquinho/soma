using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y, soma;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine(), CI);

            soma = x + y;

            Console.WriteLine("Soma = " + soma, CI);
        }
    }
}
