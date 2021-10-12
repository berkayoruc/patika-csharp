using System;

namespace inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Beslenme");
        }
        protected void Solunum()
        {
            Console.WriteLine("Solunum");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Bosaltim");
        }

        public virtual void Tepki()
        {
        }

    }
}