using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.UsingList
{
    public class ListTester
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 2, 4, 6 };

            Console.WriteLine("Original List");
            disList(num);
            Console.WriteLine("Add 7 to List");
            num.Add(7);
            disList(num);
            Console.WriteLine("Insert 5 between 4 and 6");
            num.Insert(2, 5);
            disList(num);
            Console.WriteLine("Add 1 at the start of the list");
            num.Insert(0, 1);
            disList(num);
            Console.WriteLine("Remove second last element");
            num.RemoveAt(num.Count - 2);
            disList(num);
            Console.WriteLine("Sum of the list");
            Console.WriteLine("Answer: " + addList(num));

            Console.ReadLine();
            //I miss C# and should do it more.

        }
        public static int addList(List<int> list)
        {
            int ans = 0;
            ans = list.Sum();
            return ans;

        }
        public static void disList(List<int> list)
        {
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("*************************************************************");

        }
    }
}
