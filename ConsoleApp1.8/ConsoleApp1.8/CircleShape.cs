using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    [Color(ConsoleColor.Magenta)]
    internal class CircleShape : Shape, IPrintable
    {
        public CircleShape(string name, int size, char symbol, int x, int y):base(name, size, symbol, x, y)
        {

        }
        public override void Print(string name, int size, char symbol, int x, int y)
        {
            while (size <= 0) ;
            double thickness = 0.4;
            Console.WriteLine();
            double rIn = size - thickness, rOut = size + thickness;

            for (double y1 = size; y1 >= -size; --y1)
            {
                Console.SetCursorPosition(x, y);
                y++;
                for (double x1 = -size; x1 < rOut; x1 += 0.5)
                {
                    double value = x1 * x1 + y1 * y1;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
