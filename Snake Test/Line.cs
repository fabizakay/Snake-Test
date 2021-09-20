using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Test
{
    class Line : BaseShape
    {
        public Line(Point leftTop, char theChar) : base(leftTop, theChar)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            int rndmesh = new Random().Next(1, 10);

            for (int i = 0; i <= rndmesh; i++)
            {
                    Console.Write(theChar+" ");
            }
        }

        public override void PrintShape()
        {
            
        }
    }
}
