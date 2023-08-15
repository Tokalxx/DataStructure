using System;
using System.Collections.Generic;

namespace DataStructure.Lists.Sorted_Lists
{
    internal class DepartmentList
    {
        static void Main(string[] args)
        {
            SortedList<string, List<string>> list = new SortedList<string, List<string>>();


            list.Add("HR", new List<string> { "Jeffson Barkin", "Mike Frud", "Locker Mac" });
            list.Add("IT", new List<string> { "Falling Down", "Mac Don Ald", "Nor Brick", "Franky One" });
            list.Add("FINANCE", new List<string> { "Don Looker", "Num Ber", "Walker Sprint" });
            list.Add("Security", new List<string> { "PK" });

            displayList(list);
            Console.ReadLine();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        private static void displayList(SortedList<string, List<string>> list)
        {
            foreach (KeyValuePair<string, List<string>> item in list)
            {
                foreach (string y in item.Value)
                {
                    Console.WriteLine($"Dp:{item.Key} - Em:{y}");
                }
            }
        }
    }
}
