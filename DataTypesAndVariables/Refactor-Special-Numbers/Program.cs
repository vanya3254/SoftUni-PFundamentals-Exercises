using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int temp = 0;
            bool isValid = false;

            for (int i = 1; i <= n; i++)
            {
                temp = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isValid = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{temp} -> {isValid}");
                sum = 0;
                i = temp;
            }

        }
    }
}
