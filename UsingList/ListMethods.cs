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

            Console.WriteLine(checkNum(x));
            Console.WriteLine(checkNum2(x));

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool findNumber(int x, List<int> list)
        {
            return list.Contains(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string checkNum(int num) => num % 2 == 0 ? "Even" :
            num % 3 == 0 ? "Multiply of 3" : "Odd";
        //public static string checkNum(int num) => num % 2 == 0 ? "Even" : "Odd";


        /*string ans = "Odd";
        if (num % 2 == 0)
        {
            ans = "True";
        }
        return ans;*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool checkNum2(int num)
        {
            return num % 2 == 0;
        }



    }
}
