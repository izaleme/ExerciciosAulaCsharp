using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaWhile
{
    class Program
    {

        /* // EXERCICIO 1 - URI 1114

        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Inválida. Tente novamente.");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        } */


        /* // EXERCICIO 2 - URI 1115

        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int px = int.Parse(entrada[0]);
            int py = int.Parse(entrada[1]);

            while (px != 0 || py != 0) {
                if (px > 0 && py > 0) {
                    Console.WriteLine("Primeiro quadrante (Q1)");
                }
                else if (px < 0 && py > 0) {
                    Console.WriteLine("Segundo quadrante (Q2)");
                }
                else if (px < 0 && py < 0) {
                    Console.WriteLine("Terceiro quadrante (Q3)");
                }
                else {
                    Console.WriteLine("Quarto quadrante (Q4)");
                }

                entrada = Console.ReadLine().Split(' ');
                px = int.Parse(entrada[0]);
                py = int.Parse(entrada[1]);
            }
        } */


        /* // EXERCICIO 3 - URI 1134

        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de gasolina:");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Sair \n");
            Console.Write("Escolha: ");

            int tipoCombustivel = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (tipoCombustivel != 4) {
                if (tipoCombustivel == 1) {
                    alcool++;
                }
                else if (tipoCombustivel == 2) {
                    gasolina++;
                }
                else if (tipoCombustivel == 3) {
                    diesel++;
                }
                Console.Write("Escolha: ");
                tipoCombustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMUITO OBRIGADO!!! \n");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        } */

    }
}
