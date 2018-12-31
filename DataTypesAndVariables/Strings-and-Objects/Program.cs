using System;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            string full = first + " " + second;
            object obj = full;

            Console.WriteLine(obj);
        }
    }
}
