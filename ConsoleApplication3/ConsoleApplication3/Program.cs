using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student
    {
        // fields
        // methods
        // private, public, protected
        public string name;
        public string surname;
        public double gpa;
        public string ID;

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void print()
        {
            Console.WriteLine(this.name + " " + this.surname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.name = "Aslan";
            a.surname = "Mussin";
            a.gpa = 4.0;
            a.ID = "08FSQQ34";
            a.print();


            Student b = new Student();
            b.name = "abc";
            b.surname = "ttt";
            b.gpa = 
        }
    }
}
