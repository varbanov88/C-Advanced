using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            var filePath = "../../test.txt";

            using (var reader = new StreamReader(filePath))
            {
                var readLine = reader.ReadLine();
                var counter = 0;

                while (true)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(readLine);
                    }
                    counter++;
                    readLine = reader.ReadLine();
                    if (readLine == null)
                    {
                        break;
                    }
                }
            }
        }
    }
}
