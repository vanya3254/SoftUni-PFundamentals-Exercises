using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energyContent = (volume * energy) / 100.0;
            double sugarContent = (volume * sugar) / 100;
            Console.WriteLine($"{volume}ml {name}:\n" +
                $"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
