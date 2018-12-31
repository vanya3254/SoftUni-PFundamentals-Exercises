using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double courses = (peopleCount / capacity);
            courses = (int)Math.Ceiling(courses);

            Console.WriteLine(courses);
        }
    }
}
