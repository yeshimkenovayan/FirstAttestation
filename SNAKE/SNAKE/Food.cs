using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Red;
            sign = '@';
            SetNewPosition();
        }

        public void SetNewPosition()
        {
            int x = (new Random().Next(0, 44));
            int y = (new Random().Next(0, 44));
            if (body.Count == 0)
            {
                body.Add(new Point(x, y));
            }
            else
            {
                body[0].x = x;
                body[0].y = y;
            }
        }

       


    }
}
