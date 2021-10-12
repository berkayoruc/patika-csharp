using System;

namespace inheritance
{
    public class Bitkiler : Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Fotosentez");
        }
        public override void Tepki()
        {
            base.Tepki();
            Console.WriteLine("Tepki sd");
        }
    }

    public class Tohumlu : Bitkiler
    {
        public Tohumlu()
        {
            base.Fotosentez();
            base.Tepki();
        }
        public void TohumluCogalma()
        {
            Console.WriteLine("Tohumm");
        }
    }
    public class Tohumsuz : Bitkiler
    {
        public Tohumsuz()
        {
            base.Fotosentez();
        }
        public void SporCogalma()
        {
            Console.WriteLine("Spor");
        }
    }
}