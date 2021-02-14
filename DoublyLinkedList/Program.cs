using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Stack;

namespace LinkedList
{
    class Program
    {
        public static DoublyLinkedList list = new DoublyLinkedList();
        public static ListStack stack = new ListStack();
        static void Main(string[] args)
        {
            //D_LinkedList();
            List_Stack();
        }

        static void D_LinkedList()
        {
            list.Append(10);
            list.Append(20);
            list.Append(30);
            list.Append(30);
            list.RemoveTail();

            DListIterator itr = list.GetIterator();
            for (itr.Start(); itr.Valid(); itr.Forth())
            {
                Console.WriteLine(itr.Item());
            }
            itr.Start();
            Console.ReadLine();
        }

        static void List_Stack()
        {
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            stack.Push(5);



            DListIterator itr = stack.GetIterator();
            for (itr.Start(); itr.Valid(); itr.Forth())
            {
                Console.WriteLine(itr.Item());
            }
            itr.Start();
            Console.ReadLine();
        }
        
    }
}
