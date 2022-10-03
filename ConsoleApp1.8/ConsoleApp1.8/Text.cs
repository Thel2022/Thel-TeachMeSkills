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
        public void Print(string name, int size, char symbol, int x, int y)
        {
            string content = Console.ReadLine();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(content);
        }
    }
}
