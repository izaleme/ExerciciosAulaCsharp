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
            // DateTimeKind define três valores possíveis para a localidade da data: local (fuso horário do sistema), UTC (fuso horário GMT) e Unspecified

            #region DateTime

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

            Console.WriteLine("**************");
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

            #endregion

            #region TimeSpan

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(0, 1, 30);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            TimeSpan t6 = TimeSpan.FromDays(1.5);

            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine("** TimeSpan **");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t3.Ticks);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine();
            Console.WriteLine("** Propriedades e Operações com TimeSpan **");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan ts1 = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts1.Add(ts2);
            TimeSpan sub = t1.Subtract(ts2);

            Console.WriteLine(t);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Subsract: " + sub);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("Total Days: " + t.TotalDays);
            Console.WriteLine("Total Hours: " + t.TotalHours);
            Console.WriteLine("Total Minutes: " + t.TotalMinutes);
            Console.WriteLine("Total Seconds: " + t.TotalSeconds);
            Console.WriteLine("Total Milliseconds: " + t.TotalMilliseconds);

            #endregion

            #region DateTimeKind

            // Para converter um DateTime para local ou UTC: myDate.ToLocalTime() ou myDate.ToUniversalTime()
            DateTime date1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime date2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime date3 = new DateTime(2000, 8, 15, 13, 5, 58);  // Unspecified

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine("** DateTimeKind **");
            Console.WriteLine("date1: " + date1);
            Console.WriteLine("date1 Kind: " + date1.Kind);
            Console.WriteLine("date1 to local: " + date1.ToLocalTime());
            Console.WriteLine("date1 to utc: " + date1.ToUniversalTime());

            #endregion
        }
    }
}
