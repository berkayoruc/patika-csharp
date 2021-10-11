using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            int biggestSum = 0;
            int smallestSum = 0;
            for (int i = 0; i < 20; i++)
            {
                int number;
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out number);
                if (success)
                {
                    liste.Add(number);
                }
            }
            liste.Sort();
            smallestSum += Convert.ToInt32(liste[0]);
            smallestSum += Convert.ToInt32(liste[1]);
            smallestSum += Convert.ToInt32(liste[2]);
            Console.WriteLine(smallestSum / 3);
            liste.Reverse();
            biggestSum += Convert.ToInt32(liste[0]);
            biggestSum += Convert.ToInt32(liste[1]);
            biggestSum += Convert.ToInt32(liste[2]);
            Console.WriteLine(biggestSum / 3);
            Console.WriteLine((biggestSum / 3) + (smallestSum / 3));


        }
    }
}
