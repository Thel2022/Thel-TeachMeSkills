using System;

namespace ConsoleApp1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Greetingsstep1();
            Greetingsstep2(name);
            Variations(name);
            Reverse(name);


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
        static void Variations(string name)

        {
            Console.WriteLine("Press 1 for addition\nPress 2 for subtraction\nPress 3 for multiplication\nPress 4 for division\nPress 5 for percent\nPress 6 for square root\nAnd, finally, if you really want it, press 7 for expressions");
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
                case "7":
                    FreeExpressionTest1(name);
                    break;
                default:
                    Console.WriteLine("Wrong answer!");
                    break;
            }
        }
        static void Addition()
        {
            try
            {
                Console.Write("Enter first number:");
                double a2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number:");
                double a3 = Convert.ToDouble(Console.ReadLine());
                double res1 = (a2 + a3);
                Console.WriteLine($"Your result is: {a2} + {a3} =  {res1}");
            }
            catch
            {
                Console.WriteLine("Something is wrong! If you working with fractions, try replacing '.' with ','");
            }
            
            return;
        }
        static void Subtraction()
        {
            try
            {
                Console.Write("Enter first number:");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number:");
                double b3 = Convert.ToDouble(Console.ReadLine());
                double res2 = (b2 - b3);
                Console.WriteLine($"Your result is: {b2} - {b3} =  {res2}");
            }
            catch
            {
                Console.WriteLine("Something is wrong! If you working with fractions, try replacing '.' with ','");
            }

            return;
        }
        static void Multiplication()
        {
            try
            {
                Console.Write("Enter first number:");
                double c2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number:");
                double c3 = Convert.ToDouble(Console.ReadLine());
                double res3 = (c2 * c3);
                Console.WriteLine($"Your result is: {c2} * {c3} =  {res3}");
            }
            catch
            {
                Console.WriteLine("Something is wrong! If you working with fractions, try replacing '.' with ','");
            }
            return;
        }
        static void Division()
        {
            try
            {
                Console.Write("Enter first number:");
                double d2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number:");
                double d3 = Convert.ToDouble(Console.ReadLine());
                double res4 = (d2 / d3);
                Console.WriteLine($"Your result is: {d2} / {d3} =  {res4}");
            }
            catch
            {
                Console.WriteLine("Something is wrong! If you working with fractions, try replacing '.' with ','");
            }
            return;
        }
        static void Percent()
        {
            try
            {
                Console.Write("Enter your number:");
                double f2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter percent (without zeros):");
                double f3 = Convert.ToDouble(Console.ReadLine());
                double res5 = ((f2 * f3) / 100);
                Console.WriteLine($"Your result is: {f3} percents of {f2} is: {res5}");
            }
            
            catch
            {
                Console.WriteLine("Something is wrong! If you working with fractions, try replacing '.' with ','");
            }
            return;
        }
        static void Squareroot()
        {
            try
            {
                Console.Write("Enter your number:");
                double g2 = Convert.ToDouble(Console.ReadLine());
                double res6 = Math.Sqrt(g2);
                Console.WriteLine($"Square rootof {g2} is: {res6}");
            }
            catch
            {
                Console.WriteLine("Something is wrong! If you working with fractions, try replacing '.' with ','");
            }
            return;
        }
        static void FreeExpressionTest1(string name)
        {
            try
            {
                Console.WriteLine("Press 1 for addition\nPress 2 for subtraction\nPress 3 for multiplication\nPress 4 for division");
                string choiceFE = Console.ReadLine();
                switch (choiceFE)
                {
                    case "1":
                        FreeExpressionAdd(name);
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Something is wrong!");
            }
        }
        static void FreeExpressionAdd(string name)
        {
            try
            {
                Console.Write($"Enter your formula, {name} (like 'x + y'): ");
                string formula1 = Console.ReadLine();
                char[] symbols = { '+', '-', '*', '/' };
                string[] numbers = formula1.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                decimal res1 = 0;
                foreach (var n in numbers)
                {
                    decimal nn = Convert.ToDecimal(n);

                    res1 += nn;
                }
                Console.WriteLine($"Your result is: {res1}");
            }
            
            catch
            {
                Console.WriteLine("Something is wrong! If you working with fractions, try replacing '.' with ','");
            }
        }
        static void Reverse(string name)
        {

                Console.WriteLine("Do you want to continue (yes/no)?");
                string choice2 = Console.ReadLine();
                if (choice2 == "yes")
                {
                    Variations(name);
                    Reverse(name);

                }
                else if (choice2 == "no")
                {
                    Farewell(name);
                }
                else
                {
                 Console.WriteLine("Something is wrong! Try again!");
                 Reverse(name);
                }
           
        }
        static void Farewell(string name)
        {
            Console.WriteLine($"Goodbye {name}! Blessing of Bill Gates upon you!");
        }



    }
}
