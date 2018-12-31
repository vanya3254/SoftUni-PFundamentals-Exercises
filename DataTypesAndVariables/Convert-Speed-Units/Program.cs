using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float allSeconds = seconds + (minutes * 60) + ((hours * 60) * 60);
            float allHours = (allSeconds / 60) / 60;

            float meterPerSecond = distance / allSeconds;
            float kmPerHour = (distance / 1000) / allHours;
            float milesPerHours = (distance / 1609.0f) / allHours;

            Console.WriteLine($"{meterPerSecond:f7}");
            Console.WriteLine($"{kmPerHour:f7}");
            Console.WriteLine($"{milesPerHours:f7}");


        }
    }
}
