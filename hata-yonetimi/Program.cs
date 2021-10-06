using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Bir Sayı Giriniz!");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine(sayi);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem tamamlandı");
            // }
            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("lala");
                int a = int.Parse("1111111111111");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("veri tipi hatası");
                Console.WriteLine(ex);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("kapsam hatası");
                Console.WriteLine(ex);

            }

        }
    }
}
