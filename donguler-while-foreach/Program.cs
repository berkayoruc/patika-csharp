using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);
            string[] arabalar = { "bmw", "ford", "toyota", "nissan" };
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
