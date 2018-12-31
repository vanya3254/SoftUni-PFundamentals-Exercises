using System;

namespace Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");                
            }
        }
    }
}
