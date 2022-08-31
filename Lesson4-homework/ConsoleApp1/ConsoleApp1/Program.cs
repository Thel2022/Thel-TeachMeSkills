using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name, stranger: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Choose your own way and tremble before the unstoppable might of zeros and ones!");
        Link1:
            Console.WriteLine("Press 1 for addition\nPress 2 for subtraction\nPress 3 for multiplication\nPress 4 for division\nPress 5 for percent\nPress 6 for square root");

            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter first number:");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number:");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    int res1 = (a2 + a3);
                    Console.WriteLine($"Your result is: {a2} + {a3} =  {res1}");
                    goto Link2;
                    break;
                case "2":
                    Console.Write("Enter first number:");
                    int b2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number:");
                    int b3 = Convert.ToInt32(Console.ReadLine());
                    int res2 = (b2 - b3);
                    Console.WriteLine($"Your result is: {b2} - {b3} =  {res2}");
                    goto Link2;
                    break;
                case "3":
                    Console.Write("Enter first number:");
                    int c2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number:");
                    int c3 = Convert.ToInt32(Console.ReadLine());
                    int res3 = (c2 * c3);
                    Console.WriteLine($"Your result is: {c2} * {c3} =  {res3}");
                    goto Link2;
                    break;
                case "4":
                    Console.Write("Enter first number:");
                    int d2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number:");
                    int d3 = Convert.ToInt32(Console.ReadLine());
                    int res4 = (d2 / d3);
                    Console.WriteLine($"Your result is: {d2} / {d3} =  {res4}");
                    goto Link2;
                    break;
                case "5":
                    Console.Write("Enter your number:");
                    int f2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter percent (without zeros):");
                    int f3 = Convert.ToInt32(Console.ReadLine());
                    int res5 = ((f2 * f3)/100);
                    Console.WriteLine($"Your result is: {f3} percents of {f2} is: {res5}");
                    goto Link2;
                    break;
                case "6":
                    Console.Write("Enter your number:");
                    double g2 = Convert.ToDouble(Console.ReadLine());
                    double res6 = Math.Sqrt(g2);
                    Console.WriteLine($"Square rootof {g2} is: {res6}");
                    goto Link2;
                    break;
                default:
                    Console.WriteLine("Wrong answer!");
                    break;
            }

            Console.WriteLine("Do you want to continue (yes/no)?");
            string choice2 = Console.ReadLine();
            bool newop1 = choice2 == "yes";
            
            if (newop1)
            {
                goto Link1;

            }
            else
                Console.WriteLine($"Goodbye {name}! Blessing of Bill Gates upon you!");

            Link2:
            Console.WriteLine("Do you want to continue (yes/no)?");
            string choice3 = Console.ReadLine();
            bool newop2 = choice3 == "yes";
            if (newop2)
            {
                goto Link1;

            }
            else
                Console.WriteLine($"Goodbye {name}! Blessing of Bill Gates upon you!");






        }






    }
}

