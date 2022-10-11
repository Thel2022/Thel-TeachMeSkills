using System;

namespace ConsoleApp1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table<int, int, int> table = new Table<int, int, int>(1, 2, 3);
            Table<int, int, int> table1 = new Table<int, int, int>(4, 5, 6);

            Console.WriteLine(table.FirstColumnData);

        }
    }
}
