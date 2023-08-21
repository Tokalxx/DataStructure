using DataStructure.Lists.CustomLinkList;
using System;

namespace DataStructure.Lists
{
    internal class CustomeLinkedListcs
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.addToLast(8);
            myLinkedList.addToFirst(9);
            myLinkedList.addToLast(13);
            myLinkedList.addToLast(7);
            myLinkedList.addToFirst(11);

            myLinkedList.Display();

            Console.ReadKey();
        }
    }
}
