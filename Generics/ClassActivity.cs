using System;

namespace DataStructure.Generics
{
    internal class ClassActivity
    {
        static void Main(string[] args)
        {


            Console.WriteLine(compare<int>(5, 6));
            Console.WriteLine(compare<double>(3.2, 3.2));
            Console.WriteLine(compare<string>("Sean Maseola", "Maseola Sean"));
            Console.WriteLine(getLength<int, string>(5, "kabelo"));

            Console.ReadKey();





        }


        public static bool compare<T>(T x, T y)
        {
            if (x.GetType() == typeof(string))
            {
                //return x.ToString().ToLower().Equals(y.ToString().ToLower());

                return string.Compare(x.ToString(), y.ToString(), true) == 0;
            }
            return x.Equals(y);
        }

        public static bool getLength<T1, T2>(T1 num, T2 str)
        {
            return str.ToString().Length.Equals(num);
        }

        //public static bool compare(int x, int y)
        //{

        //    return x == y;
        //}
        //public static bool compare(double x, double y)
        //{

        //    return x == y;
        //}
        //public static bool compare(string x, string y)
        //{

        //    return x.Equals(y);
        //}
    }
}
