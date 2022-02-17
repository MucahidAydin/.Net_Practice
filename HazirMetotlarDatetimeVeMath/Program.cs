using System;

namespace HazirMetotlarDatetimeVeMath
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(7));
            Console.WriteLine(DateTime.Now.AddHours(1));
            Console.WriteLine(DateTime.Now.AddMilliseconds(20));
            Console.WriteLine(DateTime.Now.AddMinutes(47));
            Console.WriteLine(DateTime.Now.AddMonths(7));
            Console.WriteLine(DateTime.Now.AddSeconds(2));
            Console.WriteLine(DateTime.Now.AddYears(10));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));   //17
            Console.WriteLine(DateTime.Now.ToString("ddd"));  //Thu
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Thursday

            Console.WriteLine(DateTime.Now.ToString("MM"));   //02
            Console.WriteLine(DateTime.Now.ToString("MMM"));  //Feb
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //February

            Console.WriteLine(DateTime.Now.ToString("yy"));   //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); //23            
            Console.WriteLine(Math.Floor(22.7));   //22

            Console.WriteLine(Math.Round(22.8));   //23
            Console.WriteLine(Math.Round(22.3));   //22

            Console.WriteLine(Math.Pow(4, 2)); //4^2
            Console.WriteLine(Math.Sqrt(16)); //karakök alır 4

            Console.WriteLine(Math.Log(9)); //9 un e tabanındaki logaritmik karşılığını getirir.
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(100));


            Console.ReadKey();
        }
    }
}