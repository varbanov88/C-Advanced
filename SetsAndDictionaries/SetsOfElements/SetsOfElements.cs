using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();
            var repeatNumbers = new HashSet<int>();

            for (int i = 0; i < input[0] + input[1]; i++)
            {
                if (i < input[0])
                {
                    nSet.Add(int.Parse(Console.ReadLine()));
                }

                else
                {
                    var num = int.Parse(Console.ReadLine());
                    mSet.Add(num);

                    if (nSet.Contains(num))
                    {
                        repeatNumbers.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join((" "), repeatNumbers));
        }
    }
}
