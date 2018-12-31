using System;

namespace Circle_Area__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine($"{area:f12}");
        }
    }
}
