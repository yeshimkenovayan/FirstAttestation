using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class Wall : Drawer

    {
        public int levelup = 1;
        public Wall()
        {
            color = ConsoleColor.Yellow;
            sign = '#';
            setlevel(1);
        }

        public void setlevel (int level)
        {
            Console.Clear();
            string filename = string.Format(@"level\level {0}.txt", level);
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string map = sr.ReadToEnd();
            string[] rows = map.Split('\n');
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    if (rows[i][j] == '#')
                    {
                        body.Add(new Point(j, i));
                    }
                }
            }
            sr.Close();
            fs.Close();
        }
    }
}
