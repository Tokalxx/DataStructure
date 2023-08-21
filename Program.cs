using System;


namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checkValue = true;
            while (checkValue)
            {
                Console.WriteLine("Type two numbers: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(compareInt(num1, num2));

                Console.WriteLine("Want to try again(y/n)");
                string che = Console.ReadLine();

                if (che.ToLower() == "n")
                {
                    checkValue = false;
                }


                Console.ReadKey();
            }

        }

        public static bool compareInt(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
