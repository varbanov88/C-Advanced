using System;
using System.Collections.Generic;
using System.Linq;

namespace MapDistricts
{
    public class MapDistricts
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var minPopulation = long.Parse(Console.ReadLine());

            var cities = new Dictionary<string, List<long>>();

            foreach (var pair in input)
            {
                var city = pair.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).First();
                var population = pair.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Last();

                if (!cities.ContainsKey(city))
                {
                    cities[city] = new List<long>();
                }

                cities[city].Add(long.Parse(population));
            }

            var result = cities
                    .Where(c => c.Value.Sum() >= minPopulation)
                    .OrderByDescending(c => c.Value.Sum())
                    .ToDictionary(c => c.Key);

            foreach (var city in result)
            {
                Console.Write(city.Key + ": " );
                var pop = city.Value.Value.OrderByDescending(n => n)
                                          .Take(5)
                                          .ToArray();
                Console.WriteLine(string.Join(" ", pop));             
            }
        }
    }
}
