using System;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantityDrinks = int.Parse(Console.ReadLine());

            double price = 0;
            switch (profession)
            {
                case "Athlete":
                    price = quantityDrinks * 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = quantityDrinks * 1.00;
                    break;
                case "SoftUni Student":
                    price = quantityDrinks * 1.70;
                    break;
                default:
                    price = quantityDrinks * 1.20;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {price:f2}.");
        }
    }
}
