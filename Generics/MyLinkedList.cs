using System;

namespace DataStructure.Generics
{
    public class MyLinkedList<T>
    {


        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(T value)
            {
                this.Data = value;
            }
        }

        private Node head;

        public void addToFirst(T x)
        {
            Node newNode = new Node(x);

            if (head == null)
            {
                head = newNode;

            }
            else
            {
                newNode.Next = head;
                newNode.Previous = null;
                head.Previous = newNode;
                head = newNode;
            }
        }

        public void addToLast(T x)
        {
            Node newNode = new Node(x);
            if (head is null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }

        public void Display()
        {
            /*
             5 
             */
            Node currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;


            }
        }
    }
}
