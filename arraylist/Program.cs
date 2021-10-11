using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("as");
            liste.Add(34);
            // liste.Add(true);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Add Range *****");
            // string[] renkler = { "kirmizi", "sari", "yesil" };
            List<int> sayilar = new List<int>() { 2, 3, 42, 3, 4, 53 };
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // liste.Sort(); // runtime error, type olarak farklı değişkenler olduğu için
            Console.WriteLine(liste.BinarySearch(42));

            liste.Reverse();

            liste.Clear();

        }
    }
}
