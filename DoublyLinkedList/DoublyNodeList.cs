using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoublyNodeList
    {
        public int? data;
        public DoublyNodeList next;
        public DoublyNodeList prev;

        public DoublyNodeList()
        {
            data = 0;
            next = null;
            prev = null;
        }

        public DoublyNodeList(int? value)
        {
            data = value;
            next = null;
            prev = null;
        }

        public DoublyNodeList InsertAfter(int? value)
        {
            DoublyNodeList node = new DoublyNodeList(value);
            node.next = next; //next node of generated node = next's this node 

            if (next != null) //if there is node.next
            {
                next.prev = node; //prev node of next node = generated node
            }

            next = node; //next node of this node = generated node;
            node.prev = this; //prev node of generated node = this node

            return node;
        }

        public DoublyNodeList InsertBefore(int? value)
        {
            DoublyNodeList node = new DoublyNodeList(value);
            node.prev = prev;

            if(prev != null)
            {
                prev.next = node;
            }

            prev = node;
            node.next = this;

            return node;
        }
    }
}
