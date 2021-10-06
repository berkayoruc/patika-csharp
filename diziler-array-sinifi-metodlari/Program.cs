using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 23, 12, 43, 23, 45, 67 };
            foreach (var item in sayilar)
            {

                Console.WriteLine(item);
            }
            Array.Sort(sayilar);
            foreach (var item in sayilar)
            {

                Console.WriteLine(item);
            }
            Array.Clear(sayilar, 4, 2);
            foreach (var item in sayilar)
            {

                Console.WriteLine(item);
            }
            Array.Reverse(sayilar);
            foreach (var item in sayilar)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine(Array.IndexOf(sayilar, 23));
            Array.Resize<int>(ref sayilar, 11);
            foreach (var item in sayilar)
            {

                Console.WriteLine(item);
            }

        }
    }
}
