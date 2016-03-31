using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Read();   

        }

        public static void Create()
         {
             FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             StreamWriter sw = new StreamWriter(fs);
             sw.WriteLine("1 55 4 3 6 8 42 5 53 59" );
             sw.Close();
             fs.Close();
         }

    public static void Read()
        {
            FileStream ff = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader ss = new StreamReader(ff);

            string t = ss.ReadToEnd();
            Console.WriteLine(t);
            string[] nums = t.Split();
            int max = Convert.ToInt32(nums[0]);
            int min = Convert.ToInt32(nums[0]);
            for (int i = 0; i < nums.Length; i++)
            {
               
                if (Convert.ToInt32(nums[i]) > max)
                {
                    max = Convert.ToInt32(nums[i]);
                }
                if (Convert.ToInt32(nums[i])<min)
                {
                    min = Convert.ToInt32(nums[i]);
                } 

            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0} ", max);
            ss.Close();
            ff.Close();
            Console.ReadKey();
        }
    }
}
