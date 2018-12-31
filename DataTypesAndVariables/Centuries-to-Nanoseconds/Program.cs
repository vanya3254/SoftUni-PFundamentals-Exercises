﻿using System;
using System.Numerics;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            ulong minutes = (ulong) (hours * 60);
            ulong seconds = (minutes * 60);
            ulong miliseconds = (seconds * 1000);
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days}" +
                $" days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} miliseconds " +
                $"= {microseconds} microseconds = {nanoseconds} nanoseconds");


        }
    }
}
