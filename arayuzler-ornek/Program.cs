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
            NewFocus nfocus = new NewFocus();
            Console.WriteLine(nfocus.GetOwner().ToString());
            Console.WriteLine(nfocus.WheelCount().ToString());
            Console.WriteLine(nfocus.GetRenk().ToString());
            NewCivic ncivic = new NewCivic();
            Console.WriteLine(ncivic.GetOwner().ToString());
            Console.WriteLine(ncivic.WheelCount().ToString());
            Console.WriteLine(ncivic.GetRenk().ToString());
            NewCorolla ncorolla = new NewCorolla();
            Console.WriteLine(ncorolla.GetOwner().ToString());
            Console.WriteLine(ncorolla.WheelCount().ToString());
            Console.WriteLine(ncorolla.GetRenk().ToString());
        }
    }
}
