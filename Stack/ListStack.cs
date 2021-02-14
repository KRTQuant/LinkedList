using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Stack
{
    class ListStack : DoublyLinkedList
    {
        public void Push(int? value)
        {
            Append(value);
        }

        public void Pop()
        {
            RemoveTail();
        }

        public int? Top()
        {
            return tailNode.data;
        }

        public int Count()
        {
            return count;
        }
    }
}
