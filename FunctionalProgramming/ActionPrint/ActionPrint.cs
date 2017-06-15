using System;
using System.Linq;

namespace ActionPrint
{
    public class ActionPrint
    {
        public static void Main()
        {
            Console.ReadLine()
                   .Split()
                   .ToList()
                   .ForEach(w => Console.WriteLine(w));
        }
    }
}
