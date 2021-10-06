using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "maymun" };

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("Eleman sayısı");
            int length = int.Parse(Console.ReadLine());
            int[] diziler = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı girin", i + 1);
                diziler[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(diziler);



        }
    }
}
