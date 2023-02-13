using System;
using System.Globalization;

namespace EstruturaCondicional
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }


        /* // EXERCÍCIO 1

        static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
                Console.WriteLine("Número positivo");
            else
                Console.WriteLine("Número negativo");

        } */


        /* // EXERCÍCIO 2

        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)   // Números pares são divisíveis por 2 e retornam 0
            {
                Console.WriteLine("Número Par");
            }
            else
            {
                Console.WriteLine("Número Ímpar");
            }

        } */


        /* // EXERCÍCIO 3 - URI 1044

        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int intA = int.Parse(valores[0]);
            int intB = int.Parse(valores[1]);

            if(intA % intB == 0 || intB % intA == 0)
                Console.WriteLine("A e B são múltiplos entre si.");
            else
                Console.WriteLine("A e B não são múltiplos entre si.");
        } */


        /*// EXERCÍCIO 4 - URI 1046

        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(horas[0]);
            int horaTermino = int.Parse(horas[1]);

            int duracaoJogo = 0;

            if (horaInicio < horaTermino)
            {
                duracaoJogo = horaTermino - horaInicio;
            }
            else
            {
                duracaoJogo = 24 - horaInicio + horaTermino;
            }

            Console.WriteLine("O jogo durou " + duracaoJogo + " hora(s).");
        } */


        /* // EXERCÍCIO 5 - URI 1038

        static void Main(string[] args)
        {

            Console.Write("Digite o código e a quantidade do produto: ");

            string[] valores = Console.ReadLine().Split(' ');
            int codItem = int.Parse(valores[0]);
            int qntdeItem = int.Parse(valores[1]);
            double precoItem = 0.0;
            double totalConta = 0.0;
            bool erro = false;

            if(codItem == 1) {
                precoItem = 4.0;
            } else if(codItem == 2) {
                precoItem = 4.5;
            } else if(codItem == 3) {
                precoItem = 5.0;
            } else if(codItem == 4) {
                precoItem = 2.0;
            } else if(codItem == 5) {
                precoItem = 1.5;
            } else {
                erro = true;
            }

            if(erro == true)
            {
                Console.WriteLine("Erro: Código não cadastrado!");
            }
            else
            {
                totalConta = precoItem * qntdeItem;
                Console.WriteLine("Total: R$" + totalConta.ToString("F2", CultureInfo.InvariantCulture));
            }
            
        } */


        /* // EXERCÍCIO 6 - URI 1037

        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }
        } */


        /* // EXERCÍCIO 7 - URI 1041

        static void Main(string[] args)
        {

            string[] v = Console.ReadLine().Split(' ');
            double x = double.Parse(v[0], CultureInfo.InvariantCulture);
            double y = double.Parse(v[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            } else if (x == 0 && y != 0) {
                Console.WriteLine("Eixo y");
            } else if (y == 0 && x != 0) {
                Console.WriteLine("Eixo x");
            } else if (x > 0 & y > 0) {
                Console.WriteLine("Q1");
            } else if (y > 0 && x < 0) {
                Console.WriteLine("Q2");
            } else if (y < 0 && x < 0) {
                Console.WriteLine("Q3");
            } else {
                Console.WriteLine("Q4");
            }

        } */


        /* // EXERCÍCIO 8 - URI 1051

        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double IR = 0.0;

            if (salario <= 2000.0) {
                IR = 0.0;
            }
            else if (salario <= 3000.0) {
                IR = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                IR = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                IR = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (IR == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + IR.ToString("F2", CultureInfo.InvariantCulture));
            }
        } */

    }
}
