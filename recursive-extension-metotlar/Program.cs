using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3, 4));
            string ifade = "berkay oruç";
            Console.WriteLine(ifade.CheckSpaces());
            Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
    }
}
