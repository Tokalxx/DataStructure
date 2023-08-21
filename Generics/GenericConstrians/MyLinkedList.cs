using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.Generics.GenericConstrians
{
    public class MyLinkedList<T> : IEnumerable<T> where T : Student
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


        public IEnumerator<T> GetEnumerator()
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                yield return currentNode.Data;
                currentNode = currentNode.Next;


            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Student(int studentId, string firstName, string lastName)
        {
            StudentID = studentId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}




