using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    internal class Text : IPrintable
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Text(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public void Print()
        {
            string content = Console.ReadLine();
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(content);
        }
    }
}
