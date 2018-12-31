using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int sum = 0;
            bool isSpecial = false;

            for (int i = 1; i <= n; i++)
            {
                temp = i;
                while (temp != 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                else
                {
                    isSpecial = false;
                }

                sum = 0;

                Console.WriteLine(i + " -> " + isSpecial);
            }
        }
    }
}
