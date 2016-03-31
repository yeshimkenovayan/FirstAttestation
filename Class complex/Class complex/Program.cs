using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_complex
{
    class Complex
    {
        public int a, b;
       
        public Complex(int _a, int _b)
        {
            this.a = _a; 
            this.b = _b;
        }
        public static Complex operator +(Complex first, Complex second )
        {
            if(first.b == second.b)
            {
                Complex sum = new Complex(first.a + second.a, first.b);
                return sum;
            }

           
                Complex sum1 = new Complex(first.a * second.b + first.b * second.a, first.b * second.b);
                return sum1;
            
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
           
            string[] t = Console.ReadLine().Split('/');
            string[] m = Console.ReadLine().Split('/');
            

            Complex first = new Complex(Convert.ToInt32(m[0]), Convert.ToInt32(m[1]));
            Complex second = new Complex(Convert.ToInt32(t[0]) , Convert.ToInt32(t[1]));
            Complex Result = first + second;
            Console.WriteLine(Result);
            Console.ReadKey();
            
        }
    }
}
