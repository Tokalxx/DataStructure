using System;

namespace DataStructure.Generics.GenericConstrians
{
    public class GenericConstainstsTester
    {
        static void Main(string[] args)
        {
            MyLinkedList<Student> students = new MyLinkedList<Student>();

            students.addToFirst(new Student(123456789, "John", "Adams"));
            students.addToFirst(new Student(112345678, "Luke", "Adams"));
            students.addToFirst(new Student(122345678, "Nick", "Adams"));
            students.addToFirst(new Student(123345678, "Lebo", "Adams"));

            foreach (Student stu in students)
            {
                Console.WriteLine($"{stu.StudentID} {stu.FirstName} {stu.LastName}");
            }

            Console.ReadLine();

        }
    }
}
