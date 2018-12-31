using System;

namespace Triangle_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 1; col <= n; col++)
            {
                Console.Write(col+ " ");
                for (int row = 1; row < col; row++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();

            }

        }
    }
}
