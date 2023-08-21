﻿using System;


namespace DataStructure.Generics
{
    internal class MyLinkedListTester
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();

            myLinkedList.addToLast("Jee");
            myLinkedList.addToLast("Pee");
            myLinkedList.addToLast("Lee");
            myLinkedList.addToLast("Zee");

            foreach (string x in myLinkedList)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
