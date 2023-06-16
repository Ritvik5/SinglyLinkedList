using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;    // Node Type refrence variable temp is created and we store the head in it.
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void AddCreatedFirstStoreLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            Console.WriteLine("{0} inserted into the linked list\n", newNode.data);
        }

        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0 && temp != null)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }

                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        public Node RemoveFirstNode()
        {
            if (head == null)
                return null;
            head = head.next;
            return head;
        }

        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        public void SearchNode(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Given value: " + value + " is present in Linked list");
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
                Console.WriteLine("Given value: " + value + " is not present in Linked list");
        }

        public void RemoveAt(int position)
        {
            if (head == null)
            {
                return; 
            }

            if (position == 0)
            {
                head = head.next; 
                return;
            }

            Node temp = head;
            Node previous = null;
            int count = 0;

            while (temp != null && count < position)
            {
                previous = temp;
                temp = temp.next;
                count++;
            }

            if (temp == null)
            {
                return; 
            }

            previous.next = temp.next; 
        }

        public void Size()
        {
            int count = 0;
            Node temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            Console.WriteLine("The size of the list is: "+count);
        }

        public void Sort()
        {
            if (head == null || head.next == null)
            {
                Console.WriteLine("The LinkedList is empty");
            }

            Node temp = head;
            Node index = null;
            int temp1;

            while (temp != null)
            {
                index = temp.next;

                while (index != null)
                {
                    if (temp.data > index.data)
                    {
                        temp1 = temp.data;
                        temp.data = index.data;
                        index.data = temp1;
                    }

                    index = index.next;
                }
                temp = temp.next;
            }
        }
    }
}
