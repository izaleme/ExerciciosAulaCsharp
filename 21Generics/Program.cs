using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();     // Definindo que o valor genérico será int

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());      // lê o valor passado
                printService.AddValue(x);   // adiciona o valor na lista
            }

            printService.Print();   // imprime os elementos
            Console.WriteLine("First: " + printService.First());
        }
    }
}