using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("berkay", "oruc", 123, 12);
            Student student1 = new Student("berkay", "oruc", 1, 1);
            student.StudentInfo();
            student.ClassIncrement();
            student.StudentInfo();
            student.ClassDecrement();
            student.StudentInfo();
            student1.ClassDecrement();
            student1.StudentInfo();
        }
    }

    class Student
    {
        private string name;

        private string lastname;

        private int no;

        private int classs;

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int No { get => no; set => no = value; }
        public int Classs
        {
            get => classs; set
            {
                if (value < 1)
                {
                    Console.WriteLine("hoop kardeşim nereye");
                    classs = 1;
                }
                else
                {

                    classs = value;
                }
            }
        }

        public Student(string name, string lastname, int no, int classs)
        {
            this.name = name;
            this.lastname = lastname;
            this.no = no;
            this.classs = classs;
        }

        public Student() { }

        public void StudentInfo()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Lastname: {0}", this.Lastname);
            Console.WriteLine("No: {0}", this.No);
            Console.WriteLine("Class: {0}", this.Classs);
        }

        public void ClassIncrement()
        {
            this.Classs += 1;
        }
        public void ClassDecrement()
        {
            this.Classs -= 1;
        }

    }
}
