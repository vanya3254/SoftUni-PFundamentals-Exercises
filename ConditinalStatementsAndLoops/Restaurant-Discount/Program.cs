using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName;
            double totalPrice = 0;
            if (peopleCount <= 50)
            {
                hallName = "Small Hall";
                switch (package)
                {
                    case "Normal": totalPrice = (2500 + 500) - ((2500 + 500) * 0.05);
                        break;
                    case "Gold": totalPrice = (2500 + 750) - ((2500 + 750) * 0.10);
                        break;
                    case "Platinum": totalPrice = (2500 + 1000) - ((2500 + 1000) * 0.15);
                        break;                    
                }
            }
            else if (peopleCount > 50 && peopleCount <=100)
            {
                hallName = "Terrace";
                switch (package)
                {
                    case "Normal":
                        totalPrice = (5000 + 500) - ((5000 + 500) * 0.05);
                        break;
                    case "Gold":
                        totalPrice = (5000 + 750) - ((5000 + 750) * 0.10);
                        break;
                    case "Platinum":
                        totalPrice = (5000 + 1000) - ((5000 + 1000) * 0.15);
                        break;
                }
            }
            else if (peopleCount > 100 && peopleCount <= 120)
            {
                hallName = "Great Hall";
                switch (package)
                {
                    case "Normal":
                        totalPrice = (7500 + 500) - ((7500 + 500) * 0.05);
                        break;
                    case "Gold":
                        totalPrice = (7500 + 750) - ((7500 + 750) * 0.10);
                        break;
                    case "Platinum":
                        totalPrice = (7500 + 1000) - ((7500 + 1000) * 0.15);
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            double pricePerPerson = totalPrice / peopleCount;
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
