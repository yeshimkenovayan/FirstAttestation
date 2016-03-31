using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Snake
{
    public class Food : Drawer 
    {
        public Food()
        {
            color = ConsoleColor.Yellow;
            sign = '@';
            SetNewPosition();
        }
        public void SetNewPosition()
        {
            int x = (new Random().Next()) % 30;
            int y = (new Random().Next()) % 30;
            if (body.Count == 0)
                body.Add(new Point(x, y));
            else
            {
                body[0].x = x;
                body[0].y = y;
            }
        }

        
    }
}
