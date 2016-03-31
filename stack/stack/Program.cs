using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace stake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Search(@"C:\Program Files");
        }
        static void Search(string path)
        {
            Stack<string> stack = new Stack<string>();
            Console.WriteLine(path + ":" + Directory.GetFiles(path).Length);
            stack.Push(path);

            while (stack.Count > 0)
            {
                string pyt = stack.Pop();
                
                string[] potok = Directory.GetDirectories(pyt);  
                foreach (string str in potok)
                {
                    Console.WriteLine(str + ":" + Directory.GetFiles(str).Length);
                    stack.Push(str);
                }
            }
            Console.ReadKey();
        }

    }
}