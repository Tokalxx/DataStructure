using System;

namespace DataStructure.Array
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] array = new int[4][];

            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 6, 4, };
            int[] arr3 = { 7 };
            int[] arr4 = { 9, 10, 45, 77, 100, 44, 71, 34, 96 };

            array[0] = arr1;
            array[1] = arr2;
            array[2] = arr3;
            array[3] = arr4;

            //string[] arr = { "John", "Mark", "David", "Matthew" };
            //string[] arr2 = { "Obed", "Isaiah", "Noah" };

            //string[][] array = { arr, arr2 };


            //string[][] array = new string[4][];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
