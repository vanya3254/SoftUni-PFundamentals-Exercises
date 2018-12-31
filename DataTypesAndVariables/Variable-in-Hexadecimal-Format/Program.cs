using System;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexa = Console.ReadLine();

            int converted = Convert.ToInt32(hexa, 16);

            Console.WriteLine(converted);
        }
    }
}
