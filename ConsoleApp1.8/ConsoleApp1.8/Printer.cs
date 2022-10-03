using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    public class Printer : IPrinter
    {
       public Printer()
        {

        }

       public void MenuAndPrint()
        {
            string name = ShapeSelection();
            if (name == "text")
            {
                int x1 = EnterX();
                int y1 = EnterY();
                int size1 = 1;
                char symbol1 = '+';
                Console.Clear();
                var text = new Text(name, x1, y1);
                text.Print(name, size1, symbol1, x1, y1);
                Console.SetCursorPosition(0, 0);
                Reverse();
            }

            int size = EnterSize();
            char symbol = EnterSymbol();
            int x = EnterX();
            int y = EnterY();
            Console.Clear();
            var shape = ShapeCreator(name, size, symbol, x, y);
            Type tp = shape.GetType();
            object[] attr = tp.GetCustomAttributes(false);
            foreach (object o in attr)
            {
                if (o is ColorAttribute colorAttribute)

                {

                    Console.ForegroundColor = colorAttribute.ObjectColor;

                }
            }
            shape.Print(name, size, symbol, x, y);
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
            Reverse();
        }
       public string ShapeSelection()
        {
            Console.WriteLine("Choose a shape:\n1 for triangule\n2 for rectangule\n3 for circle\n4 for text");
            int choice = Convert.ToInt32(Console.ReadLine());
            string name;
            if (choice == 1)
            {
                name = "triangule";
                return name;
            }
            else if (choice == 2)
            {
                name = "rectangule";
                return name;
            }
            else if (choice == 3)
            {
                name = "circle";
                return name;
            }
            else if (choice == 4)
            {
                name = "text";
                return name;
            }
            else name = "errr";
            return name;
        }   
       public int EnterSize()
        {
            Console.Write("Enter Size:");
            int size = int.Parse(Console.ReadLine());
            return size;
        }
       public char EnterSymbol()
        {
            try
            {
                Console.Write("Enter symbol:");
                char symbol = char.Parse(Console.ReadLine());
                return symbol;
            }
            catch
            {
                Console.WriteLine("Something is wrong! Default symbol is '*'");
                return '*';
            }
        }
       public int EnterX()
        {
            Console.Write("Enter coordinate X:");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
       public int EnterY()
        {
            Console.Write("Enter coordinate Y:");
            int y = int.Parse(Console.ReadLine());
            return y;
        }
       public void Reverse()
        {
            Console.WriteLine("Do you want to continue (yes/no)?");
            string choice2 = Console.ReadLine();
            if (choice2 == "yes")
            {
                MenuAndPrint();
            }
            else if (choice2 == "no")
            {
                Environment.Exit(0);
            }
        }
       public Shape ShapeCreator(string name, int size, char symbol, int x, int y)
        {

            object shape1 = new object();

            if (name == "triangule")
            {
                var shape = new TriangleShape(name, size, symbol, x, y);
                return shape;
            }
            else if (name == "rectangule")
            {
                var shape = new RectangleShape(name, size, symbol, x, y);
                return shape;
            }
            else if (name == "circle")
            {
                var shape = new CircleShape(name, size, symbol, x, y);
                return shape;
            }
            else
                return (Shape)shape1;


        }


    }
}
