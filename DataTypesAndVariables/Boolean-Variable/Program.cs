using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();

            bool input = Convert.ToBoolean(boolean);

            if (input)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
