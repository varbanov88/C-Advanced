using System;
using System.Linq;

namespace AddVAT
{
    public class AddVAT
    {
        public static void Main()
        {
            Console.ReadLine()
                   .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(double.Parse)
                   .Select(n => n + n * 0.2)
                   .ToList()
                   .ForEach(n => Console.WriteLine($"{n:f2}"));
        }
    }
}
