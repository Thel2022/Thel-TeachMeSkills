using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    internal class Text
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Text(string name, string content, int x, int y)
        {
            Name = name;
            Content = content;
            X = x;
            Y = y;
        }
        public void PrintText(string name, string content, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(content);
        }
    }
}
