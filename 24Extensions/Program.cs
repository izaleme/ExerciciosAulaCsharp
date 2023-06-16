using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 05, 16, 10, 52, 45);    // Mostra o tempo passado desde a data (no caso 2023/05/16 = 30 dias atrás)
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));      // Corta 10 caracteres da string
        }
    }
}
