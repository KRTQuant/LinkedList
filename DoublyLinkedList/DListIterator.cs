using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DListIterator
    {
        public DoublyNodeList doublyNode;
        public DoublyLinkedList doublyList;

        public DListIterator(DoublyLinkedList list = null, DoublyNodeList node = null)
        {
            doublyList = list;
            doublyNode = node;
        }

        public void Start()
        {
            if (doublyNode != null)
            {
                doublyNode = doublyList.headNode;
            }
        }

        public void Forth()
        {
            if (doublyNode != null)
            {
                doublyNode = doublyNode.next;
            }
        }

        public int? Item() 
        { 
            return doublyNode.data; 
        }

        public bool Valid() 
        { 
            return doublyNode != null; 
        }

    }
}
