 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 
 namespace ConsoleApplication2
 {
     class Complex
     {
         static void Main(string[] args)
         {
             int a, b;
             Console.Write("input");
             a = int.Parse(Console.ReadLine());
             Console.Write("input");
             b = int.Parse(Console.ReadLine());
             for (long i = a; i <= b; i++)
             {
                 int cnt = 0;
                 for (long j = 1; j<= i; j++)
                 {
                     if (i%j==0)
                     {
                         cnt++;
                     }
                         
                 }
                 if (cnt <= 2)
                 {
                     Console.Write(i);
                     Console.Write(" ");
                 }
             }
             
             Console.ReadKey();
         }
     }
 }