using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_split
{
    class Complex
    {
        public int a, b;
        public Complex (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex first, Complex second)
        {
            if (first.b == second.b)
            {
                Complex sum1 = new Complex(first.a + second.a, first.b);
                return sum1;
            }
            else
            {
                Complex sum = new Complex(first.a * second.b + first.b * second.a, first.b * second.b);
                return sum;
            }
        }
        
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string F = Console.ReadLine();
            string[] first = S.Split('/');
            string[] second = F.Split('/');
            Complex summa = new Complex(int.Parse(first[0]), int.Parse(first[1]));
            Complex summaa = new Complex(int.Parse(second[0]), int.Parse(second[1]));
            Complex answer = summa + summaa;
            Console.WriteLine(answer);
            Console.ReadKey();

        }
    }
}
