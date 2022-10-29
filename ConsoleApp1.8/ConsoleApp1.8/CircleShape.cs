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
        public override void Print()
        {
            while (Size <= 0) ;
            double thickness = 0.4;
            Console.WriteLine();
            double rIn = Size - thickness, rOut = Size + thickness;

            for (double y1 = Size; y1 >= -Size; --y1)
            {
                Console.SetCursorPosition(X, Y);
                Y++;
                for (double x1 = -Size; x1 < rOut; x1 += 0.5)
                {
                    double value = x1 * x1 + y1 * y1;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(Symbol);
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
