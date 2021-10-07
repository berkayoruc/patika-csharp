using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999sdsdasd";
            // int outSayi;

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı" + outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar metotlar = new Metotlar();
            metotlar.Topla(2, 3, out int sonuc1);
            Console.WriteLine(sonuc1);

            // Overloading
            int ifade = 44;
            metotlar.EkranaYazdir(ifade);
            metotlar.EkranaYazdir(ifade, "asdsddd");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri, string veri2)
        {
            Console.WriteLine(veri + veri2);
        }
    }
}
