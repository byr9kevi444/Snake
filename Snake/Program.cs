using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            // малюю рамку
            HorizontalLine hrLineUp = new HorizontalLine ( 0, 118, 0, '+');
            HorizontalLine hrLineDown = new HorizontalLine ( 0, 118, 28, '+');
            VerticalLine vrLineLeft = new VerticalLine ( 0, 0, 28, '+');   
            VerticalLine vrLineRight = new VerticalLine(118, 0, 28, '+');

            hrLineUp.Drow();
            hrLineDown.Drow();
            vrLineLeft.Drow();
            vrLineRight.Drow();
             
            // малюю точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(116, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            
            while(true)
            {
                if (snake.Eat (food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
            



        }
       
    }
}
