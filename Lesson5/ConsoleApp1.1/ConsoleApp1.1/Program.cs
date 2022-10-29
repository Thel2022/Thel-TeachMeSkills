using System;

namespace ConsoleApp1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Greetingsstep1();
            Greetingsstep2(name);
            Variations();
            Reverse();
            Farewell(name);

        }
        static string Greetingsstep1()
        {
            Console.Write("Enter your name, stranger: ");
            string name = Console.ReadLine();
            return name;
        }
        static void Greetingsstep2(string name)
        {
            Console.WriteLine($"Hello, {name}! Choose your own way and tremble before the unstoppable might of zeros and ones!");
        }
        static void Variations()

        {
            Console.WriteLine("Press 1 for addition\nPress 2 for subtraction\nPress 3 for multiplication\nPress 4 for division\nPress 5 for percent\nPress 6 for square root");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Division();
                    break;
                case "5":
                    Percent();
                    break;
                case "6":
                    Squareroot();
                    break;
                default:
                    Console.WriteLine("Wrong answer!");
                    break;
            }
        }
        static void Addition()
        {
            Console.Write("Enter first number:");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double res1 = (a2 + a3);
            Console.WriteLine($"Your result is: {a2} + {a3} =  {res1}");
            return;
        }
        static void Subtraction()
        {
            Console.Write("Enter first number:");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            double b3 = Convert.ToDouble(Console.ReadLine());
            double res2 = (b2 - b3);
            Console.WriteLine($"Your result is: {b2} - {b3} =  {res2}");
            return;
        }
        static void Multiplication()
        {
            Console.Write("Enter first number:");
            double c2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            double c3 = Convert.ToDouble(Console.ReadLine());
            double res3 = (c2 * c3);
            Console.WriteLine($"Your result is: {c2} * {c3} =  {res3}");
            return;
        }
        static void Division()
        {
            Console.Write("Enter first number:");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            double d3 = Convert.ToDouble(Console.ReadLine());
            double res4 = (d2 / d3);
            Console.WriteLine($"Your result is: {d2} / {d3} =  {res4}");
            return;
        }
        static void Percent()
        {
            Console.Write("Enter your number:");
            double f2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter percent (without zeros):");
            double f3 = Convert.ToDouble(Console.ReadLine());
            double res5 = ((f2 * f3) / 100);
            Console.WriteLine($"Your result is: {f3} percents of {f2} is: {res5}");
            return;
        }
        static void Squareroot()
        {
            Console.Write("Enter your number:");
            double g2 = Convert.ToDouble(Console.ReadLine());
            double res6 = Math.Sqrt(g2);
            Console.WriteLine($"Square rootof {g2} is: {res6}");
            return;
        }
        static void Reverse()
        {
            Console.WriteLine("Do you want to continue (yes/no)?");
            string choice2 = Console.ReadLine();
            while (choice2 == "yes")
            {
                Variations();
                Reverse();
                break;
            }
           }
        static void Farewell(string name)
        {
            Console.WriteLine($"Goodbye {name}! Blessing of Bill Gates upon you!");
        }



    }
}
