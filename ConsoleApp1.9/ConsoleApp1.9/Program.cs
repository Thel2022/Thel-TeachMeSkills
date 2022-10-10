using System;

namespace ConsoleApp1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> linkedlist = new MyLinkedList<string>();
            linkedlist.Add("Name");
            linkedlist.Add("Age");
            linkedlist.Add("Sex");
            linkedlist.Add("Profession");

            Console.WriteLine("List output");

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }

            Console.Write("Enter the index of the list item to be removed:");

            int index = Convert.ToInt32(Console.ReadLine());

            linkedlist.RemoveAt(index);

            Console.WriteLine("List output in reverse order (subject to changes):");

            foreach (var t in linkedlist.BackEnumerator())
            {
                Console.WriteLine(t);
            }

            Console.Write("Enter the index of the list item to be added:");

            int index1 = Convert.ToInt32(Console.ReadLine());

            linkedlist.InsertAt("Experience", index1);

            Console.WriteLine("List output (subject to changes):");

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }

        }
    }
}
