using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "merhaba nasılsın iyi misin";
            string sentence1 = "ooo burdaymışsın";
            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(String.Concat(sentence, " lala"));
            Console.WriteLine(sentence.CompareTo(sentence1)); // 0, 1, -1
            Console.WriteLine(String.Compare(sentence, sentence1, true)); // true büyük küçük harf duyarsız
            Console.WriteLine(String.Compare(sentence, sentence1, false));
            Console.WriteLine(sentence.Contains(sentence1));
            Console.WriteLine(sentence.EndsWith("misin"));
            Console.WriteLine(sentence1.StartsWith("oooo"));
            Console.WriteLine(sentence.IndexOf("i"));
            Console.WriteLine(sentence.Insert(12, sentence1));
            Console.WriteLine(sentence.LastIndexOf("a"));
            Console.WriteLine(sentence.PadLeft(40));
            Console.WriteLine(sentence.PadRight(75, '#'));
            Console.WriteLine(sentence.Remove(5));
            Console.WriteLine(sentence.Remove(5, 10));
            Console.WriteLine(sentence.Remove(0, 1));
            Console.WriteLine(sentence.Replace(" ", "/"));
            Console.WriteLine(sentence.Split(" ")[3]);
            Console.WriteLine(sentence.Substring(4, 6));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
