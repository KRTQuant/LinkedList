using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoublyLinkedList
    {
        public DoublyNodeList headNode;
        public DoublyNodeList tailNode;
        public int count;

        public DoublyLinkedList()
        {
            DoublyNodeList itr = headNode;
            DoublyNodeList next;
            while(itr != null)
            {
                next = itr.next;
                itr = null;
                itr = next;
            }
        }

        public void Append(int? value)
        {
            if(headNode == null)
            {
                headNode = tailNode = new DoublyNodeList(value);
            }
            else
            {
                tailNode.InsertAfter(value);
                tailNode = tailNode.next;
            }
            count++;
        }

        public void Prepend(int? value)
        {
            if(tailNode == null)
            {
                tailNode = headNode = new DoublyNodeList(value);
            }
            else
            {
                headNode.InsertBefore(value);
                headNode = headNode.prev;
            }
            count++;
        }

        public void RemoveHead()
        {
            DoublyNodeList node = null;
            if(headNode != null)
            {
                node = headNode.next;
                headNode.data = null;
                headNode = node;
                if(headNode == null)
                {
                    tailNode = null;
                }
                count--;
            }
        }

        public void RemoveTail()
        {
            DoublyNodeList node = headNode;
            if(tailNode != null)
            {
                node = tailNode.prev;
                tailNode.data = null;
                tailNode = node;
                if(tailNode == null)
                {
                    headNode = null;
                }
            }
            count--;
        }

        public DListIterator GetIterator()
        {
            return new DListIterator(this, headNode);
        }

        public void Insert(DListIterator iterator, int? value)
        {
            if (iterator.doublyList != this)
            {
                return;
            }

            if(iterator.doublyNode != null)
            {
                iterator.doublyNode.InsertAfter(value);
                if(iterator.doublyNode == tailNode)
                {
                    tailNode = iterator.doublyNode.next;
                }
                count++;
            }
            else
            {
                Append(value);
            }
        }

        public void Remove(DListIterator iterator, DoublyNodeList node)
        {
            if (iterator.doublyList != this)
                return;

            if (iterator.doublyNode == null)
                return;

            if(iterator.doublyNode == headNode)
            {
                iterator.Forth();
                RemoveHead();
            }

            else
            {
                while (node.next != iterator.doublyNode)
                    node = node.next;

                iterator.Forth();

                if (node.next == tailNode)
                    tailNode = node;

                node.next = null;
                node.next = iterator.doublyNode;
            }
            count++; 
        }
    }
}
