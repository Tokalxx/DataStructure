using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.UsingList
{
    public class ListMethods
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Answer is " + findNumber(x, list));

            Console.WriteLine("Sum is " + sumEven(list));

            oddAverage(list);

            multiOf3(list);

            Console.ReadKey();
        }

        public static bool findNumber(int x, List<int> list)
        {
            return list.Contains(x);
        }

        public static int sumEven(List<int> list)
        {
            int total = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] % 2 == 0)
                {
                    total += list[i];
                }
            }
            return total;
        }

        public static void oddAverage(List<int> list)
        {
            double total = 0;
            double counter = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] % 2 != 0)
                {
                    total += list[i];
                    counter++;
                }
            }
            Console.WriteLine($"Average is {(total / counter)}");
        }

        public static void multiOf3(List<int> list)
        {
            foreach (var x in list)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }



    }
}
