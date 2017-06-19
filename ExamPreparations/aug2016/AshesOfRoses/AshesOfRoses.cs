using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AshesOfRoses
{
    public class AshesOfRoses
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var roses = new Dictionary<string, Dictionary<string, ulong>>();
            var regionAmount = new Dictionary<string, ulong>();

            while (input != "Icarus, Ignite!")
            {
                var pattern = @"^Grow <\b([A-Z]{1}[a-z]+)> <([A-Za-z0-9]+)> ([0-9]+)$";
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var region = match.Groups[1].Value;
                    var color = match.Groups[2].Value;
                    var amount = ulong.Parse(match.Groups[3].Value);

                    if (!roses.ContainsKey(region))
                    {
                        roses[region] = new Dictionary<string, ulong>();
                        regionAmount[region] = amount;
                    }

                    else
                    {
                        regionAmount[region] += amount;
                    }

                    if (!roses[region].ContainsKey(color))
                    {
                        roses[region][color] = amount;
                    }

                    else
                    {
                        roses[region][color] += amount;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var region in regionAmount.OrderByDescending(a => a.Value).ThenBy(r => r.Key))
            {
                Console.WriteLine(region.Key);

                foreach (var roseSet in roses[region.Key].OrderBy(r => r.Value).ThenBy(r => r.Key))
                {
                    Console.WriteLine($"*--{roseSet.Key} | {roseSet.Value}");
                }
            }
        }
    }
}
