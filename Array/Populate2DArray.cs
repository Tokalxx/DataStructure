using System;

namespace DataStructure.Array
{
    public class Populate2DArray
    {
        #region Multidimensional
        static void Main(string[] args)
        {
            int[,] array = new int[5, 3];


            array = populateArray(array, 9);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        /// <summary>
        /// "populateArray method is used to add up the even numbers"
        /// How it works is that it takes num and array are param and using it by adding num upon itself
        /// Then the new values are added into the 2d array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[,] populateArray(int[,] array, int num)
        {
            int x = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = x + num;
                    x = array[i, j];

                }
                Console.WriteLine();
            }
            return array;
        }
        #endregion
    }
}
