using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Implementation!!!\n");

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            
            foreach(int item in linkedList)
            {
                Console.WriteLine("| "+item+" |");
            }

        }
    }
}