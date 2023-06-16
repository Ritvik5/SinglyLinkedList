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

            //-- Add elements in linkedlist

            //LinkedList list = new LinkedList();

            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.Display();

            //LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.AddCreatedFirstStoreLast(70);
            //list.AddCreatedFirstStoreLast(30);
            //list.AddCreatedFirstStoreLast(56);
            //list.Display();

            //-- Add elements at certain position

            //LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(70);

            //list.Display();

            //list.InsertAtParticularPosition(2, 30);

            //Console.WriteLine("\n:::::::::::::::::::::::");

            //list.Display();

            //--Removing First Node

            //LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();

            //Console.WriteLine("\nAfter Deleting first node: \n");
            //list.RemoveFirstNode();
            //list.Display();

            //Console.WriteLine("\nAfter Deleting last node: \n");
            //list.RemoveLastNode();
            //list.Display();

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.SearchNode(30);

            list.InsertAtParticularPosition(3, 40);

            //list.Display();
            //Console.WriteLine();

            //list.RemoveAt(3);
            //list.Size();

            list.Sort();
            Console.WriteLine();
            list.Display();
        }
    }
}