using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var countries = new Dictionary<string, long>();
            var countriesWithCities = new Dictionary<string, Dictionary<string, long>>();

            input = GetCountriesAndCitiesData(input, countries, countriesWithCities);

            var countriesOutput = countries.OrderByDescending(i => i.Value);

            PrintResult(countriesWithCities, countriesOutput);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> countriesWithCities, IOrderedEnumerable<KeyValuePair<string, long>> countriesOutput)
        {
            foreach (var item in countriesOutput)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var pair in countriesWithCities)
                {
                    foreach (var city in pair.Value.OrderByDescending(x => x.Value))
                    {
                        if (pair.Key.Equals(item.Key))
                        {
                            Console.WriteLine($"=>{city.Key}: {city.Value}");
                        }
                    }
                }
            }
        }

        private static string[] GetCountriesAndCitiesData(string[] input, Dictionary<string, long> countries, Dictionary<string, Dictionary<string, long>> countriesWithCities)
        {
            while (!input[0].Equals("report"))
            {
                var country = input[1];
                var city = input[0];
                var pupulation = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries[country] = 0;
                }

                countries[country] += pupulation;

                if (!countriesWithCities.ContainsKey(country))
                {
                    countriesWithCities[country] = new Dictionary<string, long>();
                }

                countriesWithCities[country][city] = pupulation;

                input = Console.ReadLine().Split('|').ToArray();
            }

            return input;
        }
    }
}
