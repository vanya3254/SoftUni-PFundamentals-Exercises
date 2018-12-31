using System;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalCalories = 0;
            int calories = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    calories = 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    calories = 150;
                }
                else if (ingredients == "salami")
                {
                    calories = 600;
                }
                else if (ingredients == "pepper")
                {
                    calories = 50;
                }
                else
                {
                    calories = 0;
                }
                totalCalories += calories;
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
