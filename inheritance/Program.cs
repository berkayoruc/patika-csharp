using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Tohumlu tohum = new Tohumlu();
            tohum.TohumluCogalma();
            Tohumsuz tohumsuz = new Tohumsuz();
            tohumsuz.SporCogalma();
        }
    }
}
