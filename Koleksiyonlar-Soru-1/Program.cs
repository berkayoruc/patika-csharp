using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList notAsal = new ArrayList();
            int asalSum = 0;
            int notAsalSum = 0;
            for (int i = 0; i < 20; i++)
            {
                int number;
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out number);
                if (success && int.Parse(input) > 0)
                {
                    int kontrol = 0;
                    for (int k = 2; k < number; k++)
                    {
                        if (number % i == 0)
                        {
                            kontrol++;
                        }
                    }
                    if (kontrol != 0)
                    {
                        notAsal.Add(number);
                        notAsalSum += number;
                    }
                    else
                    {
                        asal.Add(number);
                        asalSum += number;
                    }
                }
            }
            asal.Sort();
            notAsal.Sort();
            foreach (var item in asal)
            {
                Console.WriteLine(item);
            }
            foreach (var item in notAsal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(asal.Count);
            Console.WriteLine(notAsal.Count);
            Console.WriteLine(asalSum / asal.Count);
            Console.WriteLine(notAsalSum / notAsal.Count);
        }
    }
}
