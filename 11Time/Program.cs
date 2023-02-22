using System;
using System.Globalization;

namespace _11Time
{
    class Program
    {
        static void Main(string[] args)
        {

            // NO TIME IRMÃO
            // DateTime representa um instante
            // TimeSpan representa uma duração na forma de ticks (100 nanosegundos)

            DateTime d1 = new DateTime(2023, 02, 22);
            DateTime d2 = new DateTime(2023, 02, 22, 20, 45, 3);
            DateTime d3 = new DateTime(2023, 02, 22, 20, 45, 3, 500);

            DateTime d4 = DateTime.Now;     // Pega o DateTime atual do sistema
            DateTime d5 = DateTime.Today;   // Pega o dia atual
            DateTime d6 = DateTime.UtcNow;  // Horário universal (GMT)

            DateTime d7 = DateTime.Parse("2000-03-18");
            DateTime d8 = DateTime.Parse("2000-03-18 14:05:58");
            DateTime d9 = DateTime.Parse("18/03/2000");
            DateTime d10 = DateTime.Parse("18/03/2000 14:05:58");

            DateTime d11 = DateTime.ParseExact("2000-03-18", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("18/03/2000 14:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(0, 1, 30);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            //TimeSpan t6 = new TimeSpan.FromDays(1.5);         => TimeSpan.From não está sendo reconhecido pelo VS

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);

            Console.WriteLine();

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t3.Ticks);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
        }
    }
}
