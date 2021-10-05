using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // implict conversion
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);


            string e = "berkay";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine(g);


            // explicit conversion
            Console.WriteLine("explicit");

            int x = 4;
            byte y = (byte)x; // solundakine dönüştürmeye çalışır
            Console.WriteLine(y);

            Console.WriteLine(x.ToString());

            string s1 = "10", s2 = "20";

            Console.WriteLine(Convert.ToInt32(s1) + Convert.ToInt32(s2));
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double doublee;

            rakam1 = Int32.Parse(metin1);
            doublee = Double.Parse(metin2);
            Console.WriteLine(rakam1);
            Console.WriteLine(doublee);
        }
    }
}
