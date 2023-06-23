using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    internal class LinkedList
    {
        public Node Head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.Data);
        }

        public void Display()
        {
            Node temp = this.Head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
            }
        }

        public Node InserAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.Next = this.Head;
                Head = newNode;
            }
            else
            {
                Node temp = this.Head;
                while (position-- != 0 && temp != null)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.Next = temp.Next;
                        temp.Next = node;
                        break;
                    }
                    temp = temp.Next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            return Head;
        }

    }
}
