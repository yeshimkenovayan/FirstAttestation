using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMinPrime();
            
        }

        public static void OutputInFile(int answer)
        {
            FileStream ff = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(ff);
            sw.WriteLine(answer);
            sw.Close();
            ff.Close();
            Console.ReadKey();
        }

        public static void FindMinPrime()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string t = sr.ReadToEnd();
            Console.WriteLine(t);
            string[] nums = t.Split(' ');
            int ppp = 0, answer = 0;
            int[] array = new int[nums.Length];
            for(int i=0; i<nums.Length;i++)
            {
                array[i] = int.Parse(nums[i]);
            }
                        
            for (int i = 0; i < array.Length - 1 ; i++)
            {
                if (array[i] > array[i + 1])
                {
                    ppp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = ppp;
                        
                }
                    
            }
            
            for( int i=0;i<array.Length;i++)
            {
                
                int cnt = 0;
                for (int j = 1; j <= array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        cnt++;
                    }

                }
                if (cnt <= 2)
                {
                    answer = array[i];
                    break;
                }
            }
            OutputInFile(answer);
            sr.Close();
            fs.Close();
            
        }
    }
}
