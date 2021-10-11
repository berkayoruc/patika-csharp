﻿using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // public => her yerden erişilebilir
            // private => tanımlandığı sınıf içerisinde
            // internal => kendi proje içerisinde
            // protected => tanımlandığı sınıfta veya inherit sınıflarında

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "asd";
            calisan1.Soyad = "asdw";
            calisan1.No = 22313;
            calisan1.Departman = "asddffw";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "weq";
            calisan2.Soyad = "rterw";
            calisan2.No = 45689;
            calisan2.Departman = "oaopsd";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışan adı: {0}", Ad);
            Console.WriteLine("Calışan soyadı: {0}", Soyad);
            Console.WriteLine("Calışan no: {0}", No);
            Console.WriteLine("Calışan departman: {0}", Departman);
        }
    }
}
