using System;
using System.Collections.Generic;

namespace DataStructure.Lists
{
    internal class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Tokyo");
            list.AddFirst("Paris");
            list.AddLast("New York");
            list.AddFirst("Johansburg");
            list.AddFirst("Hong Kong");
            list.AddFirst("Brooklyn");
            list.AddLast("Hidden Leaf Village");

            displayList(list);

            list.AddFirst("Benoni");
            list.AddAfter(list.Find("Brooklyn"), "Midrand");

            LinkedListNode<string> node1 = list.Find("Johansburg");
            list.AddBefore(node1, "Cape Town");

            displayList(list);


            Console.ReadLine();
        }

        public static void displayList(LinkedList<String> list)
        {
            foreach (string x in list)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("==================================");
        }
    }
}
