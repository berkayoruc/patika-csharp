using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donustipi metot_adi(parametrelistesi)
            // {
            //      komutlar
            // }

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(Topla(a, b));

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(Topla(a, b)));
            ornek.EkranaYazdir(ornek.ArttirVeTopla(ref a, ref b).ToString());
        }

        static int Topla(int x, int y)
        {
            return (x + y);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        // Orijinal değerler üzerinden işlem yapılır
        // İlgili parametreler globalde değişir
        public int ArttirVeTopla(ref int x, ref int y)
        {
            x += 1;
            y += 1;
            return x + y;
        }
    }
}
