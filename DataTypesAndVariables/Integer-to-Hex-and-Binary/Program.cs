using System;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string toHex = Convert.ToString(n, 16).ToUpper();
            string toBin = Convert.ToString(n, 2).ToUpper();

            Console.WriteLine(toHex + Environment.NewLine + toBin);
        }
    }
}
