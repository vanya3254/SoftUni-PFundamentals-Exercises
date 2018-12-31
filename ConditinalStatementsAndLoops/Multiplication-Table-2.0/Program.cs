using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum <= 10)
            {
                for (int i = secondNum; i <= 10; i++)
                {
                    Console.WriteLine($"{firstNum} X {i} = {firstNum * i}");
                }
            }
            else
            {
                Console.WriteLine($"{firstNum} X {secondNum} = {firstNum * secondNum}");

            }

        }
    }
}
