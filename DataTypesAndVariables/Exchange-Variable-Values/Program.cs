using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:");
            Console.WriteLine(a+  Environment.NewLine + b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After:");
            Console.WriteLine(a + Environment.NewLine + b);

        }
    }
}
