using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3; 
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 3;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            bool isSuccess = true;
            bool isCompleted = false;
            
            if (isSuccess && isCompleted) {
                Console.WriteLine("selam");
            }
            if (isSuccess || isCompleted) {
                Console.WriteLine("merhaba");
            }
            if (isSuccess || !isCompleted) {
                Console.WriteLine("hmm");
            }
        }
    }
}
