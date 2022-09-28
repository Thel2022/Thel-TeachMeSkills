using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    public class Printer : IPrintable
    {
       public Printer()
        {

        }
  
       public void Menu()
        {
            Console.WriteLine("Choose a shape:\n1 for triangule\n2 for rectangule\n3 for circle");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    var trianguleShape = new TriangleShape();
                    trianguleShape.PrintShape();
                    break;
                case 2:
                    var rectangleShape = new RectangleShape();
                    rectangleShape.PrintShape();
                    break;
                case 3:
                    var circleShape = new CircleShape();
                    circleShape.PrintShape();
                    break;
            }

        }
       public int EnterSize()
        {
            Console.WriteLine("Enter Size:");
            int size = int.Parse(Console.ReadLine());
            return size;
        }
       public char EnterSymbol()
        {
            Console.WriteLine("Enter symbol:");
            char symbol = char.Parse(Console.ReadLine());
            return symbol;
        }
        public int EnterX()
        {
            Console.WriteLine("Enter coordinate X:");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        public int EnterY()
        {
            Console.WriteLine("Enter coordinate Y:");
            int y = int.Parse(Console.ReadLine());
            return y;
        }
    }
}
