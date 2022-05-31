using System;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in student1.Grades)
            {
                Console.WriteLine(item);

            }
        }
    }
}
