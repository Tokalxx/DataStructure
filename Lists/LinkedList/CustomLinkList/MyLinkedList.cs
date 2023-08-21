using System;

namespace DataStructure.Lists.CustomLinkList
{
    public class MyLinkedList
    {
        private nodes head;

        public void addToFirst(int x)
        {
            nodes newNode = new nodes(x);

            if (head == null)
            {
                head = newNode;

            }
            else
            {
                newNode.next = head;
                newNode.previous = null;
                head.previous = newNode;
                head = newNode;
            }
        }

        public void addToLast(int x)
        {
            nodes newNode = new nodes(x);
            if (head is null)
            {
                head = newNode;
            }
            else
            {
                nodes currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }

        public void Display()
        {
            /*
             5 
             */
            nodes currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;


            }





        }
    }

    public class nodes
    {

        public nodes previous { get; set; }
        public nodes next { get; set; }
        public int data { get; set; }

        public nodes(int value)
        {
            this.data = value;
        }
    }
}
