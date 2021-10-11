using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

           kullanicilar.Add(0, "aaa");
           kullanicilar[34] = "llll";

           Console.WriteLine(kullanicilar[34]);

           foreach (var item in kullanicilar)
           {
               Console.WriteLine(item);
           }

           Console.WriteLine(kullanicilar.Count);
           Console.WriteLine(kullanicilar.ContainsKey(34));
           Console.WriteLine(kullanicilar.ContainsValue("aa"));

           kullanicilar.Remove(0);

           Console.WriteLine(kullanicilar.Keys);
           Console.WriteLine(kullanicilar.Values);
        }
    }
}
