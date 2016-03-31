using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class Snake : Drawer
    {
        public Snake()
        {
            color = ConsoleColor.White;
            sign = '■';
            body.Add(new Point(10, 10));

        }
        
        public void Move(int dx, int dy)
        {
            if (sign == '■')
            {
                Point last = body[body.Count - 1];
                Console.SetCursorPosition(last.x, last.y);
                Console.Write(" ");    
            }
                
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y)
            {
                Game.score++;
                body.Add(new Point(0, 0));
                Game.food.SetNewPosition();
            }
            if (Game.score > 4)
            {
                Console.Clear();
                Game.wall.body.Clear();
                Game.score = 0;

                int levelup = Game.wall.levelup + 1;
                Game.wall.levelup++;
                Game.wall.setlevel(levelup++);
            }
            while (CheckCollisionWithFood() || CheckCollisionWithSnake())
            {
                Game.food.body.Clear();
                Game.food.SetNewPosition();
            }


        }

        public bool CheckCollisionWithWall()

        {
            foreach (Point p in Game.wall.body)
                if (p.x == Game.snake.body[0].x && p.y == Game.snake.body[0].y)
                    return true;
            return false;
        }
        public bool CheckCollisionWithFood()
        {
            foreach (Point p in Game.wall.body)
                if (p.x == Game.food.body[0].x && p.y == Game.food.body[0].y)
                    return true;
            return false;
        }
        public bool CheckCollisionWithSnake()
        {
            foreach (Point p in Game.snake.body)
                if (p.x == Game.food.body[0].x && p.y == Game.food.body[0].y)
                    return true;
            return false;
        }
        /*public bool EatSnake()
        {
            for (int i = 1; i < Game.snake.body.Count; i++)
            {
                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    return true;
                return false;
            }
        }*/
    }
}

