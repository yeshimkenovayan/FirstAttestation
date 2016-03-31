using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_student
{
    class Student
    {
        public string name;
        public string surname;
        public double gpa;
        public string ID;

        public Student (string name, string surname, double gpa, string ID)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
            this.ID = ID;
        }

       
       
        public override string ToString()
        {
            return name + " " + surname + " " + gpa + " " + ID;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            Student a = new Student("Ayan", "Yeshimkenov", 4.0, "15BD01");
            Student b = new Student("Artur", "Abdalimov", 4.0,"15BD02" );
            Student c = new Student("Muratbek", "Bulganbaev", 4.0, "15BD03");
            students[0] = a;
            students[1] = b;
            students[2] = c;
            string token;
            bool check=false; 
            while (check!=true)
            {
                Console.WriteLine("Choose one of this operation: ");
                Console.WriteLine("a) show all students");
                Console.WriteLine("b) show GPA of all students");
                Console.WriteLine("c) search information about student");
                Console.WriteLine("d) exit");
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.A)
                {
                    for (int i = 0; i < 3; i++)
                        Console.WriteLine(students[i]);
                }
                else if (button.Key == ConsoleKey.B)
                {
                    for (int i = 0; i < 3; i++)
                        Console.WriteLine("Student name: {0} GPA: {1}", students[i].name,students[i].gpa);
                }
                else if (button.Key == ConsoleKey.C)
                {
                    Console.WriteLine("write his or her name: ");
                    token = Console.ReadLine();
                    int k = 0;
                    for (int i = 0; i < students.Length; i++)
                    {
                        if(token == students[i].name)
                        {
                            Console.WriteLine(students[i]);
                            k = 1;
                            break;
                        }
                        
                        

                    }

                    if (k != 1)
                    {
                        Console.WriteLine("Not found");
                    }


                }
                else if(button.Key == ConsoleKey.D)
                {
                    check = true;
                }
                
            }
                      
            Console.ReadKey();
        }
    }
}
