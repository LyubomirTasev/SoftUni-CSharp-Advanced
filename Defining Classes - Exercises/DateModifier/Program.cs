﻿using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.CalculateDiffInDays(firstDate, secondDate);
            Console.WriteLine(days);
        }
    }
}
