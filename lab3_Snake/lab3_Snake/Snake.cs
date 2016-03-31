﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Snake
{
    public class Snake : Drawer
    {
        public Snake()
        {
            color = ConsoleColor.DarkRed;
            sign = 'o';
            body.Add(new Point(10, 10));
        }

        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i>0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y)
            {
                body.Add(new Point(0, 0));
                Game.food.SetNewPosition();
            }
        }

        public bool CheckCollisionWithWall()
         {
             foreach (Point p in Game.wall.body)
                 if (p.x == body[0].x && p.y == body[0].y)
                     return true;
             return false;
         }
        
}
}
