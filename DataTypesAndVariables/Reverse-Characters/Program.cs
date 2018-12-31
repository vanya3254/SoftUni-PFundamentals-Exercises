using System;

namespace Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string last = Console.ReadLine();

            string temp = "";

            temp = first;
            first = last;
            last = temp;

            string newStr = (first + second + last).ToString();
            Console.WriteLine(newStr);



        }
    }
}
