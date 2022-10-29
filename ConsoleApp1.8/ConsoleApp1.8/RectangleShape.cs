using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    [Color(ConsoleColor.Red)]
    internal class RectangleShape : Shape, IPrintable
    {
        public RectangleShape (string name, int size, char symbol, int x, int y) : base(name, size, symbol, x, y)
        {

        }
        public override void Print()
        {
            for (int i = 0; i <= Size; i++)
            {
                Console.SetCursorPosition(X, Y);
                Y++;
                for (int j = 0; j <= Size; j++)
                {
                    if (i == 0 || i == Size || j == 0 || j == Size)
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
        }
    }
}
