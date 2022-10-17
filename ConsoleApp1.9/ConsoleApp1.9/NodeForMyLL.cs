using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._9
{
    public class NodeForMyLL<T>
    {
        public T Item { get; set; }
        public NodeForMyLL(T item)
        {
            Item = item;
        }
        public NodeForMyLL<T> Next { get; set; }
        public NodeForMyLL<T> Previous { get; set; }
    }
}
