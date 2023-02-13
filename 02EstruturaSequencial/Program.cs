using System;
using System.Globalization;

namespace EstruturaSequencial
{
    class Program
    {

        // EXERCÍCIO 1 - URI 1003
        
        static void Main(string[] args)
        {
            
            // Q: Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa

            int a, b, soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = (a) + (b);

            Console.WriteLine("Soma: " + soma);
        }


        /*// EXERCÍCIO 2 - URI 1002

        static void Main(string[] args)
        {

            // Q: Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais

            double pi = 3.14159;
            double raio = 0;

            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2.0);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

        } */


        /*// EXERCÍCIO 3 - URI 1007

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);

            Console.WriteLine("Diferença: " + dif);

        } */


        /* // EXERCÍCIO 4 - URI 1008

        static void Main(string[] args)
        {

            int numFun = int.Parse(Console.ReadLine());
            int horasTrab = int.Parse(Console.ReadLine());
            double salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioTot = salarioHora * horasTrab;

            Console.WriteLine("Número Funcionário = " + numFun);
            Console.WriteLine("Salário = " + salarioTot.ToString("F2", CultureInfo.InvariantCulture));
        } */


        /* // EXERCÍCIO 5 - URI 1010

        static void Main(string[] args)
        {

            Console.WriteLine("Digite o código, a quantidade e o valor unitário do produto 1: ");
            string[] produto1 = Console.ReadLine().Split(' ');

            int codProd1 = int.Parse(produto1[0]);
            int qntdProd1 = int.Parse(produto1[1]);
            double valProd1 = double.Parse(produto1[2], CultureInfo.InvariantCulture);

            double totalPag1 = qntdProd1 * valProd1;


            Console.WriteLine("Digite o código, a quantidade e o valor unitário do produto 2: ");
            string[] produto2 = Console.ReadLine().Split(' ');

            int codProd2 = int.Parse(produto2[0]);
            int qntdProd2 = int.Parse(produto2[1]);
            double valProd2 = double.Parse(produto2[2], CultureInfo.InvariantCulture);

            double totalPag2 = qntdProd2 * valProd2;

            double totalPag = totalPag1 + totalPag2;

            Console.WriteLine("Valor a pagar: R$" + totalPag.ToString("F2", CultureInfo.InvariantCulture));

        } */


        /*// EXERCÍCIO 6 - URI 1012

        static void Main(string[] args)
        {
            double pi = 3.14159;

            string[] vetor = Console.ReadLine().Split(' ');

            double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = pi * Math.Pow(c, 2.0);
            double areaTrapezio = (c * (a + b)) / 2;
            double areaQuadrado = Math.Pow(b, 2.0);
            double areaRetangulo = a * b;

            Console.WriteLine("Área do Triângulo: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Círculo: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Trapézio: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Quadrado: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Retângulo: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        } */

    }
}
