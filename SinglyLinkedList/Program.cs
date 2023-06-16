using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Implementation!!!\n");

            //--Using System.Collection.Gernerics to create linked list

            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.AddLast(56);
            //linkedList.AddLast(30);
            //linkedList.AddLast(70);

            //foreach(int item in linkedList)
            //{
            //    Console.WriteLine("| "+item+" |");
            //}

            //LinkedList list = new LinkedList();

            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.Display();

            LinkedList list = new LinkedList();
            list.AddCreatedFirstStoreLast(70);
            list.AddCreatedFirstStoreLast(30);
            list.AddCreatedFirstStoreLast(56);
            list.Display();

        }
    }
}