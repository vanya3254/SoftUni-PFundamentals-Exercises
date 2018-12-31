using System;

namespace Miles_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputMiles = double.Parse(Console.ReadLine());
            double outputKilometers = inputMiles * 1.60934;
            Console.WriteLine($"{outputKilometers:f2}");
        }
    }
}
