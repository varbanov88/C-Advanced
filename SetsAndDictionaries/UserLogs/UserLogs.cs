using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var userLog = new SortedDictionary<string, Dictionary<string, int>>();

            while (!input.Equals("end"))
            {
                var data = input.Split();
                var user = data[2].Split('=');
                var username = user[1];
                var ipData = data[0].Split('=');
                var ip = ipData[1];

                if (!userLog.ContainsKey(username))
                {
                    userLog[username] = new Dictionary<string, int>();
                    userLog[username][ip] = 0;
                }

                if (!userLog[username].ContainsKey(ip))
                {
                    userLog[username][ip] = 0;
                }

                userLog[username][ip]++;

                input = Console.ReadLine();
            }

            foreach (var pair in userLog)
            {
                Console.WriteLine($"{pair.Key}: ");

                foreach (var item in pair.Value)
                {
                    if (item.Key != pair.Value.Keys.Last())
                    {
                        Console.Write($"{item.Key} => {item.Value}, ");
                    }

                    else
                    {
                        Console.WriteLine($"{item.Key} => {item.Value}.");
                    }
                }
            }
        }
    }
}
