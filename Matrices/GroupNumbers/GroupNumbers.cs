﻿using System;
using System.Linq;

namespace GroupNumbers
{
    public class GroupNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            var zero = input.Where(n => Math.Abs(n) % 3 == 0);
            var one = input.Where(n => Math.Abs(n) % 3 == 1);
            var two = input.Where(n => Math.Abs(n) % 3 == 2);

            Console.WriteLine(string.Join(" ", zero));
            Console.WriteLine(string.Join(" ", one));
            Console.WriteLine(string.Join(" ", two));
        }
    }
}
