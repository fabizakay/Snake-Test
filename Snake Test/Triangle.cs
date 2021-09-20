using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Test
{
    class Triangle :BaseShape
    {
        

        public Triangle(Point leftTop, char theChar) : base(leftTop, theChar)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            int rndmesh = new Random().Next(2, 9);

            for (int i = 0; i <= rndmesh; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(theChar);

                }
                Console.WriteLine(" ");

            }
        }

        public char V { get; }

        public override void PrintShape()
        {

        }
    }
}
