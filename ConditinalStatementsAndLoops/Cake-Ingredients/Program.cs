using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient;

            int counter = 0;
            while (true)
            {
                counter++;
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    counter -= 1;
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
