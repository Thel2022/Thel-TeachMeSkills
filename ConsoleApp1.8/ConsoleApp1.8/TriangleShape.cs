using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    [Color(ConsoleColor.Green)]
    internal class TriangleShape : Shape, IPrintable
    {
        public TriangleShape(string name, int size, char symbol, int x, int y):base(name, size, symbol, x, y)
        {

        }
        public override void Print(string name, int size, char symbol, int x, int y)
        {
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
