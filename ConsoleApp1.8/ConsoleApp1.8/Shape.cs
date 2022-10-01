using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    abstract class Shape
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(string name, int size, char symbol, int x, int y)
        {
            Name = name;
            Size = size;
            Symbol = symbol;
            X = x;
            Y = y;
        }

        public abstract void PrintShape(string name, int size, char symbol, int x, int y);
    }
    
   
}
