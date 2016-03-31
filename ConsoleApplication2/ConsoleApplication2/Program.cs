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
            Console.Write("input"); // выводим на экран слово "инпут"
            a = int.Parse(Console.ReadLine()); // вводим нужный нам начальный предел
            Console.Write("input"); //
            b = int.Parse(Console.ReadLine()); // вводим нужный нам конечный предел
            for (long i= a; i <= b; i++) // создаем цикл, начинающийся от "а" до "б"
            {
                int cnt = 0; // создаем счетчик
                for (long j=2; j<= i; j++) // создаем второй цикл, для того чтобы проверить делится ли данное число на более два числа
                {
                    if (i%j==0) // создаем условие (если число делится на другое число без остатка)
                    {
                        cnt++; // то начинаем счет
                    }
                        
                }
                if (cnt == 1) // если количество делимых чисел равно 1
                {
                    Console.Write(i); // то выводим это делимое число
                    Console.Write(" "); // делаем пробел между чисел
                }
            }
            
            Console.ReadKey(); //команда необходимая для того чтобы программа сразу не закрывалась
        }
    }
}
