using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeStuff
{
    public class StartUp
    {
        public static void Main()
        {
            var ordersAmount = int.Parse(Console.ReadLine());

            var orders = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < ordersAmount; i++)
            {
                var input = Console.ReadLine().Split(new[] { '|', '-', ' '}, StringSplitOptions.RemoveEmptyEntries);
                var company = input.First();
                var amount = int.Parse(input[1]);
                var product = input.Last();

                if (!orders.ContainsKey(company))
                {
                    orders[company] = new Dictionary<string, int>();
                    orders[company][product] = amount;
                }

                else
                {
                    if (!orders[company].ContainsKey(product))
                    {
                        orders[company][product] = amount;
                    }

                    else
                    {
                        orders[company][product] += amount;
                    }
                }
            }

            foreach (var kvp in orders)
            {
                Console.Write("{0}: ", kvp.Key);

                var ordersList = new List<string>();

                foreach (var order in kvp.Value)
                {
                    var sb = new StringBuilder();
                    sb.Append(order.Key).Append(" - ").Append(order.Value);
                    ordersList.Add(sb.ToString());
                }

                Console.WriteLine(string.Join(", ", ordersList));
            }
        }
    }
}
