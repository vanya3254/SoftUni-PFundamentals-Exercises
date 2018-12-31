using System;

namespace Count_The_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter = 0;

            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    break;                    
                }
            }

        }
    }
}
