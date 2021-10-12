using System;

namespace inheritance
{
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("adaptasyon");
        }

        public override void Tepki()
        {
            base.Tepki();
            Console.WriteLine("Tepki");
        }
    }

    public class Surungen : Hayvanlar
    {
        public void Surunerek()
        {
            Console.WriteLine("surunerek");
        }
    }
    public class Kus : Hayvanlar
    {
        public void Ucarak()
        {
            Console.WriteLine("Ucarak");
        }
    }
}