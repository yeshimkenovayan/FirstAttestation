using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Complex
    {
        // a/b
        public int a, b;
        public Complex(int a, int b);
        this.a = a;
        this.b = b;
    }

    public ovveride string ToString()
    {
        return a + "/" + b;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
