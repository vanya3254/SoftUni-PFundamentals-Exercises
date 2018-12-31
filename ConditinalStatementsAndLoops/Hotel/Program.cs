using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double pricerPerStudio = 0;
            double pricePerDouble = 0;
            double pricePerSuite = 0;
            switch (month)
            {
                case "May":
                case "October":
                    pricerPerStudio = 50;
                    pricePerDouble = 65;
                    pricePerSuite = 75;
                    break;
                case "June":
                case "September":
                    pricerPerStudio = 60;
                    pricePerDouble = 72;
                    pricePerSuite = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    pricerPerStudio = 68;
                    pricePerDouble = 77;
                    pricePerSuite = 89;
                    break;
            }

            if (nightsCount > 7 && (month == "May" || month == "October"))
            {
                pricerPerStudio -= (pricerPerStudio * 0.05);
            }
            else if (nightsCount > 14 && (month == "June " || month == "September"))
            {
                pricePerDouble -= (pricePerDouble * 0.10);
            }
            else if (nightsCount > 14 && (month == "July" || month == "August" || month == "December"))
            {
                pricePerSuite -= (pricePerSuite * 0.15);
            }

            double totalPriceStudio;
            if (nightsCount >7 && (month == "September" || month == "October"))
            {
                totalPriceStudio = (pricerPerStudio * (nightsCount - 1)); 
            }
            else
            {
                totalPriceStudio = pricerPerStudio * nightsCount;
            }

            double totalPriceDouble = pricePerDouble * nightsCount;
            double totalPriceSuite = pricePerSuite * nightsCount;
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");

        }
    }
}
