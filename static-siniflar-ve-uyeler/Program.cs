using System;

namespace static_siniflar_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employer.EmpCount);
            Employer emp1 = new Employer("asd", "asd", "asd");
            Employer emp2 = new Employer("asd", "asd", "asd");
            Employer emp3 = new Employer("asd", "asd", "asd");
            Employer emp4 = new Employer("asd", "asd", "asd");

            Console.WriteLine(Operations.Sum(1,2));
            Console.WriteLine(Operations.Substract(10000,2231));
        }
    }

    class Employer
    {
        private static int empCount;

        public static int EmpCount { get => empCount; }

        private string name;
        private string lastname;
        private string department;

        static Employer()
        {
            empCount = 0;
        }

        public Employer(string department, string lastname, string name)
        {
            this.department = department;
            this.lastname = lastname;
            this.name = name;
            empCount++;
            Console.WriteLine(empCount);
        }
    }

    static class Operations
    {
        public static long Sum(int x, int y)
        {
            return x + y;
        }

        public static long Substract(int x, int y)
        {
            return x - y;
        }
    }
}
