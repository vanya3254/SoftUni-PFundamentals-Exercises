﻿using System;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                if (input == 'a' || input == 'o' || input == 'e' || input == 'u' || input == 'i')
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
