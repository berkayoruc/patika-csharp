using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            ArrayList harfler = new ArrayList();
            foreach (var item in sentence.ToLower().Split())
            {
                for (int i = 0; i < item.Length; i++) {
                    harfler.Add(item[i].ToString());
                }
            }
            ArrayList sesliHarfler = new ArrayList() { "a", "e", "ı", "i", "o", "ö", "u", "ü" };
            ArrayList sesliler = new ArrayList();
            foreach (var item in harfler)
            {
                if (sesliHarfler.Contains(item))
                {
                    sesliler.Add(item);
                }
            }
            sesliler.Sort();
            foreach (var item in sesliler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
