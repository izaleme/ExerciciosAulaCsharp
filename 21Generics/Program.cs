using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintServiceString printService = new PrintServiceString();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                String x = Console.ReadLine();      // lê o valor passado
                printService.AddValue(x);   // adiciona o valor na lista
            }

            printService.Print();   // imprime os elementos
            Console.WriteLine("First: " + printService.First());
        }
    }
}
