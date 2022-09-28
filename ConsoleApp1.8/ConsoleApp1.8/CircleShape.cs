using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    internal class CircleShape : Shape
    {
        public CircleShape()
        {

        }
        public override void PrintShape()
        {
            Console.WriteLine("Enter size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbol:");
            char symbol = char.Parse(Console.ReadLine());
            ConsoleColor BorderColor = ConsoleColor.Blue;
            Console.ForegroundColor = BorderColor;
            while (size <= 0) ;
            double thickness = 0.4;
            Console.WriteLine();
            double rIn = size - thickness, rOut = size + thickness;

            for (double y = size; y >= -size; --y)
            {
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
