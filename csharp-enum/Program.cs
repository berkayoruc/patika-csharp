using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Cuma);
            Console.WriteLine((int)Gunler.Cuma);

            int temp = 32;

            if (temp <= (int)Temperature.Normal)
            {
                Console.WriteLine("aaaaaaaa");
            } else {
                Console.WriteLine("vvvvvv");
            }
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe = 53,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum Temperature
    {
        Cold = 5,
        Normal = 20,
        Hot = 25

    }
}
