using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int addMinutes = minutes + 30;
            if (addMinutes > 59)
            {
                hours += 1;
                addMinutes -= 60;
            }

            if (hours >= 24) 
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{addMinutes:d2}");
        }
    }
}
