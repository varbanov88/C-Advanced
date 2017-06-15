using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var bounds = Console.ReadLine().Split();
            var evenOrOdd = Console.ReadLine();

            var lowBound = int.Parse(bounds[0]);
            var highBound = int.Parse(bounds[1]);

            PrintNumbers(lowBound, highBound, evenOrOdd);
        }

        public static void PrintNumbers(int lowBound, int highBound, string evenOrOdd)
        {
            var numbers = new List<int>();
            for (int i = lowBound; i <= highBound; i++)
            {
                numbers.Add(i);
            }

            switch (evenOrOdd)
            {
                case "even":
                    var result = numbers.Where(n => n % 2 == 0 || n % 2 == -1).ToList();
                    Console.WriteLine(string.Join(" ", result));
                    break;

                case "odd":
                    var output = numbers.Where(n => n % 2 == 1 || n % 2 == -1).ToList();
                    Console.WriteLine(string.Join(" ", output));
                    break;
            }
        }
    }
}
