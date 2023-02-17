using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaFor
{
    class Program
    {

        // EXERCÍCIO 1 - URI 1067

        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {           // Números ímpares
                    Console.WriteLine(i);
                }
            }

        }


        /* // EXERCÍCIO 2 - URI 1072

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    cont_in = cont_in + 1;
                }
                else {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

        } */


        /* // EXERCÍCIO 3 - URI 1079

        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) {

                Console.Write("Digite 3 valores: ");
                string[] v = Console.ReadLine().Split(' ');
                double x = double.Parse(v[0], CultureInfo.InvariantCulture);
                double y = double.Parse(v[1], CultureInfo.InvariantCulture);
                double z = double.Parse(v[2], CultureInfo.InvariantCulture);

                double media = (x * 2.0 + y * 3.0 + z * 5.0) / 10.0;

                Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));

            }

        } */


        /* // EXERCÍCIO 4 - URI 1116

        static void Main(string[] args)
        {

            Console.Write("Digite o valor de n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.Write("Digite dois valores: ");
                string[] val = Console.ReadLine().Split(' ');
                int x = int.Parse(val[0], CultureInfo.InvariantCulture);
                int y = int.Parse(val[1], CultureInfo.InvariantCulture);

                if (y == 0) {
                    Console.WriteLine("Divisão Impossível");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine("Resultado = " + div.ToString("F1", CultureInfo.InvariantCulture));
                }

            }

        } */


        /* // EXERCÍCIO 5 - URI 1153

        static void Main(string[] args)
        {

            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine("Fatorial: " + fat);

        } */


        /* // EXERCÍCIO 6 - URI 1157

        static void Main(string[] args)
        {

            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            int div = 0;

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
        } */


        /* // EXERCÍCIO 7 - URI 1143

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        } */

    }
}
