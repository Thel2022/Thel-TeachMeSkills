using System;

namespace ConsoleApp1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Table<int, int, int>[] mytable = new Table<int, int, int>[a];
            mytable[0] = new Table<int, int, int>(0, 1, 2);
            mytable[1] = new Table<int, int, int>(3, 4, 5);
            mytable[2] = new Table<int, int, int>(6, 7, 8);
            mytable[3] = new Table<int, int, int>(9, 10, 11);
            mytable[4] = new Table<int, int, int>(12, 13, 14);
            foreach (Table<int, int, int> i in mytable)
                Console.WriteLine("{0}\t{1}\t{2}", i.FirstColumnData, i.SecondColumnData, i.ThirdColumnData);
        }
    }
}
