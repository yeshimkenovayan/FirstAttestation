using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Snake
{
    public class Wall : Drawer
    {
        public Wall()
        {
            color = ConsoleColor.Green;
            sign = '*';
            SetLevel(1);
        }

        public void SetLevel(int Level)
        {
            string FileName = string.Format(@"C:\Users\Ayan\yeshimkenovayan\lab3_Snake\lab3_Snake\bin\Debug\levels\level{0}.txt", Level);
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string map = sr.ReadLine();
            string[] rows = map.Split('\n');
            body.Clear();

            for (int i = 0; i < rows.Length; i++)
                for (int j = 0; j < rows[i].Length; i++)
                    if (rows[i][j] == '*')
                        body.Add(new Point(j, i));
            sr.Close();
            fs.Close(); 
        }

       
    }
}
