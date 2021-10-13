using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.GetOwner().ToString());
            Console.WriteLine(focus.WheelCount().ToString());
            Console.WriteLine(focus.GetColor().ToString());
            Civic civic = new Civic();
            Console.WriteLine(civic.GetOwner().ToString());
            Console.WriteLine(civic.WheelCount().ToString());
            Console.WriteLine(civic.GetColor().ToString());
            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.GetOwner().ToString());
            Console.WriteLine(corolla.WheelCount().ToString());
            Console.WriteLine(corolla.GetColor().ToString());
        }
    }
}
