using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._9
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        NodeForMyLL<T> head;
        NodeForMyLL<T> tail;
        int count;
    

        public void Add (T item)
        {
            NodeForMyLL<T> node = new NodeForMyLL<T>(item);
            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
               
            tail = node;
            count++;
        }
        public void InsertAt (T item, int index)
        {
            NodeForMyLL<T> node = new NodeForMyLL<T>(item);
            NodeForMyLL<T> previous = head;
            NodeForMyLL<T> current = head.Next;
            int i = 0;

            if (index == 0)
            {
                node.Next = head;
                head = node;
                count++;
            }

            while (i < index && current != null)
            {
                node.Next = current;
                previous.Next = node;
                
                i++;
            }
            count++;
        }
        public NodeForMyLL<T> GetElementAt(int index)
        {

            if (index == 0)
            {
                return head;
            }
            var temp = head.Next;

            int count = 1;

            while (count!= index)

            {
                temp = temp.Next;
                count++;
            }
            return temp;


        }
        public bool Remove (T item)
        {
            NodeForMyLL<T> current = head;
            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
        public void RemoveAt (int index)
        {
            NodeForMyLL<T> current = head;
            int i = 0;
            while (i < index && current != null)
            {
                current = current.Next;
                i++;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
            }
            }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
  
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            NodeForMyLL<T> current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            NodeForMyLL<T> current = tail;
            while (current != null)
            {
                yield return current.Item;
                current = current.Previous;
            }
        }
             
    }
}
