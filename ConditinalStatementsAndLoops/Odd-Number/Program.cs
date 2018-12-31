using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; 

            while (true)
            {
                num = int.Parse(Console.ReadLine());
                if (num %2 !=0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
            Console.WriteLine($"The number is: {Math.Abs(num)}");

        }
    }
}
