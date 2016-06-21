using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            // малюю рамку
            HorizontalLine hrLineUp = new HorizontalLine ( 0, 55, 0, '+');
            HorizontalLine hrLineDown = new HorizontalLine ( 0, 55, 15, '+');
            VerticalLine vrLineLeft = new VerticalLine ( 0, 0, 15, '+');   
            VerticalLine vrLineRight = new VerticalLine(55, 0, 15, '+');

            hrLineUp.Drow();
            hrLineDown.Drow();
            vrLineLeft.Drow();
            vrLineRight.Drow();
             
            // малюю точки
            Point p1 = new Point(3, 4, '*');
            p1.Draw(); 



            Console.ReadLine();
        }
       
    }
}
