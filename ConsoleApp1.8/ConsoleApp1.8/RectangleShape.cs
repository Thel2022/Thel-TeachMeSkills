﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    internal class RectangleShape : Shape
    {
        public RectangleShape (string name, int size, char symbol, int x, int y) : base(name, size, symbol, x, y)
        {

        }
        public override void PrintShape(string name, int size, char symbol, int x, int y)
        {
            for (int i = 0; i <= size; i++)
            {
                Console.SetCursorPosition(x, y);
                y++;
                for (int j = 0; j <= size; j++)
                {
                    if (i == 0 || i == size || j == 0 || j == size)
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
        }
    }
}
