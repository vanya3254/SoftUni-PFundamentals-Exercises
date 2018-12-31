using System;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeterRectangle = (2 * width) + (2 * height);
            double areaRectangle = width * height;
            double diagonalRectangle = Math.Sqrt(width * width + height * height);

            Console.WriteLine(perimeterRectangle);
            Console.WriteLine(areaRectangle);
            Console.WriteLine(diagonalRectangle);


        }
    }
}
