using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;
            string System = "";

            Console.WriteLine(deger);

            byte b = 5;
            sbyte c = 5;
            short s = 5;
            ushort us = 5;
            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2;
            long l = 4;
            ulong ul = 4;
            float f = 5;
            double d = 5;
            decimal de = 5;

            char ch = '2'; //2byte
            string str = "berkay"; //infinite

            bool bt = true;
            bool bf = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "aaaa";
            string ad = "dddd";
            string soyad = "ffff";
            string all = ad + " " + soyad;
        }
    }
}
