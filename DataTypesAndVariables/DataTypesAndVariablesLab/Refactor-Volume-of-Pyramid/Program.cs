using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Heigth: ");
            double heigth = double.Parse(Console.ReadLine());

            double pyramidVolume = (lenght + width + heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);


        }
    }
}
