using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();      // lê o valor passado
                printService.AddValue(x);   // adiciona o valor na lista
            }

            int a = (int)printService.First();
            int b = a + 2;
            Console.WriteLine(b);   // forçando um erro de type safety (código não aponta erro por estar usando object)

            printService.Print();   // imprime os elementos
            Console.WriteLine("First: " + printService.First());
        }
    }
}
