﻿using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
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
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(40));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            Console.WriteLine(Math.Abs(-1));
            Console.WriteLine(Math.Sin(45));
            Console.WriteLine(Math.Cos(45));
            Console.WriteLine(Math.Tan(45));
            Console.WriteLine(Math.Ceiling(10.54)); // yukarı
            Console.WriteLine(Math.Round(10.44)); // virgülden sonraya bakar
            Console.WriteLine(Math.Floor(10.54)); // aşağıya
            Console.WriteLine(Math.Min(2, 5));
            Console.WriteLine(Math.Max(2, 5));
            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Sqrt(3));
            Console.WriteLine(Math.Log(3, 4));
            Console.WriteLine(Math.Log(3)); // e tabanında
            Console.WriteLine(Math.Exp(3)); // e üzeri
            Console.WriteLine(Math.Log10(4));
        }
    }
}
