using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();

            sayilar.Add(0);
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            List<string> renkler = new List<string>();

            renkler.Add("0");
            renkler.Add("1");
            renkler.Add("2");
            renkler.Add("3");

            Console.WriteLine(sayilar.Count);
            Console.WriteLine(renkler.Count);

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renkler)
            {
                Console.WriteLine(item);
            }

            sayilar.ForEach(item => Console.WriteLine(item));
            renkler.ForEach(item => Console.WriteLine(item));

            sayilar.Remove(2);
            renkler.Remove("0");
            renkler.RemoveAt(0);

            Console.WriteLine(sayilar.Contains(78));
            Console.WriteLine(renkler.BinarySearch("2"));
            Console.WriteLine(sayilar.Contains(78));

            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvList = new List<string>(hayvanlar);
            hayvList.Clear();

            List<Kullanicilar> kullanicilar = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "asd";
            kullanici1.Lastname = "asd";
            kullanici1.Yas = 12;
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "assssd";
            kullanici2.Lastname = "asdddddd";
            kullanici2.Yas = 24;
            kullanicilar.Add(kullanici1);
            kullanicilar.Add(kullanici2);

            List<Kullanicilar> yenii = new List<Kullanicilar>();
            yenii.Add(new Kullanicilar()
            {
                Isim = "dsd",
                Lastname = "dd",
                Yas = 233
            });
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Lastname);
                Console.WriteLine(item.Yas);
            }
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string lastname;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
