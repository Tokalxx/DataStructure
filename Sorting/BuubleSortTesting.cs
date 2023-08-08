using System;

namespace DataStructure.Sorting
{
    public class BuubleSortTesting
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 9, 3, 6, 7, 8, 1, 5, 4, 10 };


            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.Write("Displaying the array in ascending order: ");
            sortAscending(array);
            DisplayArray(array);

            Console.WriteLine();

            Console.Write("Displaying the array in decending order: ");
            sortDeceding(array);
            DisplayArray(array);


            Console.ReadKey();
        }

        /// <summary>
        /// Method used to sort the array to ascending order
        /// </summary>
        /// <param name="array"></param>
        public static void sortAscending(int[] array)
        {
            for (int x = 0; x < array.Length - 1; x++)
            {
                for (int y = 0; y < array.Length - x - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        int tempValue = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = tempValue;
                    }
                }
            }
        }

        /// <summary>
        /// Method used to sort the array to ascending order
        /// </summary>
        /// <param name="array"></param>
        public static void sortDeceding(int[] array)
        {
            for (int x = 0; x < array.Length - 1; x++)
            {
                for (int y = 0; y < array.Length - x - 1; y++)
                {
                    if (array[y] < array[y + 1])
                    {
                        int tempValue = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = tempValue;
                    }
                }
            }
        }

        public static void DisplayArray(int[] array)
        {
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
        }

    }
}
