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

            DateTime d1 = new DateTime(2000, 03, 18);
            DateTime d2 = new DateTime(2000, 03, 18, 12, 10, 5);
            DateTime d3 = new DateTime(2000, 03, 18, 12, 10, 5, 500);

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

            Console.WriteLine("** DateTime **");

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
            Console.WriteLine("** TimeSpan **");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t3.Ticks);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine();
            Console.WriteLine("** Propriedades do DateTime **");

            Console.WriteLine("01) Date: " + d3.Date);
            Console.WriteLine("02) Day: " + d3.Day);
            Console.WriteLine("03) DayOfWeek: " + d3.DayOfWeek);
            Console.WriteLine("04) DayOfYear: " + d3.DayOfYear);
            Console.WriteLine("05) Hour: " + d3.Hour);
            Console.WriteLine("06) Kind: " + d3.Kind);
            Console.WriteLine("07) Millisecond: " + d3.Millisecond);
            Console.WriteLine("08) Minute: " + d3.Minute);
            Console.WriteLine("09) Month: " + d3.Month);
            Console.WriteLine("10) Second: " + d3.Second);
            Console.WriteLine("11) Ticks: " + d3.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d3.TimeOfDay);
            Console.WriteLine("13) Year: " + d3.Year);
            Console.WriteLine("14) ToLongDateString: " + d3.ToLongDateString());
            Console.WriteLine("15) ToLongTimeString: " + d3.ToLongTimeString());
            Console.WriteLine("16) ToShortDateString: " + d3.ToShortDateString());
            Console.WriteLine("17) ToShortTimeString: " + d3.ToShortTimeString());

            /*Console.WriteLine();
            Console.WriteLine("** Operações com DateTime **");

            DateTime x = new DateTime(2000, 03, 18);
            DateTime y = x.Add(TimeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);

            DateTime y = x.Subtract(TimeSpan);
            TimeSpan t = x.Subtract(DateTime); */

            Console.WriteLine();
            Console.WriteLine("** Propriedades e Operações com TimeSpan **");
            Console.WriteLine("test");

            Console.WriteLine();
        }
    }
}
