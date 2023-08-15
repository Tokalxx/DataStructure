using System;
using System.Collections.Generic;

namespace DataStructure.Lists.Sorted_Lists
{
    class SortedListRunner
    {
        static void Main(string[] args)
        {
            SortedList<int, String> dic = new SortedList<int, String>();

            List<int> list = new List<int>();


            dic.Add(1, "Seventy-Seven");
            dic.Add(4, "Fifty-Five");
            dic.Add(5, "Thirty-Three");
            dic.Add(2, "Forty-Four");
            dic.Add(3, "Sixty-Six");

            dic.Remove(1);
            dic.RemoveAt(2);



            displayList(dic);

            Console.ReadKey();
        }


        public static void displayList(SortedList<int, string> list)
        {
            foreach (KeyValuePair<int, string> item in list)
            {
                Console.WriteLine(item.Key + "  -  " + item.Value);
            }
        }
    }
}
