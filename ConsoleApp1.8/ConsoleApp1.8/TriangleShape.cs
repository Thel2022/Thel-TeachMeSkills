using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    internal class TriangleShape : Shape
    {
        public TriangleShape()
        {

        }
        public override void PrintShape()
        {
            var printer = new Printer();
            int size = printer.EnterSize();
            char symbol = printer.EnterSymbol();
            int x = printer.EnterX();
            int y = printer.EnterY();
            for (var i = 1; i <= size; i++)
            {
                Console.SetCursorPosition(x, y);
                y++;
                for (var j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == size)
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
            Console.ReadLine();
        }
    }
}
