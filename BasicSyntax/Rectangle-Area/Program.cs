using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double wight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = wight * height;
            Console.WriteLine($"{area:f2}");
        }
    }
}
