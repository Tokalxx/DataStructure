using System;

namespace DataStructure.Array
{
    public class UsingArrays
    {
        static void Main(string[] args)
        {
            int[,] array2 =
            {
                {4,7,1},
                {6,8,3 },
                {5,2,10}
            };



            int[,,] array3 =
            {
                {
                    {4,7,1},
                    {6,8,3 },
                    {5,2,10}
                },
                {
                    {5,2,10},
                    {4,7,1},
                    {6,8,3 }

                }
            };

            print2D(array2);
            print3d(array3);



            Console.ReadKey();
        }

        public static void print2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" " + array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void print3d(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(" " + array[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }

}
