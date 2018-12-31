using System;

namespace Fast_Prime_Checker_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool isValid = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isValid = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isValid}");
            }

        }
    }
}
