using System;
using System.Collections.Generic;

namespace AMiner_sTask
{
    public class AMinersTask
    {
        public static void Main()
        {
            var resource = Console.ReadLine();
            var resources = new Dictionary<string, int>();

            while (!resource.Equals("stop"))
            {
                var quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = quantity;
                }
                else
                {
                    resources[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
