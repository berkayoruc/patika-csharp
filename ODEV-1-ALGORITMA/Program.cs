using System;

namespace ODEV_1_ALGORITMA
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Soru
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            try
            {
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi % 2 == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 2. Soru
            Console.WriteLine("Lütfen iki sayı giriniz: ");
            try
            {
                int sayi1 = int.Parse(Console.ReadLine());
                int sayi2 = int.Parse(Console.ReadLine());
                for (int i = 0; i < sayi1; i++)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi2 == sayi || sayi % sayi2 == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 3. Soru
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            try
            {
                int count = int.Parse(Console.ReadLine());
                string[] array = new string[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Lütfen bir yazı yazınız: ");
                    string input = Console.ReadLine();
                    array[i] = input;
                }
                Array.Reverse(array);
                foreach (string item in array)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // 4. Soru
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            try
            {
                string sentence = Console.ReadLine();
                Console.WriteLine("Kelime sayısı: " + sentence.Split(" ").Length);
                Console.WriteLine("Harf sayısı: " + sentence.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
