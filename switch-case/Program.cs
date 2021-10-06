using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 8:
                    Console.WriteLine("Temmuz");
                    break;
                case 9:
                    Console.WriteLine("Ağustos");
                    break;
                case 10:
                    Console.WriteLine("AAA");
                    break;
                default:
                    Console.WriteLine("Hello");
                    break;
            }
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("SS");
                    break;
                case 11:
                    Console.WriteLine("AAA");
                    break;
                case 12:
                    Console.WriteLine("AAA");
                    break;
                default:
                    Console.WriteLine("Hello");
                    break;
            }
        }
    }
}
