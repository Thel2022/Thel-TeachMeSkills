using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    internal class CircleShape : Shape
    {
        public CircleShape(string name, int size, int x, int y):base(name, size, x, y)
        {

        }
        public override void PrintShape()
        {
            var printer = new Printer();
            int size = printer.EnterSize();
            char symbol = printer.EnterSymbol();
            int x1 = printer.EnterX();
            int y1 = printer.EnterY();
            while (size <= 0) ;
            double thickness = 0.4;
            Console.WriteLine();
            double rIn = size - thickness, rOut = size + thickness;

            for (double y = size; y >= -size; --y)
            {
                Console.SetCursorPosition(x1, y1);
                y1++;
                for (double x = -size; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
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
