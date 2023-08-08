using System;


namespace DataStructure.Sorting
{
    public class SelectiveSort
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random ranNum = new Random();


            for (int x = 0; x < array.Length; x++)
            {
                array[x] = ranNum.Next(1, 500);
            }
            Console.WriteLine("Unsorted");
            displayMethod(array);
            sortMethod(array);
            Console.WriteLine("Sorted");
            displayMethod(array);

            Console.ReadKey();
        }

        public static void sortMethod(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tempValue = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempValue;
                    }
                }
            }
        }
        public static void displayMethod(int[] array)
        {
            for (int y = 0; y < array.Length; y++)
            {
                Console.Write(array[y] + " ");
                if ((y + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
