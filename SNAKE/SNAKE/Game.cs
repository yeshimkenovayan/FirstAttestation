using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SNAKE
{
    public class Game
    {
        public static Food food = new Food();
        public static Wall wall = new Wall();
        public static Snake snake = new Snake();
        public static bool GameOver=false;
        public static int score = 0;
        public enum Direction { up, down, left, right};
        public static Direction direction;
        


        public Game()
        {
            Timer t1 = new Timer(MoveSnake);
            t1.Change(0, 100);
            while (!GameOver)
            {
                
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                    direction = Direction.up;
                if (button.Key == ConsoleKey.DownArrow)
                    direction = Direction.down;
                if (button.Key == ConsoleKey.LeftArrow)
                    direction = Direction.left;
                if (button.Key == ConsoleKey.RightArrow)
                    direction = Direction.right;
                if (button.Key == ConsoleKey.F2)
                    Save();
                if (button.Key == ConsoleKey.F1)
                    Resume();
                if (snake.CheckCollisionWithWall())
                    GameOver = true;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Game Over");
            Console.ReadKey();
            Console.SetWindowSize(48, 48);
        }

        public static void MoveSnake (object state)
        {
            while (snake.CheckCollisionWithWall())
            {
                GameOver = true;
            } 
                switch (direction)
                {
                    case Direction.up:
                        Game.snake.Move(0, -1);
                        break;
                    case Direction.down:
                        Game.snake.Move(0, 1);
                        break;
                    case Direction.left:
                        Game.snake.Move(-1, 0);
                        break;
                    case Direction.right:
                        Game.snake.Move(1, 0);
                        break;
                }
            Game.snake.Draw();
            Game.wall.Draw();
            Game.food.Draw();
            Console.SetCursorPosition(1, 46);
            Console.WriteLine("Score: " + Game.score);
            Console.SetCursorPosition(1, 47);
            Console.WriteLine("Level:" + Game.wall.levelup);
        }
        
        public static void Draw()
        {
            if (Game.snake.body.Count % 5 == 0 || Game.snake.body.Count == 1) {
                wall.Draw();
            }
            snake.Draw();
            food.Draw();
            
        }

        public void Save()
        {
            snake.Save();
            food.Save();
            wall.Save();
        }

        public void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }
    }
}
