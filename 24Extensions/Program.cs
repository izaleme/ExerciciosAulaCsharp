using System;
using Extensions.Extensions;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 05, 16, 8, 10, 45);    // 30 dias atrás
            Console.WriteLine(dt.ElapsedTime());


        }
    }
}
