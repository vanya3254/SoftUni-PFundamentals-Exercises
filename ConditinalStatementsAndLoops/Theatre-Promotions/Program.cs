using System;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            bool earlyAge = age >= 0 && age <= 18;
            bool middleAge = age > 18 && age <= 64;
            bool lateAge = age > 64 && age <= 122;

            int price = 0;
            if (!earlyAge && !middleAge && !lateAge)
            {
                Console.WriteLine("Error!");
                return;
            }
            switch (day)
            {
                case "Weekday":
                    if (earlyAge)
                    {
                        price = 12;
                    }
                    else if (middleAge)
                    {
                        price = 18;
                    }
                    else if (lateAge)
                    {
                        price = 12;
                    }
                    break;
                case "Weekend":
                    if (earlyAge)
                    {
                        price = 15;
                    }
                    else if (middleAge)
                    {
                        price = 20;
                    }
                    else if (lateAge)
                    {
                        price = 15;
                    }
                    break;
                case "Holiday":
                    if (earlyAge)
                    {
                        price = 5;
                    }
                    else if (middleAge)
                    {
                        price = 12;
                    }
                    else if (lateAge)
                    {
                        price = 10;
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            if (price !=0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");

            }


        }
    }
}
